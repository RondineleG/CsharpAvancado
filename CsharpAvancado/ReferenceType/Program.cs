using System;

namespace ReferenceType
{
    public class Cliente
    {

        public string Nome { get; set; }

    }
    class Program
    {   /*
        Ao contrário dos tipos de valor, um tipo de referência
        não armazena seu valor diretamente. Em vez disso, 
        armazena o endereço onde o valor está sendo armazenado.
        Em outras palavras, um tipo de referência contém um 
        ponteiro para outro local de memória que contém os dados.
        */
        static void MudarValorReferenceType(Cliente cliente)
        {
            cliente.Nome = "Rondinele";
        }

        static void Main(string[] args)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = "Beatriz";           
           
            //imprime o valor pela referencia
            MudarValorReferenceType(novoCliente);
            Console.WriteLine(novoCliente.Nome);
            Console.ReadKey();
            /*
             Como Cliente é um objeto, quando enviamos o objeto 
             Cliente novoCliente para o método ChangeReferenceType(),
             o que é realmente enviado é o endereço de memória de novoCliente.
             Portanto, quando o método ChangeReferenceType() 
             altera Nome, ele está realmente alterando Cliente de novoCliente, 
             porque novoCliente e cliente estão apontando para o mesmo endereço na memória.
             */
        }
    }
}
