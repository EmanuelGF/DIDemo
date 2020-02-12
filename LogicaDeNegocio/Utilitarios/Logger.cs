using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDemo.Utilitarios
{
    public class Logger : ILogger
    {

        // Para ser usado pela lista de negócios.

        public void log(string mensagem)
        {
            Console.WriteLine($"Info: {mensagem}");
        }
    }
}
