using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace jankenpon
{
    public class Joueur
    {

        public void Start()
        {
            Console.WriteLine("Bienvenue N'oublie pas les règles:");
            Console.WriteLine("Le Ciseau gagne contre Feuille:");
            Console.WriteLine("La Pierre gagne contre Ciseau:");
            Console.WriteLine("La Feuille gagne contre Pierre:");
            int scoreIa = 0;
            int scorePlayer = 0;
            int scoreDraw = 0;

            for (int NumberRound = 1; NumberRound <= 10; NumberRound++)
            {
                Console.WriteLine("");
                Console.WriteLine("Choise ton Signe: Ciseau 1,Pierre: 2 ,Feuille: 3");
                var pickPlayer = Console.ReadLine();
                IaOrdi pickIa = new IaOrdi();
                pickIa.IaPick();
                
                Console.WriteLine("");
                Console.WriteLine("Round " + NumberRound);

                if (pickPlayer == "1")
                {
                    Console.WriteLine("Tu a choisi Ciseau");
                    Console.WriteLine("Le bot a choisi " + pickIa.Display());
                    if (pickIa.Number == 1)
                    {
                        Console.WriteLine("Draw");
                        scoreDraw ++;
                    }
                    if (pickIa.Number == 2)
                    {
                        Console.WriteLine("Losse");
                        scoreIa ++;
                    }
                    if (pickIa.Number == 3)
                    {
                        Console.WriteLine("Win");
                        scorePlayer ++;


                    }
                }
                if (pickPlayer == "2")
                {
                    Console.WriteLine("Tu a choisi Pierre");
                    Console.WriteLine("Le bot a choisi " + pickIa.Display());
                    if (pickIa.Number == 1)
                    {
                        Console.WriteLine("Win");
                        scorePlayer++;
                    }
                    if (pickIa.Number == 2)
                    {
                        Console.WriteLine("Draw");
                        scoreDraw++;
                    }
                    if (pickIa.Number == 3)
                    {
                        Console.WriteLine("Losse");
                        scoreIa ++;
                    }
                }
                if (pickPlayer == "3")
                {
                    Console.WriteLine("Tu a choisi Feuille");
                    Console.WriteLine("Le bot a choisi " + pickIa.Display());
                    if (pickIa.Number == 1)
                    {
                        Console.WriteLine("Win");
                        scorePlayer++;
                    }
                    if (pickIa.Number == 2)
                    {
                        Console.WriteLine("Loose");
                        scoreIa ++;
                    }
                    if (pickIa.Number == 3)
                    {
                        Console.WriteLine("Draw");
                        scoreDraw++;
                    }
                }
            }
            Console.WriteLine("Le Round 10 viens de ce finir ton score est de " + scorePlayer +" le score de l'ordinateur est de "+ scoreIa);
            Console.WriteLine("Le nombre de round Draw est de " + scoreDraw);
            if (scorePlayer > scoreIa) 
            {
                Console.WriteLine("Le Joueur gagne la partie");
            }
            if (scorePlayer < scoreIa) 
            {
                Console.WriteLine("L'ordinateur gagne la partie");
            }
            if (scorePlayer == scoreIa) 
            {
                Console.WriteLine("Improbable mais vrais égalité");
            }
        }

    }
}