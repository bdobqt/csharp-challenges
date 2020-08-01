using System;

namespace challenges
{
    class Reverseandnotreverse
    {


        public static void Reverse(string userIn)
        {
            
            char[] charArray = userIn.ToCharArray();
            Array.Reverse(charArray);
            string rString = new String(charArray);
            Console.WriteLine(rString);
            Console.WriteLine(String.Concat(userIn,rString));
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Type and integer : ");
            string userIn = Console.ReadLine();            
            Reverse(userIn);

        }
    }
}
