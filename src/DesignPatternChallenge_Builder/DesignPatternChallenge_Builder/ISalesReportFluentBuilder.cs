namespace DesignPatternChallenge_Builder
{
    internal interface ISalesReportFluentBuilder
    {
        ISalesReportFluentBuilder WithTitle(string title);

        ISalesReportFluentBuilder WithFormat(string format);

        ISalesReportFluentBuilder WithStartDate(DateTime startDate);

        ISalesReportFluentBuilder WithEndDate(DateTime endDate);

        ISalesReportFluentBuilder WithHeader(string text);

        ISalesReportFluentBuilder WithFooter(string text);

        ISalesReportFluentBuilder WithCharts(string chartType);

        ISalesReportFluentBuilder WithSummary();

        ISalesReportFluentBuilder WithColumns(params string[] columns);

        ISalesReportFluentBuilder WithFilters(params string[] filters);

        ISalesReportFluentBuilder WithSorting(string sortBy);

        ISalesReportFluentBuilder WithGrouping(string groupBy);

        ISalesReportFluentBuilder WithTotals();

        ISalesReportFluentBuilder WithOrientation(string orientation);

        ISalesReportFluentBuilder WithPageSize(string pageSize);

        ISalesReportFluentBuilder WithPageNumbers();

        ISalesReportFluentBuilder WithCompanyLogo(string logoPath);

        ISalesReportFluentBuilder WithWatermark(string watermarkText);

        SalesReport Build();
    }
}
