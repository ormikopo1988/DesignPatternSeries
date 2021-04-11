using System;

namespace TemplateMethod.Solution
{
    public class GenerateReportTask : TaskBase
    {
        public GenerateReportTask(AuditTrail auditTrail)
            : base(auditTrail)
        {
        }

        protected override void ExecuteTask()
        {
            Console.WriteLine("Generate Report");
        }
    }
}
