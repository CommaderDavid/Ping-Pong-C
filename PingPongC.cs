using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Enter a number!");
        string stringNumber = Console.ReadLine();
        int userNumber = int.Parse(stringNumber);

        for (int i = 1; i <= userNumber; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("ping-pong");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("ping");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("pong");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}