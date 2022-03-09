using System.Collections.Generic;

namespace Main.Assets.Resources.Constants
{
    public static class BassClefConstants
    {
        //public static List<string> LedgerExcludedNotes = new List<string>()
        //    {
        //        "A1", "B1", "C1", "D1", "E1", "F1", "B5", "C5", "D5", "E5", "F5", "G5"
        //    };

        //public static List<string> LedgerOctaveList = new List<string>()
        //    {
        //        "1","2","3","4","5"
        //    };

        //public static List<string> NoLedgerExcludedNotes = new List<string>()
        //    {
        //        "E2", "D2", "C2", "B2", "A2", "C4", "D4", "E4", "F4", "G4"
        //    };

        //public static List<string> NoLedgerOctaveList = new List<string>()
        //    {
        //        "2","3","4"
        //    };
        public static int InversionWithLedgerUpperBound = 16;
        public static int WithLedgerUpperBound = 17;
        public static int InversionNoLedgerUpperBound = 6;
        public static int NoLedgerUpperBound = 7;
        public static int WithLedgerIndividualNoteUpperBound = 17;
        public static int NoLedgerIndividualNoteUpperBound = 17;

        public static int SeventhsNoLedgerUpperBound = 5;
        public static int SeventhsWithLedgerUpperBound = 11;
        public static int SeventhsWithLedgerInversionsUpperBound = 12;
        public static int SeventhsNoLegerInversionsUpperBound = 6;

        public static int IndividualNoteNoLedgerUpperBound = 11;
        public static int IndividualNoteLedgerUpperBound = 23;
    }
}
