using Main.Assets.Resources.Constants;
using Main.Assets.Resources.Global;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources.Flashcards
{
    public class FlashCardHandling
    {
        public void DestroyOldCard(GameObject oldStaff)
        {
            if (oldStaff != null)
            {
                GameObject.Destroy(oldStaff);
            }
        }

        public GameObject ReturnBlankCard(GameObject preFab)
        {
            var staff = GameObject.Instantiate(preFab, GlobalConstants.Canvas.transform);
            staff.name = "Staff";
            return staff;
        }

        public void SetSprites(List<string> notes, GameObject staff)
        {
            foreach (var note in notes)
            {
                try
                {
                    GameObject.Find(note).GetComponent<Image>().sprite = Note;
                    Debug.Log($"{note} was changed to Note sprite");
                }
                catch (NullReferenceException ex)
                {
                    Debug.Log($"{note} does not exist in the bass staff");
                }
            }

            foreach (Transform t in staff.transform)
            {
                Transform lastNote = null;

                for (int i = 0; i <= t.childCount - 2; i++)
                {
                    var note = t.GetChild(i);
                    var nextNote = t.GetChild(i + 1);

                    if (note.GetComponent<Image>().sprite == Note)
                    {
                        lastNote = note;

                        if (nextNote.GetComponent<Image>().sprite == Note)
                        {
                            note.localPosition = new Vector3(80, note.localPosition.y, note.localPosition.z);
                        }
                    }
                }

                if (lastNote is object && lastNote.GetSiblingIndex() - 1 >= 0)
                {
                    var prevNote = t.GetChild(lastNote.GetSiblingIndex() - 1);

                    if (prevNote.GetComponent<Image>().sprite == Note)
                    {
                        lastNote.localPosition = new Vector3(-80, lastNote.localPosition.y, lastNote.localPosition.z);
                        prevNote.localPosition = new Vector3(0, prevNote.localPosition.y, prevNote.localPosition.z);
                    }
                }
            }
        }

        public void SetSprites(List<string> notes, GameObject staff, bool isGrandStaff)
        {
            bool coinFlipped = false;
            int coinFlip = 0;
            foreach (var note in notes)
            {
                if (GrandStaffConstants.Duplicates.Contains(note))
                {
                    // 0 Treble :: 1 bass clef
                    if (!coinFlipped)
                    {
                        coinFlip = UnityEngine.Random.Range(0, 2);
                        coinFlipped = true;
                    }

                    // TODO: Refine for traids/7ths?
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
            }
            foreach (Transform t in staff.transform)
            {
                Transform lastNote = null;

                for (int i = 0; i <= t.childCount - 2; i++)
                {
                    var note = t.GetChild(i);
                    var nextNote = t.GetChild(i + 1);

                    if (note.GetComponent<Image>().sprite == Note)
                    {
                        lastNote = note;

                        if (nextNote.GetComponent<Image>().sprite == Note)
                        {
                            note.localPosition = new Vector3(80, note.localPosition.y, note.localPosition.z);
                        }
                    }
                }
                if (lastNote is object && lastNote.GetSiblingIndex() != 0)
                {
                    var prevNote = t.GetChild(lastNote.GetSiblingIndex() - 1);

                    if (prevNote.GetComponent<Image>().sprite == Note)
                    {
                        lastNote.localPosition = new Vector3(-80, lastNote.localPosition.y, lastNote.localPosition.z);
                        prevNote.localPosition = new Vector3(0, prevNote.localPosition.y, prevNote.localPosition.z);
                    }
                }
            }
        }
    }
}
