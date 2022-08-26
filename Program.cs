using System;

namespace PremierTest
{

    class Program
    {

        static void Main(string[] args)
        {
            GameInstance instance = CreateNewGame();
            
        }


        static GameInstance CreateNewGame()
        {
            GameInstance instance = new GameInstance();
            return instance;


        }
    }
}
