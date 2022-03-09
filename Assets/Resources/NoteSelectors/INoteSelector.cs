using Main.Assets.Resources.NoteSelectors;
using System.Collections.Generic;

namespace Main.Assets.Resources
{
    public interface INoteSelector
    {
        public List<string> SelectNotes(INotePicker picker, string lowestNote);
        
    }
}