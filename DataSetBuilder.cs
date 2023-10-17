using FastReport;
namespace FastReportHelper
{
    public class DataSetBuilder
    {
        public static void Build<T>(T o,string outputFileName, string DatasetName="Document",int maxNestingLevel=10)
        {           
            List<T> l = new List<T>
            {
                o
            };
            var r = new Report();
            r.RegisterData(l, DatasetName, maxNestingLevel);
            r.GetDataSource(DatasetName).Enabled = true;
            r.Prepare();
            r.Save(outputFileName); 
        }

        public static void Build<T>(string outputFileName, string DatasetName = "Document", int maxNestingLevel = 10) where T : new()
        {           
            List<T> l = new List<T>
            {
                new T()
            };
            var r = new Report();
            r.RegisterData(l, DatasetName, maxNestingLevel);
            r.GetDataSource(DatasetName).Enabled = true;
            r.Prepare();
            r.Save(outputFileName);
        }
    }
}