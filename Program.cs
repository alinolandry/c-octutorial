using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Tp1 obj = new Tp1();
            obj.Run();
           
            
            /*
             *  Introduction in C# language
             * 
            ShowWelcome();
            Introduction();
            SayHello("Pulcherie", 23);

            //double sol = CalHypotenuse(5,3);
            Console.WriteLine("Le resultat est "+ CalHypotenuse(5, 3));
            Console.WriteLine("Utilisateur actuel: " + Environment.UserName + " Connecté le " + DateTime.Now);
            */
        }

        // Simple method to say hello
        static void SayHello(string name, int age)
        {
            Console.WriteLine("Bonjour " + name);
            Console.WriteLine("Vous avez " + age + " ans");
        }

        // Metod calcul something
        static double CalHypotenuse(double a, double b)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n Calcul la la longueur de l'hypothenuse d'un triangle de longueur " +a+ "et largeur "+b);
            double kSum = a * a + b * b;
            double resultat = Math.Sqrt(kSum);
            return resultat;
        }


        // simple method for introduction in C# language
        static void Introduction()
        {
            int val = 5;
            string nom = "Alain Nkouamen";
            if (val > 0)
            {
                Console.WriteLine("valeur superieur a zero " + nom);
            }
            else
            {
                Console.WriteLine("valeur inférieure à zero " + nom);
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine("je suis dans le C#");
        }

        // Anothere methode to show Welcome message
        static void ShowWelcome()
        {
            Console.WriteLine("Good Morning Sir");
            Console.WriteLine("-----------------" + Environment.NewLine);
            Console.WriteLine("\t Welcome in the C# World");
        }
    }
}
