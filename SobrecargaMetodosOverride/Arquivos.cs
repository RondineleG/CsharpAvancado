using System;
using System.Collections;

namespace SobrecargaMetodosOverride
{
   public class Musica : Object
    {
        public string Nome;

        public int Tamanho;

        public void Abrir()
        {
          Console.WriteLine("Tocando Musica :" + Nome);
        }
    }

    public class DocumentoWord : Object
    {
        public string Nome;

        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Mostrando Documento :  " + Nome);
        }
    }

    public class Imagen : Object
    {
        public string Nome;

        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Mostrando Imagem : " + Nome);
        }
    }

    public class Windows
    {
        private ArrayList _arquivos;

        public Windows()
        {
            this._arquivos = new ArrayList();
        }

        public void Add(object arquivo)
        {
            this._arquivos.Add(arquivo);
        }

        public void Abrir(object arquivo)
        {
            if(arquivo is Musica)
            (arquivo as Musica).Abrir();

            if (arquivo is DocumentoWord)
                (arquivo as DocumentoWord).Abrir();

            if (arquivo is Imagen)
                (arquivo as Imagen).Abrir();
        }
    }
}
