using System;

namespace RightSize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;


                }

            }
        }
    }
}