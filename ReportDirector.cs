//The following class is having one generic method i.e. MakeReport
//which will take the ReportBuilder instance as an input parameter and then create and return a particular report object.

using System;
namespace BuilderDesignPattern
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}