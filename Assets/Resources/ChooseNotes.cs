using Main.Assets.Resources.Global;
using System.Collections.Generic;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class ChooseNotes
    {
        public List<string> Pick(string FlashCardName)
        {
            var picker = NotePickers[UnityEngine.Random.Range(0, NotePickers.Count)];
            switch (FlashCardName)
            {
                case "GrandStaffFlashCard":
                    {
                        var lowestNote = "B2";
                        INoteSelector noteSelector = new GrandStaffNoteSelector();
                        return noteSelector.SelectNotes(picker, lowestNote);
                    }

                case "BassClefFlashCard":
                    {
                        INoteSelector noteSelector = new BassClefNoteSelector();
                        if (GameSettings.IncludeLedgers)
                        {
                            var lowestNote = "G1";

                            return noteSelector.SelectNotes(picker, lowestNote);
                        }
                        else
                        {
                            var lowestNote = "F2";

                            return noteSelector.SelectNotes(picker, lowestNote);
                        }
                    }
                case "TrebleClefFlashCard":
                    {
                        INoteSelector noteSelector = new TrebleClefNoteSelector();
                        if (GameSettings.IncludeLedgers)
                        {
                            var lowestNote = "E3";

                            return noteSelector.SelectNotes(picker, lowestNote);
                        }
                        else
                        {
                            var lowestNote = "D4";

                            return noteSelector.SelectNotes(picker, lowestNote);
                        }
                    }
                default: return new List<string>();
            }
        }
    }
}
