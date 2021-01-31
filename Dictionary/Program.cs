using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //veri ekliyoruz
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Birisi", 30);

            foreach (var verioku in AdYas)
            {
                Console.WriteLine(verioku);
            }
            //veri sayma özelliği vardır
            var eleman = AdYas.Count;
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı"+":"+eleman);

            //silme işlemide vardır
            AdYas.Remove("Birisi");
            Console.WriteLine();
            foreach (var verioku in AdYas)
            {
                Console.WriteLine(verioku);
            }
            Console.ReadLine();
        }
    }
}
