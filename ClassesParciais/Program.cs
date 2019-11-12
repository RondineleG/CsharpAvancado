using System;

namespace ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(1, "Rondinele", "senha");
            if (user.Autenticar())
                Console.WriteLine("Usuário autenticado com sucesso");
            else
                Console.WriteLine("Credenciais inválidas");
            Console.ReadLine();
        }
    }
}
