
using System;
using System.Linq;

namespace DoubleLinkList
{
    public class MusicalChair
    {
        public static int[] uniqueValue(int input1, int[] input2)
        {
            var heightVise = new int[input1];
            var result = new int[input1];
            for (int i = 0; i < input1; ++i)
            {
                heightVise[i] = i + 1;
                result[i] = -1;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                var personleft = input2[i];
                var temp = heightVise[i];

                if (result[personleft] == -1)
                {
                    result[personleft] = heightVise[i];

                }
                else 
                {
                    FirsteligibalePosition(personleft, result, temp);
                }


            }
            return result;

        }


        //static void FirsteligibalePosition(int index, int[] result, int[] actual, int[] rank)
        //{
        //    var personleft = 0;
        //    var temp = -1;
        //    if (result[personleft] == -1)
        //    {
        //        result[personleft] = temp;
        //        temp = -1;
        //    }
        //    else if (result[personleft] > temp)
        //    {

        //        var temp1 = result[personleft];
        //        result[personleft] = temp;
        //        temp = temp1;

        //    }

        //    if (temp != -1)
        //    {
        //        personleft++;
        //        FirsteligibalePosition(personleft, result, temp);
        //    }
        //}

        static void FirsteligibalePosition(int personleft, int[] result, int temp)
        {
            if (result[personleft] == -1)
            {
                result[personleft] = temp;
                temp = -1;
            }
            else if (result[personleft] > temp)
            {
               
                var temp1 = result[personleft];
                result[personleft] = temp;
                temp = temp1;
                
            }
            
            if (temp != -1)
            {
                personleft++;
                FirsteligibalePosition(personleft, result, temp);
            }
        }
        static void Mainw()
        {
            foreach (var a in uniqueValue(4, new int[] { 2, 1, 1, 0 }))
            {
                Console.WriteLine("Result: {0}", a);
            }

            Console.Read();
        }

    }
}
