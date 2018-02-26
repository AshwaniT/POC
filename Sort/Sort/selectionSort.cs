using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
   public class selectionSort
    {
       int[] Sort(int[] array)
       {
           for (int i = 0; i < array.Length - 1; ++i)
           {
               //get min value 
               var minIndex=i;
               for(int j=i;j<array.Length;++j)
               {
                   if (array[j] < array[minIndex])
                       minIndex = j;

               }
               var temp = array[i];
               array[i] = array[minIndex];
               array[minIndex] = temp;

           }

           return array;
       }
    }
}
