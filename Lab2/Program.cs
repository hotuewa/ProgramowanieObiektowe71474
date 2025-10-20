using MyApplication;
using System;


namespace MyApplication
{

 
    class Program
    {
         static void Main(string[] args)
        {
           
            Zwierze piesio = new Pies("Gruby");
            Zwierze kotek = new Kot("Mruczek");
            Zwierze wazik = new Waz("Długi");
            powiedzCos(kotek);
            powiedzCos(piesio);
            powiedzCos(wazik);

            Pracownik piekasz = new Piekarz();
            piekasz.Pracuj();

            //Pracownik murasz = new Pracownik();
            A obiektA = new A();
            B obiektB = new B();
            C obiektC = new C();

        }
        public static void powiedzCos(Zwierze z)
        {
            z.DajGlos();
            Console.WriteLine(z.GetType());
        }
    }

    class Zwierze
    {
        protected string nazwa;

        public Zwierze(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public virtual void DajGlos()
        {
            Console.WriteLine("Zwierze wydaje dźwięk.");
        }

    }

    class Pies : Zwierze
    {
        public Pies(string nazwa) : base(nazwa)
        {
        }
        public override void DajGlos()
        {
            Console.WriteLine($"{nazwa} mówi: Hau Hau!");
        }
    }

    class Kot : Zwierze
    {
        public Kot(string nazwa) : base(nazwa)
            { }
        public override void DajGlos()
        {
            Console.WriteLine($"{nazwa} mówi: Miau Miau!");
        }
    }
    class Waz : Zwierze
    {
        public Waz(string nazwa) : base(nazwa)
        { }
        public override void DajGlos()
        {
            Console.WriteLine($"{nazwa} mówi: ssssssssssssssssssssssssssssssssssssssss!");
        }
    }

    public abstract class  Pracownik
    {
        abstract public void Pracuj();

    }

    class Piekarz :Pracownik
    {
        public override void Pracuj()
        {
            Console.WriteLine("Trwa pieczenie... ");
        }
    }
    
    class A
    {
        public A()
        {
            Console.WriteLine("Konstruktor A");
        }

    }

    class B : A
    {
        public B() : base()
        {
            Console.WriteLine("Konstruktor B");
        }   
    }

    class C : B
    {
        public C() : base()
        {
            Console.WriteLine("Konstruktor C");
        }
    }

}
