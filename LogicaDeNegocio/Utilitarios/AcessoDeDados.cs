using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDemo.Utilitarios
{
    public class AcessoDeDados : IAcessoDeDados
    {
        // Estes metodos são para ser usados pelo acesso de dados.
        public void CarregaDados()
        {
            Console.WriteLine("A carregar dados...");
        }

        public void GravaDados(string nome)
        {
            Console.WriteLine($"A gravar {nome}");
        }
    }
}
