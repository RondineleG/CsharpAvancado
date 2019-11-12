using System;

namespace PropriedadesAutomaticas
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario()
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Salario = 0;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(123, "Rondinele", 1000);
            Console.ReadLine();
        }
    }
}
