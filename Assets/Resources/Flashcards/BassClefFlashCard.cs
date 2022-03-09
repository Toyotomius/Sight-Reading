using Main.Assets.Resources.Global;
using System;
using UnityEngine;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources.Flashcards
{
    public class BassClefFlashCard : IFlashCard
    {
        public void Create()
        {
            GetOldStaff getOldStaff = new();
            GameObject oldStaff = getOldStaff.HideOldStaff();

            ChooseNotes choose = new();
            var notes = choose.Pick("BassClefFlashCard");
            GameObject staff;
            if (GameSettings.IncludeLedgers)
            {
                staff = ReturnBlankCardWithLedgers();
            }
            else
            {
                staff = ReturnBlankCard();
            }
            foreach (var note in notes)
            {
                try
                {
                    GameObject.Find(note).GetComponent<Image>().sprite = Note;
                    Debug.Log($"{note} was changed to Note sprite");
                }
                catch (NullReferenceException ex)
                {
                    Debug.Log($"{note} does not exist in the bass staff");
                }
            }

            // Stupid Unity UI doing weird things. Gotta be after the new one is created.
            DestroyOldCard(oldStaff);
        }



        public void DestroyOldCard(GameObject oldStaff)
        {
            if (oldStaff != null)
            {
                GameObject.Destroy(oldStaff);
            }
        }

        private GameObject ReturnBlankCard()
        {
            var staff = GameObject.Instantiate(BassClefPrefab, GlobalConstants.Canvas.transform);
            staff.name = "Staff";
            return staff;
        }

        private GameObject ReturnBlankCardWithLedgers()
        {
            var staff = GameObject.Instantiate(BassWithLedgerPrefab, GlobalConstants.Canvas.transform);
            staff.name = "Staff";
            return staff;
        }
    }
}
