// DESAFIO: Gerador de Relatórios Complexos
// PROBLEMA: Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML)
// com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros)
// O código anterior usava construtores enormes ou muitos setters, tornando difícil criar relatórios.

namespace DesignPatternChallenge_Builder;

public class Program
{
    // Contexto: Sistema de BI que gera relatórios customizados para diferentes departamentos
    // Cada relatório pode ter dezenas de configurações opcionais

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