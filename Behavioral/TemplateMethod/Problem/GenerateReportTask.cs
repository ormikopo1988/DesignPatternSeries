using System;

namespace TemplateMethod.Problem
{
    public class GenerateReportTask
    {
        private readonly AuditTrail auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();

            Console.WriteLine("Generate Report");
        }
    }
}
