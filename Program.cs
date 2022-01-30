using System;

namespace nombre_magique // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DeamnderNombre(int min, int max)
        {
            int nombre = max + 1;

            while ((nombre < min) || (nombre > max))
            {
                Console.Write($"Veuillez rentrer un nombre entre {min} et {max} : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombre = int.Parse(reponse);

                    if ((nombre < min) || (nombre > max))
                    {
                        Console.WriteLine($"Erreur : le nombre doit etre entre {min} et {max}");
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur : veuillez rentrer un chiffre valide !");
                }
            }

            return nombre;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            const int MIN = 0;
            const int MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(MIN, MAX + 1);

            int nombre = NOMBRE_MAGIQUE + 1;

            //int nbVies = 4;

            for (int nbVies = 4; nbVies > 0; nbVies--)
            {
                Console.WriteLine();
                Console.WriteLine($"Vous avez {nbVies} vies");
                nombre = DeamnderNombre(MIN, MAX);

                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand !");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit !");
                }
                else
                {
                    // J'ai trouvé le nombre magique
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
            }

            if (nombre != NOMBRE_MAGIQUE)
            {
                Console.WriteLine($"Vous avez perdu, le nombre magique était {NOMBRE_MAGIQUE}");
            }

            Console.WriteLine($"Vore nombre est {nombre}");

        }
    }
}