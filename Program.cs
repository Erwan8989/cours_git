using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est ton prénom ?");
            string prenom = Console.ReadLine();

            Console.WriteLine("Ton prenom est : " + prenom);
            
            Console.WriteLine("Quel est ton age ?");
            string age = Console.ReadLine();

            Console.WriteLine("Tu as " + age + " ans");
        }
    }
}
