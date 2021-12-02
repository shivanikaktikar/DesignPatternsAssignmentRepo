//Builder Design Pattern Example
//Suppose we want to develop an application for displaying the reports.
//The reports we need to display either in Excel or in PDF format.
//That means, we have two types of representation of my reports.

using System;
namespace BuilderDesignPattern
{
    public class Report                                         //This is Product Class.
    {
        public string ReportType { get; set; }                  //Defined attributes to create a report.
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }

        public void DisplayReport()                             //DisplayReport to display the report details in the console.
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}