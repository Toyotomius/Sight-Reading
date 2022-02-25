using Main.Assets.Resources.Global;
using Minis;
using UnityEngine;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class FlashCards
    {
        public void ChangeNoteColor(MidiNoteControl note)
        {
            var noteObj = GameObject.Find($"{note.name}");
            var image = noteObj.GetComponent<Image>();
            Sprite correctNote = UnityEngine.Resources.Load<Sprite>("Sprites/CorrectNote");

            image.sprite = correctNote;
        }

        //TODO: Factor in all the options.
        public void GenerateNewFlashCard()
        {
            foreach(Transform transform in GlobalConstants.Canvas.transform)
            {
                GameObject.Destroy(transform.gameObject);
            }
            ClefFlashCards[UnityEngine.Random.Range(0, ClefFlashCards.Count)]
                .Create(GameSettings.IncludeLedgers);
        }
    }
}
