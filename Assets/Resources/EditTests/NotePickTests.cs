using Main.Assets.Resources;
using Main.Assets.Resources.Global;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.TestTools;

namespace Tests
{
    public class NotePickTests
    {
        // Note: Music intervals are lower inclusive: a fifth interval is C&G for example.

        [Test]
        public void FindSecondNote_Returns_NoteDownByThirdWhenNewNoteOctaveIsTooHigh()
        {
            var excludedNotes = new List<string>() { "Null" };
            var octaveList = new List<string>() { "Null" };
            var firstNote = "C4";
            var secondNote = HelperMethods.FindSecondNote(excludedNotes, octaveList, firstNote);

            Assert.AreEqual("A4", secondNote);
        }

        [Test]
        public void FindSecondNote_Returns_NoteFromMajorThird()
        {
            var excludedNotes = new List<string>() { "Null" };
            var octaveList = new List<string>() { "4" };
            var firstNote = "A4";
            var secondNote = HelperMethods.FindSecondNote(excludedNotes, octaveList, firstNote);

            Assert.AreEqual("C4", secondNote);
        }

        [Test]
        public void FindThirdNote_Returns_NoteFromFifthBelowWhenSecondNoteLowerThanFirst()
        {
            var excludedNotes = new List<string>() { "Null" };
            var octaveList = new List<string>() { "4" };
            var firstNote = "G4";
            var secondNote = "E4";

            var thirdNote = HelperMethods.FindThirdNote(excludedNotes, octaveList,
                                                                firstNote, secondNote, true);
            Assert.AreEqual("C4", thirdNote);
        }

        [Test]
        public void FindThirdNote_Returns_NoteFromFifthInterval()
        {
            var excludedNotes = new List<string>() { "Null" };
            var octaveList = new List<string>() { "4" };
            var firstNote = "A4";
            var secondNote = "C4";

            var thirdNote = HelperMethods.FindThirdNote(excludedNotes, octaveList,
                                                                firstNote, secondNote, true);

            Assert.AreEqual("E4", thirdNote);
        }
        [Test]
        public void FindThirdNote_Returns_LowerNoteWhenHigherNoteOctaveIsTooHigh()
        {
            var excludedNotes = new List<string>() { "Null" };
            var octaveList = new List<string>() { "4" };
            var firstNote = "E4";
            var secondNote = "G4";

            var thirdNote = HelperMethods.FindThirdNote(excludedNotes, octaveList,
                                                                firstNote, secondNote, true);

            Assert.AreEqual("C4", thirdNote);
        }
        [Test]
        public void FIndThirdNote_Returns_LowerNoteWhenHigherNoteIsExcluded()
        {
            var excludedNotes = new List<string>() { "B5" };
            var octaveList = new List<string>() { "4, 5" };
            var firstNote = "E4";
            var secondNote = "G4";

            var thirdNote = HelperMethods.FindThirdNote(excludedNotes, octaveList,
                                                                firstNote, secondNote, true);

            Assert.AreEqual("C4", thirdNote);
        }

        // Note: Music scale is A-G. G4 leads to A5.
        [Test]
        public void NoteIntervalPicker_Returns_CycledNoteAtHigherOctave()
        {
            var note = "G4";
            var newNote = note.NoteFromInterval(2);

            Assert.AreEqual("A5", newNote);
        }

        // Note: Music scale is A-G. A5 goes down to G4.
        [Test]
        public void NoteIntervalPicker_Returns_CycledNoteAtLowerOctave()
        {
            var note = "A5";
            var newNote = note.NoteFromInterval(-2);

            Assert.AreEqual("G4", newNote);
        }

        [Test]
        public void NoteIntervalPicker_Returns_NewNoteBasedOnInterval()
        {
            var note = "A4";
            var newNote = note.NoteFromInterval(2);

            Assert.AreEqual("B4", newNote);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return
        // null;` to skip a frame.
        [UnityTest]
        public IEnumerator NotePickTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions. Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void TriadPicker_Returns_ListOfCount3()
        {
            INotePicker triadPicker = new TriadsPicker();
            var fillerList = new List<string>() { "Null" };
            var listOfNotes = triadPicker.PickNotes(fillerList, fillerList);

            Assert.That(listOfNotes.Count, Is.EqualTo(3));
        }
    }
}
