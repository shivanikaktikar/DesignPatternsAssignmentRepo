using System;
namespace BuilderDesignPattern
{
    public class PDFReport : ReportBuilder          //PDFReport is a concrete Builder Class.
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}