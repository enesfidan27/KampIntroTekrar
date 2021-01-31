using System;

namespace AbstractKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları çalıştıracağımız yer
            //class(nesneleri)ları örnekledik
            Kopek yeniKopek = new Kopek();
            yeniKopek.Voice();
            Kedi yeniKedi = new Kedi();
            yeniKedi.Voice();
            Kus yeniKus = new Kus();
            yeniKus.Voice();

            Console.ReadLine();
        }

        //abstract class ortak özelliğe sahip nesnelerin 
        //ortak özelliğidir.
        //ezilebilir class

        public abstract class Ses // ortak özellikler ezilecek method
        {
            //ezilebilir bir classım oldu
            //ezilecek olan metodu yaz
            public abstract void Voice();
        }
        //kalıtım alınan : Ses
        public class Kedi : Ses
        {
            //ezilen metodumuz
            public override void Voice()
            {
                Console.WriteLine("miyav");
            }
        }
        public class Kopek : Ses
        {
            public override void Voice()
            {
                Console.WriteLine("hav hav");
            }
        }
        public class Kus : Ses
        {
            public override void Voice()
            {
                Console.WriteLine("gagg gagg");
            }
        }
    }
}
