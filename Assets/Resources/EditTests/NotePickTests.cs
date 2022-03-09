using Main.Assets.Resources;
using Main.Assets.Resources.Constants;
using Main.Assets.Resources.NoteSelectors;
using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace EditTests.NotePickTests
{
    public class NotePickTests
    {
        // Note: Music intervals are lower inclusive: a fifth interval is C&G for example.

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
        public void SeventhsPicker_Returns_CorrectNotesFor1stInversionChord()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote, Inversions.First, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("D2")
                        && listOfNotes.Contains("F2") && listOfNotes.Contains("G2"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectNotesFor2ndInversionChord()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote, Inversions.Second, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("D2")
                        && listOfNotes.Contains("E2") && listOfNotes.Contains("G2"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectNotesFor3rdInversionChord()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote, Inversions.Third, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("C2")
                        && listOfNotes.Contains("E2") && listOfNotes.Contains("G2"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectNotesFor7thChord()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote, Inversions.None, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("D2")
                        && listOfNotes.Contains("F2") && listOfNotes.Contains("A3"));
        }

        [Test]
        public void SeventhsPicker_Returns_ListOfCount4()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote, Inversions.None, 0, 0);

            Assert.AreEqual(4, listOfNotes.Count);
        }

        [Test]
        public void TriadPicker_Returns_CorrectFirstInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote, Inversions.First, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("D2") && listOfNotes.Contains("G2"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectSecondInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote, Inversions.Second, 0, 0);

            Assert.That(listOfNotes.Contains("B2") && listOfNotes.Contains("E2") && listOfNotes.Contains("G2"));
        }

        

        [Test]
        public void TriadPicker_Returns_ListOfCount3()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "A4";
            var listOfNotes = triadPicker.PickNotes(lowNote, Inversions.None, 0, 0);

            Assert.That(listOfNotes.Count, Is.EqualTo(3));
        }

        [Test]
        public void TriadPicker_Returns_NewChordFromLowerAndUpperBounds()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "A4";
            var listOfNotes = triadPicker.PickNotes(lowNote, Inversions.None, 3, 3);

            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("E4") && listOfNotes.Contains("G4"));
        }

        [Test]
        public void TriadPicker_Returns_NewChordReturnsNotesAtHigherOctave()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "A4";
            var listOfNotes = triadPicker.PickNotes(lowNote, Inversions.None, 4, 4);

            Assert.That(listOfNotes.Contains("D4") && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }
    }
}
