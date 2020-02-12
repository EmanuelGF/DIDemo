using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDemo.Utilitarios;

namespace BibliotecaDemo
{
    public class LogicaDeNegocios : ILogicaDeNegocios
    {
        ILogger _logger;
        IAcessoDeDados _acessoDeDados;
        public LogicaDeNegocios(ILogger logger, IAcessoDeDados acessoDeDados)
        {
            _logger = logger;
            _acessoDeDados = acessoDeDados;
        }
        public void processaDados()
        {

            _logger.log("Começar o processamento de dados");
            Console.WriteLine("Processando os dados...");
            _acessoDeDados.CarregaDados();
            _acessoDeDados.GravaDados("Os dados processados foram gravados.");
            _logger.log("Processo terminado...");

        }


    }
}
