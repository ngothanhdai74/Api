using Aspose.Cells;
using Aspose.Words;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Text;

namespace WorkFlow.Helpers
{
    public static class FileHelper
    {
        public static string PdfToFullText(this Stream stream)
        {
            string fullText = "";
            var pdfDocument = new PdfDocument(new PdfReader(stream));
            var strategy = new LocationTextExtractionStrategy();
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page, strategy);
                fullText += Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
            }
            pdfDocument.Close();
            return fullText;
        }
        public static string WordToFullText(this Stream stream)
        {
            try
            {
                var wrdf = new Document(@"C:\Users\User\source\repos\Api\WorkFlow\dait-test.docx");

                wrdf.Save(@"C:\Users\User\source\repos\Api\WorkFlow\dait-test.pdf", Aspose.Words.SaveFormat.Pdf);

                //StringBuilder sResult = new StringBuilder();
                //Aspose.Words.LoadOptions options = new Aspose.Words.LoadOptions();
                //options.LoadFormat = Aspose.Words.LoadFormat.Auto;
                //Document doc = new Document(stream, options);
                //NodeCollection nodes = doc.GetChildNodes(NodeType.Paragraph, true);
                //foreach (Node node in nodes)
                //{
                //    string nodeText = node.ToString(Aspose.Words.SaveFormat.Text);
                //    if (!string.IsNullOrEmpty(nodeText))
                //    {
                //        sResult.Append(node.ToString(Aspose.Words.SaveFormat.Text) + " ");
                //    }
                //}
                //return sResult.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
        public static string ExcelToFullText(Stream stream)
        {
            StringBuilder sResult = new StringBuilder();
            Workbook workbook = new Workbook(stream);
            foreach (Worksheet sheet in workbook.Worksheets)
            {
                for (int row = 0; row <= sheet.Cells.MaxDataRow; row++)
                {
                    for (int col = 0; col <= sheet.Cells.MaxDataColumn; col++)
                    {
                        Cell cell = sheet.Cells[row, col];
                        if (cell.Value != null)
                        {
                            string cellValue = cell.Value.ToString().Trim();
                            if (!string.IsNullOrEmpty(cellValue))
                            {
                                sResult.Append(cellValue + " ");
                            }
                        }
                    }
                }
            }
            return sResult.ToString();
        }
        public static string TxtToFullText(Stream stream)
        {
            using (var streamReader = new StreamReader(stream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
