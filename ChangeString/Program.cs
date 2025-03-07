using System;

namespace ChangeString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine(); 
            Console.Write("Caráter: ");
            char character = Console.ReadLine()[0];
            string final = ("");
            Console.Write ("Será impresso: ");
            
            foreach (char c in s)
            {
                    if (c == character)
                {
                    final += "x";
                }
                    else
                {
                   final += c;
                }
            }

            Console.WriteLine(final);
        }
    }
}
