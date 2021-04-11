namespace TemplateMethod.Solution
{
    public abstract class TaskBase
    {
        private readonly AuditTrail auditTrail;

        public TaskBase(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();

            ExecuteTask();
        }

        protected abstract void ExecuteTask();
    }
}
