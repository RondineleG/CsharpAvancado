using System;

namespace ValueType
{
    class Program
    {
        /*
         Quando você passa uma variável
         de tipo de valor de um método 
         para outro método, o sistema
         cria uma cópia separada de uma
         variável em outro método, de
         forma que se o valor for alterado
         no método não afetará
         a variável em outro método.
         */
        static void MudarValor(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        public static void Main()
        {
            int i = 100;
            Console.WriteLine(i);
            MudarValor(i);
            Console.WriteLine(i);
            Console.ReadLine();

            /*
             a variável ino método Main () permanece inalterada
             mesmo após passá-la para o 
             método MudarValor() e alterar seu valor lá.
             */
        }
    }
}
