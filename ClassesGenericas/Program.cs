namespace ClassesGenericas
{
    public class Pilha<T>
    {
        int posicao = 0;
        T[] itens = new T[100];
        public void Push(T item)
        {
            itens[posicao] = item;
            posicao++;
        }
        public T Pop()
        {
            posicao--;
            return itens[posicao];
        }
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pilha1 = new Pilha<string>();
            pilha1.Push("teste1");
            pilha1.Push("teste2");

            var pilha2 = new Pilha<int>();
            pilha2.Push(10);
            pilha2.Push(20);

            var pilha3 = new Pilha<Cliente>();
            pilha3.Push(new Cliente() { Codigo = 1, Nome = "Guinther" });
            pilha3.Push(new Cliente() { Codigo = 2, Nome = "Rudolfo" });
            Cliente pessoa = pilha3.Pop();
        }
    }
}
