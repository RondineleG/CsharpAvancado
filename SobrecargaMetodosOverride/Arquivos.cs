using System;
using System.Collections;
using System.Collections.Generic;

namespace SobrecargaMetodosOverride
{
    public abstract class Arquivos
    {
        public string Nome;

        public int Tamanho;

        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo : " + Nome);
        }
        
    }
   public class Musica : Arquivos
    {       
        public override void Abrir()
        {
            base.Abrir();
          Console.WriteLine("Tocando Musica :" + Nome);
        }
    }

    public class DocumentoWord : Arquivos
    {
        
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando Documento :  " + Nome);
        }
    }

    public class Imagen : Arquivos
    {
       
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando Imagem : " + Nome);
        }
    }

    public class Txt : Arquivos
    {

        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando Arquivo texto : " + Nome);
        }
    }
    public class Windows
    {
        private List<Arquivos> _arquivos;

        public Windows()
        {
            this._arquivos = new List<Arquivos>();
        }

        public void Add(Arquivos arquivo)
        {
            this._arquivos.Add(arquivo);
        }

        public void AbrirTodos()
        {
            foreach (Arquivos arquivo in _arquivos)
                Abrir(arquivo);
        }
        public void Abrir(Arquivos arquivo)
        {
            arquivo.Abrir();
        }
    }
}
