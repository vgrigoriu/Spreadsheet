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
    }
}
