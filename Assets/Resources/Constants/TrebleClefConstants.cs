using System.Collections.Generic;

namespace Main.Assets.Resources.Constants
{
    public static class TrebleClefConstants
    {
        //public static List<string> LedgerExcludedNotes = new List<string>()
        //    {
        //        "D3", "C3", "B3", "A3", "G6"
        //    };

        //public static List<string> LedgerOctaveList = new List<string>()
        //    {
        //        "3","4","5","6"
        //    };

        //public static List<string> NoLedgerExcludedNotes = new List<string>()
        //    {
        //        "C4", "B4", "A4"
        //    };

        //public static List<string> NoLedgerOctaveList = new List<string>()
        //    {
        //        "4", "5"
        //    };
        public static int InversionWithLedgerUpperBound = 18;
        public static int WithLedgerUpperBound = 19;
        public static int InversionNoLedgerUpperBound = 6;
        public static int NoLedgerUpperBound = 7;
        public static int WithLedgerIndividualNoteUpperBound = 17;
        public static int NoLedgerIndividualNoteUpperBound = 17;

        public static int SeventhsNoLedgerUpperBound = 5;
        public static int SeventhsWithLedgerUpperBound = 17;
        public static int SeventhsWithLedgerInversionsUpperBound = 18;
        public static int SeventhsNoLegerInversionsUpperBound = 6;

        public static int IndividualNoteNoLedgerUpperBound = 11;
        public static int IndividualNoteLedgerUpperBound = 23;
    }

}
