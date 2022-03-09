using System.Collections.Generic;

namespace Main.Assets.Resources.NoteSelectors
{

    public class SeventhsPicker : INotePicker
    {
        public string Name { get; } = "SeventhsPicker";
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
                        var fourthNote = lowestNote.NoteFromInterval(7);
                        startingNotes.Add(fourthNote);
                        break;
                    }

                case Inversions.First:
                    {
                        var secondNote = lowestNote.NoteFromInterval(3);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(5);
                        startingNotes.Add(thirdNote);
                        var fourthNote = lowestNote.NoteFromInterval(6);
                        startingNotes.Add(fourthNote);
                        break;
                    }
                case Inversions.Second:
                    {
                        var secondNote = lowestNote.NoteFromInterval(3);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(4);
                        startingNotes.Add(thirdNote);
                        var fourthNote = lowestNote.NoteFromInterval(6);
                        startingNotes.Add(fourthNote);
                        break;
                    }
                case Inversions.Third:
                    {
                        var secondNote = lowestNote.NoteFromInterval(2);
                        startingNotes.Add(secondNote);
                        var thirdNote = lowestNote.NoteFromInterval(4);
                        startingNotes.Add(thirdNote);
                        var fourthNote = lowestNote.NoteFromInterval(6);
                        startingNotes.Add(fourthNote);
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
