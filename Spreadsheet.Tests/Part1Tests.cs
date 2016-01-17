using NUnit.Framework;

namespace Spreadsheet.Tests
{
    public class Part1Tests
    {
        //public void testThatCellsAreEmptyByDefault() {
        //        Sheet sheet = new Sheet();
        //  assertEquals("", sheet.get("A1"));
        //  assertEquals("", sheet.get("ZX347"));
        //}
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
        public void ManyCellsExist()
        {
            var sheet = new Sheet();
            sheet.Put("A1", "First");
            sheet.Put("X27", "Second");

            Assert.That(sheet.Get("A1"), Is.EqualTo("First"));
            Assert.That(sheet.Get("X27"), Is.EqualTo("Second"));
        }
    }
}
