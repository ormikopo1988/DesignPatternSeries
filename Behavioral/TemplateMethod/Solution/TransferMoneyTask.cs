using System;

namespace TemplateMethod.Solution
{
    public class TransferMoneyTask : TaskBase
    {
        public TransferMoneyTask(AuditTrail auditTrail)
            : base(auditTrail)
        {
        }

        protected override void ExecuteTask()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
