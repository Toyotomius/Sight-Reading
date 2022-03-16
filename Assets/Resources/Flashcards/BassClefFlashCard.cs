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

            FlashCardHandling cardHandling = new();

            if (GameSettings.IncludeLedgers)
            {
                staff = cardHandling.ReturnBlankCard(GlobalConstants.BassWithLedgerPrefab);
            }
            else
            {
                staff = cardHandling.ReturnBlankCard(GlobalConstants.BassClefPrefab);
            }

            cardHandling.SetSprites(notes, staff);

            // Stupid Unity UI doing weird things. Gotta be after the new one is created.
            cardHandling.DestroyOldCard(oldStaff);
        }








    }
}
