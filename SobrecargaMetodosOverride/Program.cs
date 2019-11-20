using System;

namespace SobrecargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivos mp3 = new Musica() { Nome = "Ola" };
            Arquivos doc = new DocumentoWord() { Nome = "Mundo" };
            Arquivos image = new Imagen() { Nome = "Dia" };
            Arquivos txt = new Txt() { Nome = "Curriculo" };

            var windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(image);
            windows.Add(txt);

            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(image);
            windows.Abrir(txt);
        }

    }
}
