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

        public static List<INotePicker> NotePickers = new List<INotePicker>();
        public static List<Type> NotePickerTypes = new List<Type>();
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

            var flashType = typeof(IFlashCard);
            AllFlashCardTypes = System.Reflection.Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(p => flashType.IsAssignableFrom(p) && !p.IsInterface).ToList();
            var notePickers = typeof(INotePicker);
            NotePickerTypes = System.Reflection.Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(p => notePickers.IsAssignableFrom(p) && !p.IsInterface).ToList();
        }
    }
}
