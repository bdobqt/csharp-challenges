using System;

class SimplifiedFractions
{
    public SimplifiedFractions()
    {
        Console.WriteLine("Type a fraction a/b");
        string fraction = Console.ReadLine();
        string[] separatingStrings = { "/" };
        string[] fractionnum = fraction.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
        //System.Console.WriteLine($"{fractionnum.Length} substrings in text:");
        uint ua = Convert.ToUInt32(fractionnum[0]);
        uint ub = Convert.ToUInt32(fractionnum[1]);
        uint test = GCD(ua, ub);
        Console.WriteLine(test);
        if (test == 1)
        {
            Console.WriteLine("Simplified Version is : " + fraction);

        }
        else if (test == Convert.ToUInt32(fractionnum[1]))
        {
            uint newresult = ua / ub ;
            Console.WriteLine("Simplified Version is : " + newresult);

        }
        else
        {
            uint newa = ua / test;
            uint newb = ub / test;
            Console.WriteLine("Simplified Version is : " + newa +"/" + newb);
        }




    }

    private static uint GCD(uint a, uint b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        //Console.WriteLine(a);
        //Console.WriteLine(a);


        return a | b;
    }
}



