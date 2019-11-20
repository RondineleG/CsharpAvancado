using System;

namespace ParametrosSobrecarga
{
    public class CaixaDialogo
    {
        //Default
        public void Show(string Mensagen)
        {
            Console.WriteLine(Mensagen);
        }

        public void Show(string Mensagen, int Delay = 10)
        {
            Show(Mensagen);
        }
        public void Show(string Mensagen, Double Delay, bool Ok, bool No)
        {
            Show(Mensagen);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var dialog1 = new CaixaDialogo();
            dialog1.Show("Confirmar");

            var dialog2 = new CaixaDialogo();
            dialog2.Show("Excluir", 10);
            var dialog3 = new CaixaDialogo();
            dialog2.Show("Tem certeza ", Delay: 20, Ok:true, No: true);
            Console.ReadLine();
        }
    }
}
