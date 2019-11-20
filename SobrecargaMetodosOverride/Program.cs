using System;

namespace SobrecargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp3 = new Musica() { Nome = "Ola" };
            var doc = new DocumentoWord() { Nome = "Mundo" };
            var image = new Imagen() { Nome = "Dia" };

            var windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(image);

            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(image);
        }

    }
}
