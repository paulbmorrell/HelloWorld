using System;

public class Program
{
    private static void Main(string[] args)
    {

        // setup game info
        int round = 1;
        int alienHealth = 5;
        int cityHealth = 25;

        // into - setup computer player
        Console.WriteLine("An Alien ship is coming to attack your city!\nIt has taken up a numerical position from 1 to 99.\nYour job is to guess it's location and shoot it down!");

        int alienRange = Random();


        // start game
        while (cityHealth > 0 && alienHealth > 0)
        {
            // output game status
            Console.WriteLine("------------------------------------------------------------\n" +
                   $"Status: Round {round}  City: {cityHealth}/25  Alien Ship: {alienHealth}/5\n" +
                   $"Your cannon is expected to deal {cannonDamage(round)} damage this round\n" +
                   "Enter desired cannon range:");

            // player 2
            int cannonRange = rangeValidate();

            Console.Clear();
            
            if (cannonRange < alienRange)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("That round FELL SHORT of the target.");
                Console.ForegroundColor = ConsoleColor.White;
                cityHealth--;
                round++;
            }
            else if (cannonRange > alienRange)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That round OVERSHOT the target.");
                Console.ForegroundColor = ConsoleColor.White;
                cityHealth--;
                round++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DIRECT HIT!");
                alienHealth = alienHealth - cannonDamage(round);
                alienRange = Random();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING: The alien ship has moved to a new position!");
                Console.ForegroundColor = ConsoleColor.White;
                round++;
            }

        }

        bool won = cityHealth > 0;
        WinOrLose(won);

        /*----------------------methods----------------------*/

        // game outcome
        void WinOrLose(bool won)
        {
            if (won)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The alien ship was destroyed.\nYou saved the city!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The city has been destroyed.\nThe alien ship was hidden at position: {alienRange}\nGAME OVER");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        // cannon damage calculator
        int cannonDamage(int round)
        {
            if (round % 3 == 0 && round % 5 == 0) // if round is a multiple of 3 and 5
            {
                int damage = 5;
                return damage;
            }
            else if(round % 3 == 0 || round % 5 == 0) // if round is a multple of 3 or 5
            {
                int damage = 4;
                return damage;
            }
            else
            {
                if (round > 20)
                {
                    int damage = 4;
                    return damage;
                }
                else
                {
                    int damage = 1;
                    return damage;
                }
            }
        }


        // range validator
        int rangeValidate()
        {

            var cannonRange = Convert.ToInt32(Console.ReadLine());

            if (cannonRange < 1 || cannonRange > 99)
            {
                Console.WriteLine("Range must be > 0 and < 100");
                return rangeValidate();
            }
            else
            {
                return cannonRange;
            }

        }


        // random range
        int Random()
        {
            Random rnd = new Random();

            return rnd.Next(1, 99);
        }

    }
}