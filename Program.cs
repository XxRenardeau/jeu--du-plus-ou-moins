using System;

namespace PremierTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************\n****** Jeu du + / - ******\n**************************");

            {
                bool gg = false;
                int RandomChiffre;
                int nmbdiff;
                nmbdiff=0;
                Console.WriteLine("Bienvenue dans le jeu du + ou - \n veuilliez choisir votre difficulté \n tappez 1 pour facile (entre 0 et 25) \n tappez 2 pour moyen (entre 0 et 100) \n tappez 3 pour difficile (entre 0 et 1000) \n tappez 4 pour impossible (entre 0 et 1million)");
                int difficulte = Convert.ToInt32(Console.ReadLine());
                if (difficulte==1)
                {
                    nmbdiff=25;
                }
                else
                {
                    if (difficulte==2)
                    {
                        nmbdiff=100;
                    }
                    else
                    {
                        if (difficulte==3)
                        {
                            nmbdiff=1000;
                        }
                        else
                        {
                            if (difficulte==4)
                            {
                                nmbdiff=1000000;
                            }
                            else
                            {
                                Console.WriteLine("Cette difficulté n'existe pas");
                            }
                        }
                    }
                }

                Random rnd = new Random();
                if (nmbdiff==0)
                {
                 return;
                }
                else
                {
                    RandomChiffre = rnd.Next(0, nmbdiff);
                while (gg == false)
                {
                    //Console.WriteLine("Le chiffre mystere est " + RandomChiffre);//frere c'est du debug si tu laisse cette ligne les gens ils vont facilement gagner 

                    Console.WriteLine("Devine le nombre (entre 0 et 25)");

                    int GuessChiffre = Convert.ToInt32(Console.ReadLine());

                    int resultat = RandomChiffre - GuessChiffre;
                    int zero = 0;

                    if (resultat == zero)
                    {
                        Console.WriteLine("bien ouej chacal");
                        gg = true;
                    }
                    else
                    {
                        if (resultat > zero) { Console.WriteLine("c'est plus"); }
                        else { Console.WriteLine("c'est moins"); }

                    }

                }
                }
                




            }


        }



    }

}