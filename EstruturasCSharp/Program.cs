using System;

namespace EstruturasCSharp
{
    public class PosicaoClass : Object // Reference Type
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }
    }

    public struct PosicaoStruct //Value Type
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }

    }

    public enum Role //Value Type
    {
        Arquiteto, Developer, Tester
    }

    public enum Color //Value Type
    {
        Red, Green, Blue
    }

    public enum DiaDaSemana
    {
        Domingo,
        SegundaFeira,
        TercaFeira,
        QuartaFeira,
        QuintaFeira,
        SextaFeira,
        Sabado


    }
    public enum FormasPagto //Value Type
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass posicaoClass = new PosicaoClass();
            posicaoClass.X = 10;
            posicaoClass.Y = 20;

            PosicaoStruct posicaoStruct = new PosicaoStruct();
            posicaoStruct.X = 30;
            posicaoStruct.Y = 40;

            posicaoClass.X = posicaoStruct.Y;
            PosicaoStruct posicaoStruct1 = posicaoStruct; // cópia
            posicaoStruct1.Y = posicaoClass.X;
            DiaDaSemana diaDaSemana = DiaDaSemana.Domingo;
            FormasPagto formaPagto = FormasPagto.Boleto;
            Role role = Role.Arquiteto;
            Color cor = Color.Blue;
            

            Console.WriteLine(formaPagto);
            Console.WriteLine(role);
            Console.WriteLine(cor);
            Console.WriteLine(diaDaSemana);
            Console.WriteLine(posicaoClass);
            Console.WriteLine(posicaoStruct);
            Console.WriteLine(posicaoStruct1);
            Console.ReadLine();
        }
    }
}
