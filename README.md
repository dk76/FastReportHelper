# FastReportHelper
Simple creation of a template with a dataset from a class, and export to PDF

For example, we have the Person class:

 ```csharp
public class Person
{
    public string Name { get; set; }
    public List<Person> children { get; set; }
}
 ```

Save dataset from class to report template:

 ```csharp
 DataSetBuilder.Build<Person>("report.frx");
 ```

Create report:

 ```csharp
FileStream fs = new FileStream("report.pdf", FileMode.Create, FileAccess.ReadWrite);
ReportBuilder.BuildPDF(new Person { Name="Tom"},"report.frx",fs);
 ```

