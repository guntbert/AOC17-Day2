using System;
using System.IO;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
                var lines = new List<string[]>();
                int Row = 0;
            string filepath = "/home/re/develop/AdventOfCode-2017/Day2/data.csv";
            using (StreamReader sr = System.IO.File.OpenText(filepath))
            {
                while (!sr.EndOfStream)
                {
                    string[] Line = sr.ReadLine().Split(',');
                    lines.Add(Line);
                    Row++;
                    //Console.WriteLine(Row);
                }
            }
            int colCount=lines[0].Length;
            int lineCount=lines.Count;
            var data = lines.ToArray();
            int[,] numdata = new int[lineCount,colCount];
            for (int line=0;line<lineCount;++line)
            {
                for(int col=0;col<colCount;++col)
{
    numdata[line,col]=int.Parse(data[line][col]);
}
            }
int sum=0;
            for (int line = 0; line < lineCount; line++)
            {
          sum += getLineValue(data[line]);      
            }
            Console.WriteLine($"Ergebnis Day2/part2: {sum}");
        }

        static int getLineValue(string[] line)
        {
            int count=line.Length;
            int[]numvalues=new int[count];
            for (int i=0;i<count;++i)
            {
                numvalues[i]=int.Parse(line[i]);
            }
            for (int i = 0; i < count; i++)
            {
             for (int j = 0; j < count; j++)
             {
                 if (i!=j)
                 {
                     if (numvalues[i]%numvalues[j]==0)
                     {
                         return numvalues[i]/numvalues[j];
                     }
                 }
             }   
            }
            throw new ArithmeticException("this should never be reached!");
        }
    }
}
