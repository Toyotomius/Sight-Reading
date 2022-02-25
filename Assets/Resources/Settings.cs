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

                return GameSettings.IncludeBassClef;
            }

            set
            {

                GameSettings.IncludeBassClef = value;
            }
        }

        public bool IncludeGrandStaff
        {
            get
            {

                return GameSettings.IncludeGrandStaff;
            }

            set
            {
                GameSettings.IncludeGrandStaff = value;
            }
        }

        public bool IncludeIndividualNotes
        {
            get
            {
                return GameSettings.IncludeIndividualNotes;
            }

            set
            {
                GameSettings.IncludeIndividualNotes = value;
            }
        }

        public bool IncludeInversions
        {
            get
            {
                return GameSettings.IncludeInversions;
            }

            set
            {
                GameSettings.IncludeInversions = value;
            }
        }

        public bool IncludeLedgers
        {
            get
            {
                return GameSettings.IncludeLedgers;
            }

            set
            {
                GameSettings.IncludeLedgers = value;
            }
        }

        public bool IncludeSevenths
        {
            get
            {
                return GameSettings.IncludeSevenths;
            }

            set
            {
                GameSettings.IncludeSevenths = value;
            }
        }

        public bool IncludeTrebleClef
        {
            get
            {
                return GameSettings.IncludeTrebleClef;
            }

            set
            {
                GameSettings.IncludeTrebleClef = value;
            }
        }

        public bool IncludeTriads
        {
            get
            {
                return GameSettings.IncludeTriads;
            }

            set
            {
                GameSettings.IncludeTriads = value;
            }
        }

        public void ApplySettings()
        {
            GlobalConstants.ClefFlashCards.Clear();
            foreach (var t in GlobalConstants.AllFlashCardTypes)
            {
                if (GameSettings.SettingBools.ContainsKey(t.Name) && GameSettings.SettingBools[t.Name])
                {
                    GlobalConstants.ClefFlashCards.Add((IFlashCard)Activator.CreateInstance(t));
                }
            }
            GlobalConstants.NotePickers.Clear();
            foreach (var t in GlobalConstants.NotePickerTypes)
            {
                var name = t.Name.Replace("Picker", "");
                var tempName = "Include" + name;
                if (GameSettings.SettingBools.ContainsKey(tempName) && GameSettings.SettingBools[tempName])
                {
                    GlobalConstants.NotePickers.Add((INotePicker)Activator.CreateInstance(t));
                }
            }
        }
    }
}
