using System;
using System.Collections;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = System.IO.File.ReadAllText("input.txt");
            String[] input = inputString.Split("\n");
            ArrayList frequencies = new ArrayList();
            double frequency =-2;
            frequencies.Add(Convert.ToDouble(input[0]));
            foreach (var item in input)
            {
                if(item != "")
                frequency += Convert.ToDouble(item);
                for (int i = 0; i < frequencies.Count; i++)
                {
                    double item2 = (double)frequencies[i];
                    if (item2 != frequency){
                        frequencies.Add(frequency);
                    }
                    else{
                        
                        Console.WriteLine("The double number is: "+frequency);
                        break;
                    }
                }
            }
            Console.WriteLine("the answer is: "+frequency);
        }
    }
}
