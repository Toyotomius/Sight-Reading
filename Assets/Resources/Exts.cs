using System;

namespace Main.Assets.Resources
{
    public static class Exts
    {
        public static string NoteFromInterval(this string note, int interval)
        {
            if (note == null || note == String.Empty) return String.Empty;

            // In music intervals are lower inclusive (Eg: 5th interval = C > G). Mathmatically, it
            // requires a 1 int offset (C = 67, G = 71)
            if (interval > 0)
            {
                interval -= 1;
            }
            else
            {
                interval += 1;
            }

            string newNoteLetter = "";

            // 65 = A, 71 = G. Scale goes from A - G.
            if ((note[0] + interval) > 71)
            {
                var diff = (note[0] + interval) - 71;
                var octave = (char)(note[1] + 1);
                newNoteLetter = $"A{octave}".NoteFromInterval(diff);
                return newNoteLetter;
            }
            else if ((note[0] + interval) < 65)
            {
                var diff = note[0] + (interval - 65);
                var octave = (char)(note[1] - 1);
                newNoteLetter = $"G{octave}".NoteFromInterval(diff);
                return newNoteLetter;
            }
            else
            {
                newNoteLetter = ((char)(note[0] + interval)).ToString();
                var newNote = newNoteLetter + note[1];

                return newNote;
            }
        }
    }
}
