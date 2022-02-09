using Main.Assets.Resources.Global;
using System;
using UnityEngine;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class Settings : MonoBehaviour
    {
        public bool IncludeBassClef
        {
            get
            {
                if (!SettingBools.ContainsKey("BassClefFlashCard"))
                {
                    SettingBools.Add("BassClefFlashCard", IncludeBassClef);
                }
                return SettingBools["BassClefFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("BassClefFlashCard"))
                {
                    SettingBools.Add("BassClefFlashCard", IncludeBassClef);
                }
                SettingBools["BassClefFlashCard"] = value;
            }
        }

        public bool IncludeGrandStaff
        {
            get
            {
                if (!SettingBools.ContainsKey("GrandStaffFlashCard"))
                {
                    SettingBools.Add("GrandStaffFlashCard", IncludeGrandStaff);
                }
                return SettingBools["GrandStaffFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("GrandStaffFlashCard"))
                {
                    SettingBools.Add("GrandStaffFlashCard", IncludeGrandStaff);
                }
                SettingBools["GrandStaffFlashCard"] = value;
            }
        }

        public bool IncludeIndividualNotes
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeIndividualNotes"))
                {
                    SettingBools.Add("IncludeIndividualNotes", IncludeIndividualNotes);
                }
                return SettingBools["IncludeIndividualNotes"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeIndividualNotes"))
                {
                    SettingBools.Add("IncludeIndividualNotes", IncludeIndividualNotes);
                }
                SettingBools["IncludeIndividualNotes"] = value;
            }
        }

        public bool IncludeInversions
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeInversions"))
                {
                    SettingBools.Add("IncludeInversions", IncludeInversions);
                }
                return SettingBools["IncludeInversions"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeInversions"))
                {
                    SettingBools.Add("IncludeInversions", IncludeInversions);
                }
                SettingBools["IncludeInversions"] = value;
            }
        }

        public bool IncludeLedgers
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeLedgers"))
                {
                    SettingBools.Add("IncludeLedgers", IncludeLedgers);
                }
                return SettingBools["IncludeLedgers"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeLedgers"))
                {
                    SettingBools.Add("IncludeLedgers", IncludeLedgers);
                }
                SettingBools["IncludeLedgers"] = value;
            }
        }

        public bool IncludeSevenths
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeSevenths"))
                {
                    SettingBools.Add("IncludeSevenths", IncludeSevenths);
                }
                return SettingBools["IncludeSevenths"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeSevenths"))
                {
                    SettingBools.Add("IncludeSevenths", IncludeSevenths);
                }
                SettingBools["IncludeSevenths"] = value;
            }
        }

        public bool IncludeTrebleClef
        {
            get
            {
                if (!SettingBools.ContainsKey("TrebleCleffFlashCard"))
                {
                    SettingBools.Add("TrebleCleffFlashCard", IncludeTrebleClef);
                }
                return SettingBools["TrebleCleffFlashCard"];
            }

            set
            {
                if (!SettingBools.ContainsKey("TrebleCleffFlashCard"))
                {
                    SettingBools.Add("TrebleCleffFlashCard", IncludeTrebleClef);
                }
                SettingBools["TrebleCleffFlashCard"] = value;
            }
        }

        public bool IncludeTriads
        {
            get
            {
                if (!SettingBools.ContainsKey("IncludeTriads"))
                {
                    SettingBools.Add("IncludeTriads", IncludeTriads);
                }
                return SettingBools["IncludeTriads"];
            }

            set
            {
                if (!SettingBools.ContainsKey("IncludeTriads"))
                {
                    SettingBools.Add("IncludeTriads", IncludeTriads);
                }
                SettingBools["IncludeTriads"] = value;
            }
        }

        public void ApplySettings()
        {
            GlobalConstants.ClefFlashCards.Clear();
            foreach (var t in GlobalConstants.AllFlashCardTypes)
            {
                if (SettingBools.ContainsKey(t.Name) && SettingBools[t.Name])
                {
                    GlobalConstants.ClefFlashCards.Add((IFlashCard)Activator.CreateInstance(t));
                }
            }
        }
    }
}
