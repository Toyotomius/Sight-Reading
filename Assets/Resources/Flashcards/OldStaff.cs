using UnityEngine;

namespace Main.Assets.Resources.Flashcards
{
    public class GetOldStaff
    {
        public GameObject HideOldStaff()
        {
            var oldStaff = GameObject.Find("Staff");
            if (oldStaff != null)
            {
                oldStaff.SetActive(false);
            }

            return oldStaff;
        }
    }
}
