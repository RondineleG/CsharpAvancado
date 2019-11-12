using System;

namespace Construtores
{
    public class Contato
    {
        public string Tipo { get; set; }

        public string Descricao { get; set; }

    }

    public class Cliente
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public Contato Contato { get; set; }

        //Contrutor padrao
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        // overloads
        public Cliente(int codigo)
        {
            this.Codigo = codigo;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + ", Nome: " + Nome;
        }



    }
    public class ClienteVIP : Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            : base(codigo, nome) // chamando construtor da classe base
        {
            this.Tempo = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Codigo = 123;
            cliente1.Nome = "Rodinele";
            cliente1.Contato.Tipo = "Telefone";
            cliente1.Contato.Descricao = "99999999";

            Cliente cliente2 = new Cliente(456);
            cliente2.Nome = "Gabriela";

            Cliente cliente3 = new Cliente(789, "Beatriz");

            Cliente cliente4 = new ClienteVIP(123, "Janaina");

            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);
            Console.WriteLine(cliente3);
            Console.WriteLine(cliente4);
            Console.ReadLine();
        }
    }
}
