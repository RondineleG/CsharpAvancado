using System;
using System.Collections.Generic;

namespace ObjectInitializers
{
    public class Livro
    {
        public string Nome;
        public int Ano;
    }

    public class Escritor
    {
        public int Codigo;
        public string Nome;
        public List<Livro> Livros;      

    }  
    class Program
    {
        static void Main(string[] args)
        {
            Escritor escritor = new Escritor()
            {
                Codigo = 1,
                Nome = "Cecilia Meireles",
                Livros = new List<Livro>()
               {
                   new Livro() { Nome = "Uma noite azul", Ano = 2000 },
                   new Livro() { Nome = "Vida alegre", Ano = 2003 },
                   new Livro() { Nome = "A raposa e galinha", Ano = 2005 }
               }
            };
           Console.ReadLine();
        }
    }
}
