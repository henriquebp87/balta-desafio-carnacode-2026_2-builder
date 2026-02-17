namespace DesignPatternChallenge_Builder;

internal class SalesReportFluentBuilder : ISalesReportFluentBuilder
{
    private readonly SalesReport _report = new();

    public ISalesReportFluentBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public ISalesReportFluentBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public ISalesReportFluentBuilder WithStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }

    public ISalesReportFluentBuilder WithEndDate(DateTime endDate)
    {
        _report.EndDate = endDate;
        return this;
    }

    public ISalesReportFluentBuilder WithHeader(string text)
    {
        _report.IncludeHeader = true;
        _report.HeaderText = text;
        return this;
    }

    public ISalesReportFluentBuilder WithFooter(string text)
    {
        _report.IncludeFooter = true;
        _report.FooterText = text;
        return this;
    }

    public ISalesReportFluentBuilder WithCharts(string chartType)
    {
        _report.IncludeCharts = true;
        _report.ChartType = chartType;
        return this;
    }

    public ISalesReportFluentBuilder WithSummary()
    {
        _report.IncludeSummary = true;
        return this;
    }

    public ISalesReportFluentBuilder WithColumns(params string[] columns)
    {
        _report.Columns = columns.ToList();
        return this;
    }

    public ISalesReportFluentBuilder WithFilters(params string[] filters)
    {
        _report.Filters = filters.ToList();
        return this;
    }

    public ISalesReportFluentBuilder WithSorting(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public ISalesReportFluentBuilder WithGrouping(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public ISalesReportFluentBuilder WithTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }

    public ISalesReportFluentBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public ISalesReportFluentBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public ISalesReportFluentBuilder WithPageNumbers()
    {
        _report.IncludePageNumbers = true;
        return this;
    }

    public ISalesReportFluentBuilder WithCompanyLogo(string logoPath)
    {
        _report.CompanyLogo = logoPath;
        return this;
    }

    public ISalesReportFluentBuilder WithWatermark(string watermarkText)
    {
        _report.WaterMark = watermarkText;
        return this;
    }

    public SalesReport Build() => _report;
}