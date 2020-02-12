using BibliotecaDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemoUI
{
    public class ApplicationStartup : IApplicationStartup
    {
        ILogicaDeNegocios _logicaDeNegocios;
        public ApplicationStartup(ILogicaDeNegocios logicaDeNegocios)
        {
            _logicaDeNegocios = logicaDeNegocios;
        }

        public void run()
        {
            _logicaDeNegocios.processaDados();
        }
    }
}
