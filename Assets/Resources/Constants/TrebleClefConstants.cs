using System.Collections.Generic;

namespace Main.Assets.Resources.Constants
{
    public static class TrebleClefConstants
    {
        public static List<string> LedgerExcludedNotes = new List<string>()
            {
                "D3", "C3", "B3", "A3", "G6"
            };

        public static List<string> LedgerOctaveList = new List<string>()
            {
                "3","4","5","6"
            };

        public static List<string> NoLedgerExcludedNotes = new List<string>()
            {
                "C4", "B4", "A4"
            };

        public static List<string> NoLedgerOctaveList = new List<string>()
            {
                "4", "5"
            };
    }
}
