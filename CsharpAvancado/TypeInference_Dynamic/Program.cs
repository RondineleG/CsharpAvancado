using System;

namespace TypeInferenceDynamic
{
    public class Connection
    {
        public string ConnectionString;

        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnnection()
        {
            return new Connection();
        }
    }
    class Program
    {  

        static void Main(string[] args)
        {
            var teste = "TESTE";
            var numero = 10;
            dynamic v = "TESTE";
            var con = Fabrica.CriarConnnection();
            con.ConnectionString = "BANCO";
            con.Conectar();
            con.Fechar();
            Console.ReadLine();
        }
    }
}
