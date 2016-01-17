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
            var theCell = "A21";
            sheet.Put(theCell, "A string");
            Assert.That(sheet.Get(theCell), Is.EqualTo("A string"));
        }
    }
}
