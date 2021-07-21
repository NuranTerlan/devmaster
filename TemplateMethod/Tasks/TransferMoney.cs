using System;

namespace TemplateMethod.Tasks
{
    public class TransferMoney : TaskTemplate
    {
        public TransferMoney(AuditTrail audit) : base(audit)
        {
        }

        protected override void ExecuteHeart()
        {
            Console.WriteLine("Transferring money..");
        }
    }
}