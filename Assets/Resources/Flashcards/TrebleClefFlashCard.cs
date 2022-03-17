using Main.Assets.Resources.Global;
using UnityEngine;

namespace Main.Assets.Resources.Flashcards
{
    public class TrebleClefFlashCard : IFlashCard
    {
        public void Create()
        {
            GetOldStaff getOldStaff = new();
            GameObject oldStaff = getOldStaff.HideOldStaff();

            ChooseNotes choose = new();
            var notes = choose.Pick("TrebleClefFlashCard");
            GameObject staff;

            FlashCardHandling cardHandling = new();

            if (GameSettings.IncludeLedgers)
            {
                staff = cardHandling.ReturnBlankCard(GlobalConstants.TrebleWithLedgerPrefab);
            }
            else
            {
                staff = cardHandling.ReturnBlankCard(GlobalConstants.TrebleClefPrefab);
            }

            cardHandling.SetSprites(notes, staff);

            // Stupid Unity UI doing weird things. Gotta be after the new one is created.
            cardHandling.DestroyOldCard(oldStaff);
        }
    }
}
