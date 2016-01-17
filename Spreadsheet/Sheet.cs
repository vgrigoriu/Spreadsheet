using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            public string Value { get; }

            public Cell(string rawContent)
            {
                Value = IsNumeric(rawContent)
                    ? GetNumericValue(rawContent)
                    : rawContent;
            }

            private static bool IsNumeric(string rawContent)
            {
                return Regex.IsMatch(rawContent, @"^\s*\d+\s*$");
            }

            private static string GetNumericValue(string rawContent)
            {
                return rawContent.Trim();
            }
        }
    }
}
