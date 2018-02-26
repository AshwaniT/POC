using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    

    public class CandidateCode
    {
        static Dictionary<int,int> Players;
        public static int passCount(int input1, int input2, int input3)
        {
            if (input1 < 3 || input1 > 1000)
            {
                return -1;
            }
            if (input2 < 3 || input2 > 1000)
            {
                return -1;
            }
            Players = Initialize(input1);
            Players[0] = 1;
            var player = Players[0];
            var jersy = 1;
            int counter = 0;
            while (player!= input2)
            {
                var index = 0;
                if (player % 2 != 0)
                {
                    //cirular behaviour 
                    index = jersy - input3;
                    if (index < 1)
                    {
                        index = input1 + jersy - input3;
                    }

                }
                else
                {
                    index = jersy + input3;
                    if (index > input1)
                    {
                        index = jersy + input3 - input1;
                    }
                }

                Players[index - 1]++;
                jersy = index;
                player = Players[index - 1];
                counter++;
            }
            return counter;
        }

        private static Dictionary<int, int> Initialize(int input1)
        {
            var x = new Dictionary<int, int>(input1);
            for (int i = 0; i < input1; ++i)
            {
                x.Add(i+1,0);
            }
            return x;
        }



        static void Main1()
        {
            Console.WriteLine("Result: {0}", passCount(5, 3, 2));
            Console.Read();
        }
    }
}
