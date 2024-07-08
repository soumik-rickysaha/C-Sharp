class RepeatCounting
{
    public static void Main(string[] args)
    {
        bool direction = true;
        int totalprint = 1;

        while (totalprint<=5)
        {
            if (direction)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
                direction = false;
            }
            else
            {
                for (int i = 5; i >=1; i--)
                {
                    Console.WriteLine(i);
                }
                direction = true;
            }
            totalprint++;
        }

       
    }
}