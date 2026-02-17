namespace DesignPatternChallenge_Builder;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Relatórios ===");

        var reportDirector = new SalesReportDirector();
        
        var pdfBuilder = new SalesReportFluentBuilder();
        var report1 = reportDirector.BuildPdfReport(pdfBuilder);
        report1.Generate();

        var excelBuilder = new SalesReportFluentBuilder();
        var report2 = reportDirector.BuildExcelReport(excelBuilder);
        report2.Generate();

        var htmlBuilder = new SalesReportFluentBuilder();
        var report3 = reportDirector.BuildHtmlReport(htmlBuilder);
        report3.Generate();
    }
}