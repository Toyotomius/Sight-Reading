using System.Collections.Generic;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources.Global
{
    public static class HelperMethods
    {
        public static string FindFirstNote(List<string> excludedNotes, List<string> octaveList)
        {
            var note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                            + octaveList[UnityEngine.Random.Range(0, octaveList.Count)];
            while (excludedNotes.Contains(note))
            {
                note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                       + octaveList[UnityEngine.Random.Range(0, octaveList.Count)];
            }
            return note;
        }

        public static string FindSecondNote(List<string> excludedNotes, List<string> octaveList, string firstNote)
        {
            var majorThirdInterval = 3;
            var secondNote = firstNote.NoteFromInterval(majorThirdInterval);
            if (excludedNotes.Contains(secondNote) || !octaveList.Contains(secondNote[1].ToString()))
            {
                secondNote = firstNote.NoteFromInterval(-majorThirdInterval);
            }
            return secondNote;
        }
        public static string FindThirdNote(List<string> excludedNotes, List<string> octaveList, string firstNote,
                                           string secondNote, bool isTriad)
        {
            bool inversions = false;
            bool secondInversion = false;
            if (GameSettings.IncludeInversions && isTriad)
            {
                var coin = UnityEngine.Random.Range(0, 2);
                if (coin == 0)
                {
                    inversions = true;
                    coin = UnityEngine.Random.Range(0, 2);
                    if (coin == 0)
                    {
                        secondInversion = true;
                    }
                }
            }
            string thirdNote;
            if (secondNote[0] < firstNote[0] && secondNote[1] <= firstNote[1])
            {
                if (inversions)
                {
                    thirdNote = firstNote.NoteFromInterval(-6);
                }
                else
                {
                    thirdNote = firstNote.NoteFromInterval(-5);
                }

                if (excludedNotes.Contains(thirdNote))
                {
                    if (inversions)
                    {
                        thirdNote = firstNote.NoteFromInterval(4);
                    }
                    else
                    {
                        thirdNote = firstNote.NoteFromInterval(3);
                    }
                }
            }
            else
            {
                if (inversions)
                {
                    if (secondInversion)
                    {
                        UnityEngine.Debug.Log("2nd");
                        thirdNote = firstNote.NoteFromInterval(-4);
                    }
                    else
                    {
                        thirdNote = firstNote.NoteFromInterval(6);
                    }
                }
                else
                {
                    thirdNote = firstNote.NoteFromInterval(5);
                }
                if (excludedNotes.Contains(thirdNote) || !octaveList.Contains(thirdNote[1].ToString()))
                {
                    if (inversions)
                    {
                        if (secondInversion)
                        {
                            UnityEngine.Debug.Log("2nd");
                            thirdNote = firstNote.NoteFromInterval(3);
                        }
                        else
                        {
                            thirdNote = firstNote.NoteFromInterval(-4);
                        }
                    }
                    else
                    {
                        thirdNote = firstNote.NoteFromInterval(-3);
                    }
                }
            }
            return thirdNote;
        }
    }
}
