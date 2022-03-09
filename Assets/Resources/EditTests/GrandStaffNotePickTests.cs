using Main.Assets.Resources;
using Main.Assets.Resources.Constants;
using Main.Assets.Resources.NoteSelectors;
using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace EditTests.NotePickTests
{
    public class GrandStaffNotePickTests
    {
        // Note: Music intervals are lower inclusive: a fifth interval is C&G for example.

        // Note: Music scale is A-G. G4 leads to A5.
        [Test]
        public void SeventhsPicker_Returns_Correct1stInversionChordUpperBoundWithGrandStaffLedgersWith26()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                                                       Inversions.First,
                                                       GrandStaffConstants.InversionUpperBound,
                                                       GrandStaffConstants.InversionUpperBound);

            Assert.That(listOfNotes.Contains("F5") && listOfNotes.Contains("A6")
                       && listOfNotes.Contains("C6") && listOfNotes.Contains("D6"));
        }

        [Test]
        public void SeventhsPicker_Returns_Correct2ndInversionChordUpperBoundWithGrandStaffLedgersWith26()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                                           Inversions.Second,
                                           GrandStaffConstants.InversionUpperBound,
                                           GrandStaffConstants.InversionUpperBound);

            Assert.That(listOfNotes.Contains("F5") && listOfNotes.Contains("A6")
                       && listOfNotes.Contains("B6") && listOfNotes.Contains("D6"));
        }

        [Test]
        public void SeventhsPicker_Returns_Correct3rdInversionChordUpperBoundWithGrandStaffLedgersWith26()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                                           Inversions.Third,
                                           GrandStaffConstants.InversionUpperBound,
                                           GrandStaffConstants.InversionUpperBound);

            Assert.That(listOfNotes.Contains("F5") && listOfNotes.Contains("G5")
                       && listOfNotes.Contains("B6") && listOfNotes.Contains("D6"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectNoInversionChordUpperBoundWithGrandStaffLedgersWith25()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "B2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                                                       Inversions.None,
                                                       GrandStaffConstants.SeventhsNoInversionUpperBound,
                                                       GrandStaffConstants.SeventhsNoInversionUpperBound);

            Assert.That(listOfNotes.Contains("E5") && listOfNotes.Contains("G5")
                       && listOfNotes.Contains("B6") && listOfNotes.Contains("D6"));
        }
        [Test]
        public void TriadPicker_Returns_CorrectFirstInversionUpperBoundIntervalWithGrandStaffLedgersWith26()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                                    Inversions.First,
                                                    GrandStaffConstants.InversionUpperBound,
                                                    GrandStaffConstants.InversionUpperBound);

            Assert.That(listOfNotes.Contains("F5") && listOfNotes.Contains("A6") && listOfNotes.Contains("D6"));
        }
        [Test]
        public void TriadPicker_Returns_CorrectSecondInversionUpperBoundIntervalWitGrandStaffhLedgersWith26()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                         Inversions.Second,
                                         GrandStaffConstants.InversionUpperBound,
                                         GrandStaffConstants.InversionUpperBound);

            Assert.That(listOfNotes.Contains("F5") && listOfNotes.Contains("B6") && listOfNotes.Contains("D6"));
        }
        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithGrandStaffLedgersNoInversionsWith27()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                              Inversions.None,
                              GrandStaffConstants.TriadNoInversionUpperBound,
                              GrandStaffConstants.TriadNoInversionUpperBound);
            Assert.That(listOfNotes.Contains("G5") && listOfNotes.Contains("B6") && listOfNotes.Contains("D6"));
        }
    }
}
