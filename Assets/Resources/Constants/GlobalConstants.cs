using Minis;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Main.Assets.Resources.Global
{
    public static class GlobalConstants
    {
        public static List<Type> AllFlashCardTypes = new List<Type>();
        public static GameObject BassWithLedgerPrefab;
        public static GameObject Canvas;
        public static List<IFlashCard> ClefFlashCards = new List<IFlashCard>();
        public static Sprite CorrectNote;
        public static MidiDevice Device;
        public static Sprite Empty;
        public static GameObject GrandStaffWithLedgersPrefab;
        public static Sprite Note;

        public static List<string> NoteLetters = new List<string>()
            {
                "A", "B", "C", "D", "E", "F","G"
            };

        public static Dictionary<string, bool> SettingBools = new Dictionary<string, bool>();
        public static GameObject TrebleWithLedgerPrefab;
        public static Sprite WrongNote;

        public static void LoadConstants()
        {
            CorrectNote = UnityEngine.Resources.Load<Sprite>("Sprites/CorrectNote");
            Note = UnityEngine.Resources.Load<Sprite>("Sprites/Note");
            WrongNote = UnityEngine.Resources.Load<Sprite>("Sprites/WrongNote");
            Empty = UnityEngine.Resources.Load<Sprite>("Sprites/Empty");

            TrebleWithLedgerPrefab = (GameObject)UnityEngine.Resources.Load("Prefabs/Sheet Prefab/TrebleLedgers", typeof(GameObject));
            BassWithLedgerPrefab = (GameObject)UnityEngine.Resources.Load("Prefabs/Sheet Prefab/BassLedgers", typeof(GameObject));
            GrandStaffWithLedgersPrefab = (GameObject)UnityEngine.Resources.Load("Prefabs/Sheet Prefab/GrandStaffLedgers", typeof(GameObject));

            Canvas = GameObject.Find("Canvas");

            var type = typeof(IFlashCard);
            AllFlashCardTypes = System.Reflection.Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToList();
        }
    }
}
