using System.Collections.Generic;

namespace Spreadsheet
{
    public class Sheet
    {
        private readonly Dictionary<string, Cell> cells = new Dictionary<string, Cell>();

        public string Get(string cellAddress)
        {
            return cells.ContainsKey(cellAddress) 
                ? cells[cellAddress].Value
                : string.Empty;
        }

        public void Put(string cellAddress, string content)
        {
            cells[cellAddress] = new Cell(content);
        }

        private class Cell
        {
            private readonly string rawContent;

            public string Value => rawContent;

            public Cell(string rawContent)
            {
                this.rawContent = rawContent;
            }
        }
    }
}
