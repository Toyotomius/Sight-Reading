using Main.Assets.Resources.Global;
using UnityEngine;

namespace Main.Assets.Resources
{
    public class RegisterNotePress : MonoBehaviour
    {
        public void Start()
        {
            FlashCards flashCards = new();
            if (GlobalConstants.Device == null)
            {
                return;
            }
            GlobalConstants.Device.onWillNoteOn += (note, _) => flashCards.ChangeNoteColor(note);
        }
    }
}
