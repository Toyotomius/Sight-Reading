using System.Collections.Generic;

namespace Main.Assets.Resources
{
    public interface INotePicker
    {
        public List<string> PickNotes(List<string> excludedNotes, List<string> octaveList);
    }
}