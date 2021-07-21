using System;
using TemplateMethod.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditTrail = new AuditTrail();
            TaskTemplate task = new TransferMoney(auditTrail);
            task.Execute();
            task = new GenerateReport(auditTrail);
            task.Execute();
        }
    }
}