using System.Collections.Generic;

namespace Main.Assets.Resources.Constants
{
    public static class GrandStaffConstants
    {
        public static List<string> Duplicates = new List<string>()
        {
            "G3", "A4", "B4", "C4", "D4", "E4", "F4"
        };

        //public static List<string> ExcludedNotes = new List<string>()
        //{
        //    "A2", "E6","F6","G6"
        //};

        //public static List<string> OctaveList = new List<string>()
        //{
        //    "2","3","4","5","6"
        //};
        public static int InversionUpperBound = 26;
        public static int TriadNoInversionUpperBound = 27;
        public static int IndividualNoteUpperBound = 27;
        public static int SeventhsNoInversionUpperBound = 25;
    }
}
