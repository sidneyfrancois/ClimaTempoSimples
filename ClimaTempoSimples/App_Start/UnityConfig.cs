using ClimaTempoSimples.Context;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ClimaTempoSimples
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<AppDataContext, AppDataContext>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}