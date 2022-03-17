using Main.Assets.Resources.Constants;
using Main.Assets.Resources.NoteSelectors;
using NUnit.Framework;

namespace EditTests.NotePickTests
{
    public class BassClefNotePickTests
    {
        // Note: Music intervals are lower inclusive: a fifth interval is C&G for example.

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalBassClefNoLedgers2ndInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Second,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("D3") && listOfNotes.Contains("F3")
                                && listOfNotes.Contains("G3") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgers1stInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.First,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("D3") && listOfNotes.Contains("F3")
                                && listOfNotes.Contains("A4") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgers3rdInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Third,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound,
                              BassClefConstants.SeventhsNoLegerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("D3") && listOfNotes.Contains("E3")
                                && listOfNotes.Contains("G3") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgersNoInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.None,
                              BassClefConstants.SeventhsNoLedgerUpperBound,
                              BassClefConstants.SeventhsNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("C3") && listOfNotes.Contains("E3")
                                && listOfNotes.Contains("G3") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefWithLedgers1stInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.First,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("E4")
                                && listOfNotes.Contains("G4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefWithLedgers2ndInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Second,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("E4")
                                && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefWithLedgers3rdInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.Third,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound,
                              BassClefConstants.SeventhsWithLedgerInversionsUpperBound);

            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("D4")
                                && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void SeventhsPicker_Returns_CorrectUpperBoundIntervalWithBassClefWithLedgersNoInversions()
        {
            INotePicker seventhsPicker = new SeventhsPicker();
            var lowNote = "F2";
            var listOfNotes = seventhsPicker.PickNotes(lowNote,
                              Inversions.None,
                              BassClefConstants.SeventhsWithLedgerUpperBound,
                              BassClefConstants.SeventhsWithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("B4") && listOfNotes.Contains("D4")
                                && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }

        // Note: Music scale is A-G. G4 leads to A5.
        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefLedgers1stInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                         Inversions.First,
                                         BassClefConstants.InversionWithLedgerUpperBound,
                                         BassClefConstants.InversionWithLedgerUpperBound);
            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("E4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefLedgers2ndInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                         Inversions.Second,
                                         BassClefConstants.InversionWithLedgerUpperBound,
                                         BassClefConstants.InversionWithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("C4") && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefLedgersNoInversions()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "B2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                                          Inversions.None,
                                          BassClefConstants.WithLedgerUpperBound,
                                          BassClefConstants.WithLedgerUpperBound);

            Assert.That(listOfNotes.Contains("D4") && listOfNotes.Contains("F4") && listOfNotes.Contains("A5"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgers1stInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "F2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                              Inversions.First,
                              BassClefConstants.InversionNoLedgerUpperBound,
                              BassClefConstants.InversionNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("D3") && listOfNotes.Contains("F3") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgers2ndInversion()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "F2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                               Inversions.Second,
                               BassClefConstants.InversionNoLedgerUpperBound,
                               BassClefConstants.InversionNoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("D3") && listOfNotes.Contains("G3") && listOfNotes.Contains("B4"));
        }

        [Test]
        public void TriadPicker_Returns_CorrectUpperBoundIntervalWithBassClefNoLedgersNoInversions()
        {
            INotePicker triadPicker = new TriadsPicker();
            var lowNote = "F2";
            var listOfNotes = triadPicker.PickNotes(lowNote,
                              Inversions.None,
                              BassClefConstants.NoLedgerUpperBound,
                              BassClefConstants.NoLedgerUpperBound);

            Assert.That(listOfNotes.Contains("E3") && listOfNotes.Contains("G3") && listOfNotes.Contains("B4"));
        }
    }
}
