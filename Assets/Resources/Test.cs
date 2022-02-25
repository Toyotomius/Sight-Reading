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
            GrandStaffFlashCard gsCards = new();

            gsCards.Create(GameSettings.IncludeLedgers);
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
            GameSettings.IncludeGrandStaff = true;
            GameSettings.IncludeLedgers = true;
            GameSettings.IncludeTriads = true;
            GameSettings.IncludeInversions = true;
            settings.ApplySettings();
            GrandStaffFlashCard gsCards = new();
            gsCards.Create(true); //TODO: Just for testing.
        }
    }
}
