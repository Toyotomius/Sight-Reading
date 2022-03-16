using Main.Assets.Resources.Constants;
using Main.Assets.Resources.Flashcards;
using Main.Assets.Resources.Global;
using System;
using UnityEngine;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class GrandStaffFlashCard : IFlashCard
    {
        public void Create()
        {
            GetOldStaff getOldStaff = new();
            GameObject oldStaff = getOldStaff.HideOldStaff();

            ChooseNotes choose = new();
            var notes = choose.Pick("GrandStaffFlashCard");
            GameObject staff;

            FlashCardHandling cardHandling = new();
            if (GameSettings.IncludeLedgers)
            {
                staff = cardHandling.ReturnBlankCard(GrandStaffWithLedgersPrefab);
            }

            //TODO: Revisit. Make a decision on whether grand staff will have ledgers or not
            else
            {
                staff = cardHandling.ReturnBlankCard(GrandStaffWithLedgersPrefab);
            }

            cardHandling.SetSprites(notes, staff, true);

            // Stupid Unity UI doing weird things. Gotta be after the new one is created.
            cardHandling.DestroyOldCard(oldStaff);
        }
    }
}
