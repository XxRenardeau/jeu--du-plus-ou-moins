public class GameInstance
{

    public GameInstance()
    {
        playgame();
    }

    public bool GameRun;
    public void playgame()
    {

        Console.WriteLine("**************************\n****** Jeu du + / - ******\n**************************");

        Console.WriteLine("Bienvenue dans le jeu du + ou - \n veuilliez choisir votre difficulté \n tappez 1 pour facile (entre 0 et 25) \n tappez 2 pour moyen (entre 0 et 100) \n tappez 3 pour difficile (entre 0 et 1000) \n tappez 4 pour impossible (entre 0 et 1million)");

        int difficulte = Convert.ToInt32(Console.ReadLine());

        Range ecart = ChoixDifficulte(difficulte);

        GameRun = true;
        while (GameRun)
        {
            bool gg = false;


            if (ecart.MinRange == -1)
            {
                Console.WriteLine("Cette difficulté n'existe pas");
                return;
            }
            else
            {
                int RandomChiffre = Randomiseur(ecart);


                Console.WriteLine("Le chiffre mystere est " + RandomChiffre);//frere c'est du debug si tu laisse cette ligne les gens ils vont facilement gagner 



                while (gg == false)
                {

                    foreach (int essai in Essais)
                    {


                        Console.WriteLine("Devine le nombre entre 0 et " + ecart.MaxRange + " vous avez " + essai + " essais");

                        int GuessChiffre = Convert.ToInt32(Console.ReadLine());

                        int resultat = RandomChiffre - GuessChiffre;
                        int zero = 0;
                        if (essai == 1)
                        {

                            Console.WriteLine("t'as perdu , lol");
                            return;
                        }
                        else if (resultat == zero)
                        {
                            Console.WriteLine("bien ouej chacal");
                            gg = true;
                            Console.WriteLine("Rejouer ? (1 ou 0)");
                            string restartInput = Console.ReadLine();
                            GameRun = Restart(restartInput);
                            if (GameRun == false) ;
                            {
                                break;
                            }

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

    //regarde le choix de la difficulté
    public Range ChoixDifficulte(int difficulte)
    {
        switch (difficulte)
        {
            case 1:
                return new Range(0, 25);
            case 2:
                return new Range(0, 100);
            case 3:
                return new Range(0, 1000);
            case 4:
                return new Range(0, 1000000);
            default: return new Range(-1, -1);

        }

    }
    //créé le chiffre aléatoire
    public int Randomiseur(Range Range)
    {
        Random rnd = new Random();
        return rnd.Next(Range.MinRange, Range.MaxRange);
    }


    public struct Range
    {
        public Range(int MinRange, int MaxRange)
        {
            this.MinRange = MinRange;
            this.MaxRange = MaxRange;
        }
        public int MinRange;
        public int MaxRange;
    }

    //Retourne si la saisie est valide
    public bool Restart(string InputValue)
    {

        if (InputValue == "1")
        {

            return true;
        }
        else if (InputValue == "0")
        {

            return false;


        }
        else
        {

            Console.WriteLine("Veulliez entrer une réponse valide");
            return false;
        }



    }

    public int[] Essais = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };




}