using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversionsY9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int denNum;
            int divider;
            Console.Write("Enter the number you want to convert: ");
            denNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number base you want to convert to: ");
            divider = Convert.ToInt32(Console.ReadLine());
            string binNum = "";
            while (denNum > 0)
            {
                binNum = (denNum % divider).ToString() + binNum;
                denNum = denNum / divider;
            }
            Console.WriteLine(binNum);

            string binNumToConvert;
            Console.Write("Enter Binary number: ");
            binNumToConvert = Console.ReadLine();
            int result = 0;
            int mult = 1;
            for(int i = binNumToConvert.Length - 1; i >= 0; i--)
            {
                int curVal = Convert.ToInt32(binNumToConvert[i]-48);
                result += mult * curVal;
              
                mult *= 2;
            }
            Console.WriteLine(result);
        }
    }
}
