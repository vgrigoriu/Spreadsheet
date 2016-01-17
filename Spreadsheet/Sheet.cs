using System.Collections.Generic;

namespace Spreadsheet
{
    public class Sheet
    {
        private readonly Dictionary<string, string> cells = new Dictionary<string, string>();

        public string Get(string cellAddress)
        {
            return cells.ContainsKey(cellAddress) 
                ? cells[cellAddress] 
                : string.Empty;
        }

        public void Put(string cellAddress, string content)
        {
            cells[cellAddress] = content;
        }
    }
}
