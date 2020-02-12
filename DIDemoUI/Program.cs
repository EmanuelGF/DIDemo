using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BibliotecaDemo;

namespace DIDemoUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplicationStartup>();
                app.run();
            }
                Console.ReadLine();
           

           
        }
    }
}
