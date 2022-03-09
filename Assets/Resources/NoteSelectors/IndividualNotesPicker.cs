using System.Collections.Generic;

namespace Main.Assets.Resources.NoteSelectors
{
    public class IndividualNotesPicker : INotePicker
    {
        public string Name { get; } = "IndividualNotesPicker";
        public List<string> PickNotes(string lowestNote, Inversions inversions, int lowerBound, int upperBound)
        {
            var interval = UnityEngine.Random.Range(lowerBound, upperBound);
            var note = lowestNote.NoteFromInterval(interval);
            

            return new List<string> { note };
        }
    }
}
