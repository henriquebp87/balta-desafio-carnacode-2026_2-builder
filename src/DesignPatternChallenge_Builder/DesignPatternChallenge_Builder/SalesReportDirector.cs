namespace DesignPatternChallenge_Builder;

internal class SalesReportDirector
{
    public SalesReport BuildPdfReport(ISalesReportFluentBuilder builder)
    {
        return builder
            .WithTitle("Vendas Mensais")
            .WithFormat("PDF")
            .WithStartDate(new DateTime(2024, 1, 1))
            .WithEndDate(new DateTime(2024, 1, 31))
            .WithHeader("Relatório de Vendas Mensais - Janeiro")
            .WithFooter("Confidencial")
            .WithCharts("Bar")
            .WithSummary()
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithFilters("Status=Ativo")
            .WithSorting("Valor")
            .WithGrouping("Categoria")
            .WithTotals()
            .WithOrientation("Portrait")
            .WithPageSize("A4")
            .WithPageNumbers()
            .WithCompanyLogo("logo.png")
            .WithWatermark("Confidencial")
            .Build();
    }

    public SalesReport BuildExcelReport(ISalesReportFluentBuilder builder)
    {
        return builder
            .WithTitle("Vendas Trimestrais")
            .WithFormat("Excel")
            .WithStartDate(new DateTime(2024, 1, 1))
            .WithEndDate(new DateTime(2024, 3, 31))
            .WithColumns("Vendedor", "Região", "Total")
            .WithFilters("Status=Ativo")
            .WithCharts("Line")
            .WithHeader("Relatório Trimestral - Janeiro a Março")
            .WithGrouping("Região")
            .WithTotals()
            .Build();
    }

    public SalesReport BuildHtmlReport(ISalesReportFluentBuilder builder)
    {
        return builder
            .WithTitle("Vendas Anuais")
            .WithFormat("HTML")
            .WithStartDate(new DateTime(2024, 1, 1))
            .WithEndDate(new DateTime(2024, 12, 31))
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithFilters("Status=Ativo")
            .WithHeader("Relatório Anual - 2024")
            .WithFooter("Confidencial")
            .WithCharts("Pie")
            .WithSummary()
            .Build();
    }
}