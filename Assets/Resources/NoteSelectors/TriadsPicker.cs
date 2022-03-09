using System.Collections.Generic;

namespace Main.Assets.Resources.NoteSelectors
{
    //public class TriadsPicker : INotePicker
    //{
    //    public List<string> PickNotes(List<string> excludedNotes, List<string> octaveList)
    //    {
    //        var notes = new List<string>();

    // var firstNote = FindFirstNote(excludedNotes, octaveList); notes.Add(firstNote);

    // var secondNote = FindSecondNote(excludedNotes, octaveList, firstNote); notes.Add(secondNote);

    // string lastNote = FindThirdNote(excludedNotes, octaveList, firstNote, secondNote, true); notes.Add(lastNote);

    //        return notes;
    //    }
    //}
    public class TriadsPicker : INotePicker
    {
        public string Name { get; } = "TriadsPicker";
        public List<string> PickNotes(string lowestNote, Inversions inversions, int lowerBound, int upperBound)
        {
            var interval = UnityEngine.Random.Range(lowerBound, upperBound);
            var startingNotes = new List<string>();
            startingNotes.Add(lowestNote);
            switch (inversions)
            {
                case Inversions.None:
                    {
                        var secondNote = lowestNote.NoteFromInterval(3);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(5);
                        startingNotes.Add(thirdNote);
                        break;
                    }

                case Inversions.First:
                    {
                        var secondNote = lowestNote.NoteFromInterval(3);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(6);
                        startingNotes.Add(thirdNote);
                        break;
                    }
                case Inversions.Second:
                    {
                        var secondNote = lowestNote.NoteFromInterval(4);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(6);
                        startingNotes.Add(thirdNote);
                        break;
                    }
            }

            var notes = new List<string>();

            foreach (var note in startingNotes)
            {
                var newNote = note.NoteFromInterval(interval);
                notes.Add(newNote);
            }

            return notes;
        }
    }
}
