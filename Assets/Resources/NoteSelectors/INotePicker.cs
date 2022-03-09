using System.Collections.Generic;

namespace Main.Assets.Resources.NoteSelectors
{
    public interface INotePicker
    {
        public List<string> PickNotes(string lowestNote, Inversions inversions, int lowerBound, int upperBound);
        public string Name { get; }
    }
}