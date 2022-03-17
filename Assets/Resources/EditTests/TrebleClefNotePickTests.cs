using Main.Assets.Resources.Constants;
using Main.Assets.Resources.NoteSelectors;
using NUnit.Framework;

namespace EditTests.NotePickTests
{
    public class TrebleClefNotePickTests
    {
        // Note: Music intervals are lower inclusive: a fifth interval is C&G for example.

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgers1stInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "D4";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.First,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("B5") && listOfNotes.Contains("D5")
                                && listOfNotes.Contains("F5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgers2ndInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "D4";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Second,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("B5") && listOfNotes.Contains("D5")
                                && listOfNotes.Contains("E5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgers3rdInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "D4";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Third,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound,
                              TrebleClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("B5") && listOfNotes.Contains("C5")
                                && listOfNotes.Contains("E5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgersNoInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "D4";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.None,
                              TrebleClefConstants.SeventhsNoLedgerUpperBound,
                              TrebleClefConstants.SeventhsNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("A5") && listOfNotes.Contains("C5")
                                && listOfNotes.Contains("E5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgers1stInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "E3";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.First,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("A6") && listOfNotes.Contains("C6")
                                && listOfNotes.Contains("E6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgers2ndInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "E3";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Second,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("A6") && listOfNotes.Contains("C6")
                                && listOfNotes.Contains("D6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgers3rdInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "E3";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Third,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              TrebleClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("A6") && listOfNotes.Contains("B6")
                                && listOfNotes.Contains("D6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgersNoInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "E3";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.None,
                              TrebleClefConstants.SeventhsWithLedgerUpperBound,
                              TrebleClefConstants.SeventhsWithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("G5") && listOfNotes.Contains("B6")
                                && listOfNotes.Contains("D6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgers1stInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "D4";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                              Inversions.First,
                              TrebleClefConstants.InversionNoLedgerUpperBound,
                              TrebleClefConstants.InversionNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("B5") && listOfNotes.Contains("D5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgers2ndInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "D4";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                               Inversions.Second,
                               TrebleClefConstants.InversionNoLedgerUpperBound,
                               TrebleClefConstants.InversionNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("B5") && listOfNotes.Contains("E5") && listOfNotes.Contains("G5"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefNoLedgersNoInversions()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "D4";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                              Inversions.None,
                              TrebleClefConstants.NoLedgerUpperBound,
                              TrebleClefConstants.NoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("C5") && listOfNotes.Contains("E5") && listOfNotes.Contains("G5"));
        }

        // Note: Music scale is A-G. G4 leads to A5.
        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgers1stInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "E3";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                         Inversions.First,
                                         TrebleClefConstants.InversionWithLedgerUpperBound,
                                         TrebleClefConstants.InversionWithLedgerUpperBound);
            Assert.That(listOfNotes.Contains("A6") && listOfNotes.Contains("C6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgers2ndInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "E3";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                         Inversions.Second,
                                         TrebleClefConstants.InversionWithLedgerUpperBound,
                                         TrebleClefConstants.InversionWithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("A6") && listOfNotes.Contains("D6") && listOfNotes.Contains("F6"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalTrebleClefWithLedgersNoInversions()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "E3";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                          Inversions.None,
                                          TrebleClefConstants.WithLedgerUpperBound,
                                          TrebleClefConstants.WithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("B6") && listOfNotes.Contains("D6") && listOfNotes.Contains("F6"));
        }
    }
}
