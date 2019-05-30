using System;
using System.Text;

namespace ValueRef
{
    public class Cliente :Object    // Reference Type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Codigo: " + Codigo);
            stringBuilder.AppendLine("Nome: " + Nome);
            stringBuilder.AppendLine("Telefone: " + Telefone);
            return stringBuilder.ToString();

        }

    }
   
    class Program
    {
        public static void MostraValueTypes()
        {
            Console.WriteLine("Value Types");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            int idade = 10;
            string nome = "Rondinele";
            bool status = false;
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(status);

        }

        public static void MostraReferenceTypes()
        {
            
            

        }

        static void Main(string[] args)
        {

             
            MostraValueTypes();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Reference Types");
            Console.WriteLine("-----------------------------------");
            Cliente cliente = new Cliente();
            cliente.Codigo = 1;
            cliente.Nome = "Beatriz";
            cliente.Telefone = "19988774";
            Console.WriteLine("-----------------------------------");
            Cliente cliente2 = new Cliente(); // aponta para o mesma posição de memória c1
            cliente2 = cliente;
            cliente2.Nome = "Gabriela";
            Console.WriteLine(cliente.Codigo);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Telefone);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Valores sobrescrito com método ToString()");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine(cliente);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(cliente2);
            if (cliente.Equals(cliente2))
            {
                Console.WriteLine("cliente e cliente2 e sao os mesmo objetos");

            }
            else
            {
                Console.WriteLine("cliente e cliente2 e sao objetos diferentes");

            }
            Console.ReadKey();


        }
    }
}
