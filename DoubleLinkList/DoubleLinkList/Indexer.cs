using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    public class Player
    {
        public  int JerseyNumber { get; private set; }
        public int PosessionCount { get; set; }

        public Player(int jersey)
        {
            JerseyNumber = jersey;
            PosessionCount = 0;
        }
    }

    public class CandidateCode1
    {
        static Player[] Players;
        public static int passCount(int input1, int input2, int input3)
        {
            Players = Initialize(input1);
            Players[0].PosessionCount = 1;
            var player = Players[0];
            int counter = 0;
            while (player.PosessionCount!=input2)
            {
                var index = 0;
                if (player.PosessionCount%2 != 0)
                {
                    //cirular behaviour 
                     index = player.JerseyNumber - input3;
                    if (index < 1)
                    {
                      index=  input1 + player.JerseyNumber - input3;
                    }

                }
                else
                {
                    index = player.JerseyNumber + input3;
                    if (index > input1)
                    {
                        index = player.JerseyNumber + input3 - input1;
                    }
                }

                Players[index-1].PosessionCount++;
                player = Players[index-1];
                counter++;
            }
            return counter;
        }

        private static Player[] Initialize(int input1)
        {
             var x=new Player[input1];
            for (int i = 0; i < input1; ++i)
            {
                x[i]=new Player(i+1);
            }
            return x;
        }



        static void Main11()
        {
            Console.WriteLine("Result: {0}", passCount(5, 3, 2));
            Console.Read();
        }
    }
}
