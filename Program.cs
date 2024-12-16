using Template_Method_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Генерация отчета по студентам:");
        ReportGenerator studentReport = new StudentReportGenerator();
        studentReport.GenerateReport();

        Console.WriteLine("\nГенерация отчета по курсам:");
        ReportGenerator courseReport = new CourseReportGenerator();
        courseReport.GenerateReport();
    }
}