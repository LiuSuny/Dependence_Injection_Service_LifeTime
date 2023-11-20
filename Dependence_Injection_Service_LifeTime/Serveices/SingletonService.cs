namespace Dependence_Injection_Service_LifeTime.Serveices
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid Id;

        public SingletonService()
        {
            Id = Guid.NewGuid();
        }
        public string GetService()
        {
            return Id.ToString();
        }
    }
}
