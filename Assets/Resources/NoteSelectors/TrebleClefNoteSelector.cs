using Main.Assets.Resources.Global;
using Main.Assets.Resources.NoteSelectors;
using System.Collections.Generic;
using static Main.Assets.Resources.Constants.TrebleClefConstants;

namespace Main.Assets.Resources
{
    public class TrebleClefNoteSelector : INoteSelector
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
                                    if (GameSettings.IncludeLedgers)
                                    {
                                        return picker.PickNotes(lowestNote, Inversions.Second,
                                                                0, InversionWithLedgerUpperBound);
                                    }
                                    return picker.PickNotes(lowestNote, Inversions.Second,
                                                            0, InversionNoLedgerUpperBound);
                                }
                                else
                                {
                                    if (GameSettings.IncludeLedgers)
                                    {
                                        return picker.PickNotes(lowestNote, Inversions.First,
                                                                0, InversionWithLedgerUpperBound);
                                    }
                                    return picker.PickNotes(lowestNote, Inversions.First,
                                                            0, InversionNoLedgerUpperBound);
                                }
                            }
                        }

                        // 0 on coinflip = no inversion
                        if (GameSettings.IncludeLedgers)
                        {
                            return picker.PickNotes(lowestNote, Inversions.None, 0, WithLedgerUpperBound);
                        }
                        return picker.PickNotes(lowestNote, Inversions.None, 0, NoLedgerUpperBound);
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
                                    if (GameSettings.IncludeLedgers)
                                    {
                                        return picker.PickNotes(lowestNote, Inversions.Second, 0,
                                                                SeventhsWithLedgerInversionsUpperBound);
                                    }
                                    return picker.PickNotes(lowestNote, Inversions.Second, 0,
                                                            SeventhsNoLegerInversionsUpperBound);
                                }
                                else if (thirdInversion)
                                {
                                    if (GameSettings.IncludeLedgers)
                                    {
                                        return picker.PickNotes(lowestNote, Inversions.Third, 0,
                                                                SeventhsWithLedgerInversionsUpperBound);
                                    }
                                    return picker.PickNotes(lowestNote, Inversions.Third, 0,
                                                            SeventhsNoLegerInversionsUpperBound);
                                }
                                else
                                {
                                    if (GameSettings.IncludeLedgers)
                                    {
                                        return picker.PickNotes(lowestNote, Inversions.First, 0,
                                                                SeventhsWithLedgerInversionsUpperBound);
                                    }
                                    return picker.PickNotes(lowestNote, Inversions.First, 0,
                                                            SeventhsNoLegerInversionsUpperBound);
                                }
                            }
                        }

                        // 0 on coinflip = no inversion
                        if (GameSettings.IncludeLedgers)
                        {
                            return picker.PickNotes(lowestNote, Inversions.None, 0,
                                                    SeventhsWithLedgerUpperBound);
                        }
                        return picker.PickNotes(lowestNote, Inversions.None, 0,
                                                SeventhsNoLedgerUpperBound);
                    }
                case "IndividualNotesPicker":
                    {
                        if (GameSettings.IncludeLedgers)
                        {
                            return picker.PickNotes(lowestNote, Inversions.None, 0,
                                                    IndividualNoteLedgerUpperBound);
                        }
                        return picker.PickNotes(lowestNote, Inversions.None, 0,
                                                IndividualNoteNoLedgerUpperBound);
                    }
            }
            return new List<string>();
        }
    }
}
