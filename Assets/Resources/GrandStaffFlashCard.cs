﻿using Main.Assets.Resources.Constants;
using Main.Assets.Resources.Global;
using System;
using UnityEngine;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class GrandStaffFlashCard : IFlashCard
    {
        public void Create(bool includeLedgers)
        {
            var oldStaff = GameObject.Find("Staff");
            if (oldStaff != null)
            {
                oldStaff.SetActive(false);
            }

            var note = ChooseNote();
            GameObject staff;
            if (includeLedgers)
            {
                staff = ReturnBlankCardWithLedgers();
            }
            else
            {
                staff = ReturnBlankCard();
            }

            if (GrandStaffConstants.Duplicates.Contains(note))
            {
                // 0 Treble :: 1 bass clef
                var coinFlip = UnityEngine.Random.Range(0, 2);
                switch (coinFlip)
                {
                    case 1:
                        {
                            try
                            {
                                staff.transform.Find("BassClef").transform.Find(note).GetComponent<Image>().sprite = Note;
                                Debug.Log($"{note} in bass was changed to Note sprite");
                            }
                            catch (NullReferenceException ex)
                            {
                                Debug.Log($"{note} does not exist in the grand staff");
                            }
                            break;
                        }
                    default:
                        {
                            try
                            {
                                staff.transform.Find("TrebleClef").transform.Find(note).GetComponent<Image>().sprite = Note;
                                Debug.Log($"{note} in Treble was changed to Note sprite");
                            }
                            catch (NullReferenceException ex)
                            {
                                Debug.Log($"{note} does not exist in the grand staff");
                            }
                            break;
                        }
                }
            }
            else
            {
                try
                {
                    GameObject.Find(note).GetComponent<Image>().sprite = Note;
                    Debug.Log($"{note} was changed to Note sprite");
                }
                catch (NullReferenceException ex)
                {
                    Debug.Log($"{note} does not exist in the grand staff");
                }
            }

            // Stupid Unity UI doing weird things. Gotta be after the new one is created.
            DestroyOldCard(oldStaff);
        }

        public void DestroyOldCard(GameObject oldStaff)
        {
            if (oldStaff != null)
            {
                GameObject.Destroy(oldStaff);
            }
        }

        private string ChooseNote()
        {
            var note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                           + GrandStaffConstants.OctaveList[UnityEngine.Random.Range(0, GrandStaffConstants.OctaveList.Count)];
            while (GrandStaffConstants.ExcludedNotes.Contains(note))
            {
                note = NoteLetters[UnityEngine.Random.Range(0, NoteLetters.Count)]
                           + GrandStaffConstants.OctaveList[UnityEngine.Random.Range(0, GrandStaffConstants.OctaveList.Count)];
            }
            return note;
        }

        private GameObject ReturnBlankCard()
        {
            var empty = new GameObject();
            return empty;
        }

        private GameObject ReturnBlankCardWithLedgers()
        {
            var staff = GameObject.Instantiate(GrandStaffWithLedgersPrefab, GlobalConstants.Canvas.transform);
            staff.name = "Staff";
            return staff;
        }
    }
}
