using static Main.Assets.Resources.Constants.GrandStaffConstants;
using Main.Assets.Resources.Global;
using Main.Assets.Resources.NoteSelectors;
using System.Collections.Generic;

namespace Main.Assets.Resources
{
    public class GrandStaffNoteSelector : INoteSelector
    {
        public List<string> SelectNotes(INotePicker picker, string lowestNote)
        {
            switch (picker.Name)
            {
                case "TriadsPicker":
                    {
                        if (GameSettings.IncludeInversions)
                        {
                            var coinFlip = UnityEngine.Random.Range(0, 3);
                            bool secondInversion = coinFlip == 2 ? true : false;

                            // use inversions
                            if (coinFlip > 0)
                            {
                                if (secondInversion)
                                {
                                    return picker.PickNotes(lowestNote, Inversions.Second, 0, InversionUpperBound);
                                }
                                else
                                {
                                    return picker.PickNotes(lowestNote, Inversions.First, 0, InversionUpperBound);
                                }
                            }
                        }

                        // 0 on coinflip = no inversion
                        return picker.PickNotes(lowestNote, Inversions.None, 0, TriadNoInversionUpperBound);
                    }
                case "SeventhsPicker":
                    {
                        if (GameSettings.IncludeInversions)
                        {
                            var coinFlip = UnityEngine.Random.Range(0, 4);
                            bool secondInversion = coinFlip == 2 ? true : false;
                            bool thirdInversion = coinFlip == 3 ? true : false;

                            // use inversions
                            if (coinFlip > 0)
                            {
                                if (secondInversion)
                                {
                                    return picker.PickNotes(lowestNote, Inversions.Second, 0, InversionUpperBound);
                                }
                                else if (thirdInversion)
                                {
                                    return picker.PickNotes(lowestNote, Inversions.Third, 0, InversionUpperBound);
                                }
                                else
                                {
                                    return picker.PickNotes(lowestNote, Inversions.First, 0, InversionUpperBound);
                                }
                            }
                        }

                        // 0 on coinflip = no inversion
                        return picker.PickNotes(lowestNote, Inversions.None, 0, SeventhsNoInversionUpperBound);
                    }
                case "IndividualNotesPicker":
                    {
                        return picker.PickNotes(lowestNote, Inversions.None, 0, IndividualNoteUpperBound);
                    }
            }
            return new List<string>();
        }
    }
}
