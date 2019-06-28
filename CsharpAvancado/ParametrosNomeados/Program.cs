using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    public class DialogoBad
    {
        public void Show(string Mensagem, 
            bool MostrarBotaoOk, bool MostrarBotaoNo,
            bool MostrarBotaoCancel,
            int Delay)
        {
            Console.WriteLine(Mensagem);
        }
    }

    public class Dialogo
    {
        public void Show(DialogoParams parametros)
        {
            Console.WriteLine(parametros.MostrarBotaoNo);
        }
    }

    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostrarBotaoNo;
        public bool MostrarBotaoCancel;
        public int Delay;
        public bool Modal;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dialogoBad = new DialogoBad();
            //string Mensagem = "Confirmar operação?";
            //bool MostrarBotaoOk = true;
            //bool MostrarBotaoNo = true;
            //bool MostrarBotaoCancel = false;
            //int Delay = 10;
            dialogoBad.Show(
                Mensagem: "Confirmar operação?",
                MostrarBotaoOk: true,
                Delay: 10,
                MostrarBotaoNo: true,
                MostrarBotaoCancel: false);

            var parametros = new DialogoParams()
            {
                Mensagem = "Confirmar operação?",
                MostrarBotaoOk = true,
                Delay = 10,
                MostrarBotaoNo = true,
                MostrarBotaoCancel = false,
                Modal = true
            };

            var dialogo = new Dialogo();
            dialogo.Show(parametros: parametros);
            Console.ReadLine();
        }
    }
}
