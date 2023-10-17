using FastReport;
using FastReport.Export.PdfSimple;


namespace FastReportHelper
{
    public class ReportBuilder
    {
        public static void BuildPDF<T>(T o, string templateFileName,Stream s, string DatasetName="Document")
        {
            var l = new List<T>
            {
                o
            };

            var r = new Report();
            r.Load(templateFileName);
            r.RegisterData(l, DatasetName, 10);
            r.Prepare();

            PDFSimpleExport p = new PDFSimpleExport();
            p.Export(r,s);
        }




    }
}
