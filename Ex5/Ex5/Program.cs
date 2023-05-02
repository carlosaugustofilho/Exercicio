using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            string reversedString = ReverseString(input);

            Console.WriteLine("String invertida: " + reversedString);
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length / 2; i++)
            {
                // Troca direta dos caracteres sem variável temporária
                (charArray[i], charArray[length - i - 1]) = (charArray[length - i - 1], charArray[i]);
            }

            return new string(charArray);
        }

    }
}   

