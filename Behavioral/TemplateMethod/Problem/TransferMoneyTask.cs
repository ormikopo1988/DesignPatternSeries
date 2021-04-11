using System;

namespace TemplateMethod.Problem
{
    public class TransferMoneyTask
    {
        private readonly AuditTrail auditTrail;

        public TransferMoneyTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();

            Console.WriteLine("Transfer Money");
        }
    }
}
