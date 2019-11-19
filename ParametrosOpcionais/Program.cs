using System;

namespace ParametrosOpcionais
{
    public class CaixaDialogo
    {
        public void Show(
            string Mensagem,
            bool Ok, bool No,
            //bool Cancel = false,
            int delay = 10,
            int tamanho = 200  // Parametros opcionais deve ser  colocados por ultimo pra evitar ambiguidade
            )
        {
            Console.WriteLine(Mensagem);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var dialogo1 = new CaixaDialogo();
            dialogo1.Show(Mensagem:"Cofirmarr ?",Ok:true, No:true);

            var dialogo2 = new CaixaDialogo();
            dialogo2.Show(Mensagem: "Excluir ?", Ok: true, No: true, tamanho:20);

            Console.ReadLine();
        }
    }
}
