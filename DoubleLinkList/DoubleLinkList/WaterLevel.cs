
using System;

namespace DoubleLinkList
{
    class WaterLevel
    {
        public static int GetWaterLevel(int input1, int input2, int[] input3)
        {
            if (input1 < 1 || input2 < 1 || input3 == null || input3.Length < 1)
            {
                return -1;
            }
            var blockPosition = new int[input1, input2];
            for (int i = 0; i < input1; i++)
            {
                for (int j = 0; j < input2; j++)
                {
                    blockPosition[i, j] = input3[i*input1 + j];
                }
            }
            var volume = 0;
            for (int i = 1; i <= input1-2; i++)
            {
                for (int j = 1; j < input2-1; j++)
                {
                    var temp = blockPosition[i, j];
                    for (int k = j+1; k < input2; k++)
                    {
                        if (blockPosition[i, k] >= temp || temp < blockPosition[i, k - 2] || temp < blockPosition[i - 1, k - 1] || temp < blockPosition[i + 1, k - 1])
                        {
                            break;
                        }
                        else
                        {
                            volume += Math.Min(temp - blockPosition[i , k -2],
                                Math.Min(temp - blockPosition[i - 1, k - 1],
                                    Math.Min(temp - blockPosition[i + 1, k - 1], temp - blockPosition[i , k])));
                        }
                    }
                }
            }
            return volume;
        }

        static void Main()
        {
            Console.WriteLine("Result: {0}", GetWaterLevel(3,6, new []{3,3,4,4,4,2,3,1,3,2,1,4,7,3,1,6,4,1}));

            Console.Read();
        }


    }
}
