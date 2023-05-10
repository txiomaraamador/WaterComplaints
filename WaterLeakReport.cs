class WaterLeakReport
{
    public string Location { get; set; }
    public DateTime ReportDate { get; set; }
    public TimeSpan LeakTime { get; set; }
    public string ReporterName { get; set; }
    public string Description { get; set; }
    public string GeoreferencedLocation { get; set; }
    public int Severity { get; set; }
    public TimeSpan ReportTime { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}