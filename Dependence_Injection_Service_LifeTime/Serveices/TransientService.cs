namespace Dependence_Injection_Service_LifeTime.Serveices
{
    public class TransientService : ITransientServce
    {
        private readonly Guid Id;

        public TransientService()
        {
            Id = Guid.NewGuid();
        }
        public string GetService()
        {
            return Id.ToString();
        }
    }
}
