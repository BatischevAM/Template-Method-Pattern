using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о студентах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о студентах.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет о студентах отформатирован.");
        }
    }
}
