using System;
using System.Security.Cryptography;

namespace SampleStack
{
    class SampleStack
    {
        public static void Main(String[] args)
        {
            int player1= 0, player2 =0;
            int rndNum;
            string winner;
            Random rnd = new Random();

            

            Console.WriteLine("DICE GAME::First person to 20 wins the games \n");


            do
            {
                do
                {
                    Console.WriteLine("Rolling dice for the first player");
                    rndNum = rnd.Next(1, 7);
                    player1 += rndNum;
                    Console.WriteLine("The dice rolled to {0} \n", rndNum);
                    Console.ReadKey();
                } while (rndNum == 6 || rndNum == 1);

                do
                {
                    Console.WriteLine("Rolling dice for the second player");
                    rndNum = rnd.Next(1, 7);
                    player2 += rndNum;
                    Console.WriteLine("The dice rolled to {0}\n", rndNum);
                    Console.ReadKey();
                } while (rndNum == 6 || rndNum ==1);

                Console.WriteLine("=================================================");
                Console.WriteLine($"The score is PLAYER1 : {player1} and PLAYER2 : {player2} \n");
                Console.WriteLine("=================================================");
                Console.ReadKey();
                


            } while(player1 < 20 && player2 < 20);

            if(player1 > player2 )
            {
                Console.WriteLine("The Winner is Player 1");
            }else if(player1 < player2)
            {
                Console.WriteLine("The Winner is Player 2!!!");
            }
            else
            {
                Console.WriteLine("Draw!!!");
            }

            


        }
    }
}