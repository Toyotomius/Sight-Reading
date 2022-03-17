using Main.Assets.Resources;
using Main.Assets.Resources.Global;
using Minis;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace SightReading
{
    public class Test : MonoBehaviour
    {
        public void ChangeColor(MidiNoteControl note)
        {
            var C4 = GameObject.Find("C4");
            var image = C4.GetComponent<Image>();
            Sprite correctNote = Resources.Load<Sprite>("Sprites/CorrectNote");

            image.sprite = correctNote;
        }

        public void GenerateNewFlashCard()
        {
            GlobalConstants.ClefFlashCards[UnityEngine.Random.Range(0, GlobalConstants.ClefFlashCards.Count)]
                .Create();
        }

        public void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
                GenerateNewFlashCard();
        }

        private void Start()
        {
            GlobalConstants.LoadConstants();

            var settings = GlobalConstants.Canvas.GetComponent<Settings>();
            GameSettings.IncludeGrandStaff = false;
            GameSettings.IncludeLedgers = false;
            GameSettings.IncludeSevenths = true;
            GameSettings.IncludeInversions = true;
            GameSettings.IncludeIndividualNotes = false;
            GameSettings.IncludeTriads = false;
            GameSettings.IncludeBassClef = false;
            GameSettings.IncludeTrebleClef = true;
            settings.ApplySettings();

            GlobalConstants.ClefFlashCards[UnityEngine.Random.Range(0, GlobalConstants.ClefFlashCards.Count)]
                .Create();
            //GrandStaffFlashCard gsCards = new();
            //gsCards.Create(true); //TODO: Just for testing.
        }
    }
}
