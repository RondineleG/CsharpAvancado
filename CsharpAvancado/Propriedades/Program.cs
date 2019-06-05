using System;

namespace Propriedades
{

    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int _matricula;
        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;

        public int Matricula
        {
            get
            {
                return this._matricula;
            }
            set
            {
                this._matricula = value;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                //valida numeros negativos
                if (value < 0)
                    throw new Exception("Valor da mensalidade não pode ser negativo");
                else
                    _mensalidade = value;
            }
        }

        public TipoAluno Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = 123;
            aluno.Nome = "Rondinele";
            aluno.Mensalidade = 100;
            aluno.Tipo = TipoAluno.Regular;
            Console.WriteLine(aluno.Nome);
            Console.ReadLine();
        }
    }
}


