namespace Dependence_Injection_Service_LifeTime.Serveices
{
    public class ScopedService : IScopedService
    {
        private readonly Guid Id;

        public ScopedService()
        {
            Id = Guid.NewGuid();
        }
        public string GetService()
        {
            return Id.ToString();
        }
    }
}
