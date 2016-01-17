using NUnit.Framework;

namespace Spreadsheet.Tests
{
    [TestFixture]
    public class Part1Tests
    {
        //public void testThatCellsAreEmptyByDefault() {
        //        Sheet sheet = new Sheet();
        //  assertEquals("", sheet.get("A1"));
        //  assertEquals("", sheet.get("ZX347"));
        //}
        [Test]
        public void CellsAreEmptyByDefault()
        {
            var sheet = new Sheet();
            Assert.That(sheet.Get("A1"), Is.Empty);
            Assert.That(sheet.Get("ZX347"), Is.Empty);
        }

        //public void testThatTextCellsAreStored()
        //{
        //    Sheet sheet = new Sheet();
        //    String theCell = "A21";

        //    sheet.put(theCell, "A string");
        //    assertEquals("A string", sheet.get(theCell));

        //    sheet.put(theCell, "A different string");
        //    assertEquals("A different string", sheet.get(theCell));

        //    sheet.put(theCell, "");
        //    assertEquals("", sheet.get(theCell));
        //}
        [Test]
        public void TextCellsAreStored()
        {
            var sheet = new Sheet();
            const string theCell = "A21";
            sheet.Put(theCell, "A string");
            Assert.That(sheet.Get(theCell), Is.EqualTo("A string"));
        }

        //public void testThatManyCellsExist()
        //{
        //    Sheet sheet = new Sheet();
        //    sheet.put("A1", "First");
        //    sheet.put("X27", "Second");
        //    sheet.put("ZX901", "Third");

        //    assertEquals("A1", "First", sheet.get("A1"));
        //    assertEquals("X27", "Second", sheet.get("X27"));
        //    assertEquals("ZX901", "Third", sheet.get("ZX901"));

        //    sheet.put("A1", "Fourth");
        //    assertEquals("A1 after", "Fourth", sheet.get("A1"));
        //    assertEquals("X27 same", "Second", sheet.get("X27"));
        //    assertEquals("ZX901 same", "Third", sheet.get("ZX901"));
        //}
        [Test]
        public void ManyCellsExist()
        {
            var sheet = new Sheet();
            sheet.Put("A1", "First");
            sheet.Put("X27", "Second");

            Assert.That(sheet.Get("A1"), Is.EqualTo("First"));
            Assert.That(sheet.Get("X27"), Is.EqualTo("Second"));
        }

        //public void testThatNumericCellsAreIdentifiedAndStored()
        //{
        //    Sheet sheet = new Sheet();
        //    String theCell = "A21";

        //    sheet.put(theCell, "X99"); // "Obvious" string
        //    assertEquals("X99", sheet.get(theCell));

        //    sheet.put(theCell, "14"); // "Obvious" number
        //    assertEquals("14", sheet.get(theCell));

        //    sheet.put(theCell, " 99 X"); // Whole string must be numeric
        //    assertEquals(" 99 X", sheet.get(theCell));

        //    sheet.put(theCell, " 1234 "); // Blanks ignored
        //    assertEquals("1234", sheet.get(theCell));

        //    sheet.put(theCell, " "); // Just a blank
        //    assertEquals(" ", sheet.get(theCell));
        //}
        [Test]
        public void NumericCellsAreIdentifiedAndStored()
        {
            var sheet = new Sheet();
            const string theCell = "B14";

            sheet.Put(theCell, "14");
            Assert.That(sheet.Get(theCell), Is.EqualTo("14"));

            sheet.Put(theCell, " 99 X");
            Assert.That(sheet.Get(theCell), Is.EqualTo(" 99 X"));

            sheet.Put(theCell, " 1234 ");
            Assert.That(sheet.Get(theCell), Is.EqualTo("1234"));

            sheet.Put(theCell, " ");
            Assert.That(sheet.Get(theCell), Is.EqualTo(" "));
        }
    }
}
