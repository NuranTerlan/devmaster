using System;

namespace TemplateMethod.Tasks
{
    public class GenerateReport : TaskTemplate
    {
        public GenerateReport(AuditTrail audit) : base(audit)
        {
        }

        protected override void ExecuteHeart()
        {
            Console.WriteLine("Generating report..");
        }
    }
}