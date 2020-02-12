using Autofac;
using BibliotecaDemo;
using BibliotecaDemo.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DIDemoUI
{
    //A classe não será instanciada
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            // Create your builder.
            var builder = new ContainerBuilder();

            // Usually you're only interested in exposing the type
            // via its interface:
            builder.RegisterType<LogicaDeNegocios>().As<ILogicaDeNegocios>();
            builder.RegisterType<ApplicationStartup>().As<IApplicationStartup>();
            builder.RegisterType<AcessoDeDados>().As<IAcessoDeDados>();
            builder.RegisterType<Logger>().As<ILogger>();
            
            // However, if you want BOTH services (not as common)
            // you can say so:
            //builder.RegisterType<SomeType>().AsSelf().As<IService>();

            //Vai buscar a Interface correcta dentro da pasta "Utilitarios" ... mas ñ está a funcionar... :(
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(BibliotecaDemo))).
            //    Where(t => t.Namespace.Contains("Utilitarios")).
            //    As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();

        }
    }
}
