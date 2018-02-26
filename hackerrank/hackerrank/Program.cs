using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

internal class Solution
{
    private static string visited = string.Empty;
    private static void Main(String[] args)
    {
        var s = Console.ReadLine().Split(' ');
        var row = Convert.ToInt32(s[0]);
        var col = Convert.ToInt32(s[1]);
        char[,] metrics = new char[row, col];
        var file = File.OpenText(@"c:\see.txt");
        for (int i = 0; i < row; ++i)
        {
            var z = file.ReadLine().ToCharArray();// Console.ReadLine().ToCharArray();
            for (int j = 0; j < col; ++j)
            {
                metrics[i, j] = Convert.ToChar(z[j]);
            }
        }

        var resList = new List<int>();
        for (int i = 1; i < row - 1; ++i)
        {

            for (int j = 1; j < col - 1; ++j)
            {
                resList.Add(Math.Max(CalculateDepth(i, j, metrics, row, col), 1));

            }
        }
        resList = resList.OrderByDescending(x => x).ToList();
        if (resList.Any())
        {
            if (resList.Count() > 2)
            {
                Console.Write(resList[0] * resList[1]);
            }
            else
            {
                Console.Write(resList[0] * 1);
            }
        }
        Console.ReadLine();
    }

    private static int CalculateDepth(int i, int j, char[,] metrics, int row, int col)
    {
        int maxdepth = int.MinValue;
        StringBuilder sb=new StringBuilder();
        if (metrics[i, j] == 'G')
        {
            maxdepth = 1;
            var uppar = i + 1;
            var lower = i - 1;
            var left = j - 1;
            var right = j + 1;
            //if (metrics[uppar, j] == metrics[lower, j] && metrics[i, right] == metrics[i, left] &&
            //            metrics[lower, j] == metrics[i, right] && metrics[i, right] == 'G')
            //{


                do
                {
                    
                    if (uppar >= row || lower < 0 || right >= col || left < 0)
                    {
                        sb.AppendFormat("{0}{1}#", i, j);
                        break;
                        ;
                    }
                    if (metrics[uppar, j] == metrics[lower, j] && metrics[i, right] == metrics[i, left] &&
                        metrics[lower, j] == metrics[i, right] && metrics[i, right] == 'G')
                    {
                        maxdepth += 4;
                        //metrics[uppar, j] =metrics[i, j]=
                        //    metrics[lower, j] =
                        //        metrics[i, right] =
                        //            metrics[i, left] = metrics[lower, j] = metrics[i, right] = metrics[i, right] = 'V';

                    }
                    else
                    {
                        sb.AppendFormat("{0}{1}#", i, j);
                        break;
                    }
                    uppar++;
                    right++;
                    lower--;
                    left--;
                } while (true);

            //}

        }

        return maxdepth;

    }

}