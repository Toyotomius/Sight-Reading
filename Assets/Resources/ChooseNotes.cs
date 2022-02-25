using Main.Assets.Resources.Constants;
using Main.Assets.Resources.Global;
using System.Collections.Generic;
using static Main.Assets.Resources.Global.GlobalConstants;
using static Main.Assets.Resources.Global.HelperMethods;

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
                        return picker.PickNotes(GrandStaffConstants.ExcludedNotes, GrandStaffConstants.OctaveList);
                    }
                case "BassClefFlashCard":
                    {
                        if (GameSettings.IncludeLedgers)
                        {
                            return picker.PickNotes(BassClefConstants.LedgerExcludedNotes, BassClefConstants.LedgerOctaveList);
                        }
                        else
                        {
                            return picker.PickNotes(BassClefConstants.NoLedgerExcludedNotes, BassClefConstants.NoLedgerOctaveList);
                        }
                    }
                case "TrebleClefFlashCard":
                    {
                        return new List<string>();
                    }
                default: return new List<string>();
            }
        }
    }

    public class IndividualNotesPicker : INotePicker
    {
        public List<string> PickNotes(List<string> excludedNotes, List<string> octaveList)
        {
            var note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                            + octaveList[UnityEngine.Random.Range(0, octaveList.Count)];
            while (excludedNotes.Contains(note))
            {
                note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                       + octaveList[UnityEngine.Random.Range(0, octaveList.Count)];
            }

            return new List<string> { note };
        }
    }

    public class SeventhsPicker : INotePicker
    {
        public List<string> PickNotes(List<string> excludedNotes, List<string> octaveList)
        {
            // TODO: Account for inversions
            return new List<string>();
        }
    }

    public class TriadsPicker : INotePicker
    {
        public List<string> PickNotes(List<string> excludedNotes, List<string> octaveList)
        {
            var notes = new List<string>();

            var note = FindFirstNote(excludedNotes, octaveList);
            notes.Add(note);

            var secondNote = FindSecondNote(excludedNotes, octaveList, note);
            notes.Add(secondNote);

            string lastNote = FindThirdNote(excludedNotes, octaveList, note, secondNote, true);
            notes.Add(lastNote);

            return notes;
        }
    }
}
