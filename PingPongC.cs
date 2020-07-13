using System;

class PingPong
{
    static void Main()
    {
        List<int> pingPongList = new List<int>();

        Console.WriteLine("Enter a number!");
        string stringNumber = Console.ReadLine();
        int userNumber = int.Parse(stringNumber);

        for (int i = 0; i < pingPongList.length; i++)
        {
            if(i / 15 == 0)
            {
                pingPongList.Add("ping-pong");
            }
            else if(i / 3 == 0)
            {
                pingPongList.Add("ping");
            }
            else if(i / 5 == 0)
            {
                pingPongList.Add("pong");
            }
            else
            {
                pingPongList.Add(i);
            }
        }
    }
}