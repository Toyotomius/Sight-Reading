using System.Collections.Generic;

namespace Main.Assets.Resources.Constants
{
    public static class BassClefConstants
    {
        public static List<string> LedgerExcludedNotes = new List<string>()
            {
                "A1", "B1", "C1", "D1", "E1", "F1", "B5", "C5", "D5", "E5", "F5", "G5"
            };

        public static List<string> LedgerOctaveList = new List<string>()
            {
                "1","2","3","4","5"
            };

        public static List<string> NoLedgerExcludedNotes = new List<string>()
            {
                "E2", "D2", "C2", "B2", "A2", "C4", "D4", "E4", "F4", "G4"
            };

        public static List<string> NoLedgerOctaveList = new List<string>()
            {
                "2","3","4"
            };
    }
}
