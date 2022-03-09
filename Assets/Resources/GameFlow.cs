using UnityEngine;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class GameFlow
    {
        private Settings settingsScript;

        public GameFlow()
        {
            settingsScript = GameObject.Find("SettingsGameObject").GetComponent<Settings>();
        }

        public void GameStart()
        {
            //TODO: Start coroutine to handle input confirmation to start game
        }

        public void NewFlashCard()
        {
            ClefFlashCards[Random.Range(0, ClefFlashCards.Count)].Create();
        }
    }
}
