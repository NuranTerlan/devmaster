namespace TemplateMethod
{
    public abstract class TaskTemplate
    {
        private readonly AuditTrail _audit;

        protected TaskTemplate(AuditTrail audit)
        {
            _audit = audit;
        }

        public void Execute()
        {
            _audit.Record();
            ExecuteHeart();
        }

        protected abstract void ExecuteHeart();
    }
}