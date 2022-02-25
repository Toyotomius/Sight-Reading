using System.Collections.Generic;

namespace Main.Assets.Resources.Global
{
    public static class GameSettings
    {
        internal static Dictionary<string, bool> SettingBools = new Dictionary<string, bool>();

        public static bool IncludeBassClef
        {
            get
            {
                if (!SettingBools.ContainsKey("BassClefFlashCard"))
                {
                    SettingBools.Add("BassClefFlashCard", false);
                }
                return SettingBools["BassClefFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("BassClefFlashCard"))
                {
                    SettingBools.Add("BassClefFlashCard", false);
                }
                SettingBools["BassClefFlashCard"] = value;
            }
        }

        public static bool IncludeGrandStaff
        {
            get
            {
                if (!SettingBools.ContainsKey("GrandStaffFlashCard"))
                {
                    SettingBools.Add("GrandStaffFlashCard", false);
                }
                return SettingBools["GrandStaffFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("GrandStaffFlashCard"))
                {
                    SettingBools.Add("GrandStaffFlashCard", false);
                }
                SettingBools["GrandStaffFlashCard"] = value;
            }
        }

        public static bool IncludeIndividualNotes
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeIndividualNotes"))
                {
                    SettingBools.Add("IncludeIndividualNotes", false);
                }
                return SettingBools["IncludeIndividualNotes"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeIndividualNotes"))
                {
                    SettingBools.Add("IncludeIndividualNotes", false);
                }
                SettingBools["IncludeIndividualNotes"] = value;
            }
        }

        public static bool IncludeInversions
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeInversions"))
                {
                    SettingBools.Add("IncludeInversions", false);
                }
                return SettingBools["IncludeInversions"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeInversions"))
                {
                    SettingBools.Add("IncludeInversions", false);
                }
                SettingBools["IncludeInversions"] = value;
            }
        }

        public static bool IncludeLedgers
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeLedgers"))
                {
                    SettingBools.Add("IncludeLedgers", false);
                }
                return SettingBools["IncludeLedgers"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeLedgers"))
                {
                    SettingBools.Add("IncludeLedgers", false);
                }
                SettingBools["IncludeLedgers"] = value;
            }
        }

        public static bool IncludeSevenths
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeSevenths"))
                {
                    SettingBools.Add("IncludeSevenths", false);
                }
                return SettingBools["IncludeSevenths"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeSevenths"))
                {
                    SettingBools.Add("IncludeSevenths", false);
                }
                SettingBools["IncludeSevenths"] = value;
            }
        }

        public static bool IncludeTrebleClef
        {
            get
            {
                if (!SettingBools.ContainsKey("TrebleCleffFlashCard"))
                {
                    SettingBools.Add("TrebleCleffFlashCard", false);
                }
                return SettingBools["TrebleCleffFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("TrebleCleffFlashCard"))
                {
                    SettingBools.Add("TrebleCleffFlashCard", false);
                }
                SettingBools["TrebleCleffFlashCard"] = value;
            }
        }

        public static bool IncludeTriads
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeTriads"))
                {
                    SettingBools.Add("IncludeTriads", false);
                }
                return SettingBools["IncludeTriads"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeTriads"))
                {
                    SettingBools.Add("IncludeTriads", false);
                }
                SettingBools["IncludeTriads"] = value;
            }
        }
    }
}
