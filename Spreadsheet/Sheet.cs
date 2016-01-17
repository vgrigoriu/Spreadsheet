namespace Spreadsheet
{
    public class Sheet
    {
        private string cellContent = string.Empty;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "cellAddress")]
        public string Get(string cellAddress)
        {
            return cellContent;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "cellAddress")]
        public void Put(string cellAddress, string content)
        {
            cellContent = content;
        }
    }
}
