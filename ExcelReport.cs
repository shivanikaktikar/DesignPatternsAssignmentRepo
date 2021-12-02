//This ExcelReport class implements the ReportBuilder abstract class which is the blueprint for creating the report objects.


using System;
namespace BuilderDesignPattern
{
    class ExcelReport : ReportBuilder            //ExcelReport is a concrete Builder Class.
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}