using System;
using System.Collections.Generic;

namespace PropriedadesIndexadas
{
    class Program
    {
        public class Produtos
        {
            private List<string> _itens;
            public Produtos()
            {
                this._itens = new List<string>();
            }
            public void Add(string item)
            {
                this._itens.Add(item);

            }
            public string Get(int index)
            {
                return this._itens[index];

            }

            //Propriedade indexada

            public string this[int index]
            {
                get
                {
                    //return this.Get[index];
                    return this._itens[index];
                }
            }
        
            public int this [string nome]
            {
                get
                {
                    return this._itens.IndexOf(nome);
                }
            }
        
        }
        static void Main(string[] args)
            {
                var pro = new Produtos();
                pro.Add("Iphone");
                pro.Add("SamSung");
                pro.Add("Ipod");
                pro.Add("LG");
                pro.Add("Motorola");

                Console.WriteLine(pro[0]);
                Console.WriteLine(pro[2]);
                Console.WriteLine(pro[3]);
                Console.WriteLine(pro[1]);

                Console.WriteLine(pro.Get(0));
                Console.WriteLine(pro.Get(2));
                Console.WriteLine(pro.Get(3));
                Console.WriteLine(pro.Get(1));

            Console.WriteLine("A propriendade do Ipod e : " + pro["Ipod"]);

                Console.ReadKey();
            }

        }
    
}

