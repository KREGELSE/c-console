

Class Loops
{
    public static void ForLoops()
    {

        for(int i = 0; i<10; i++)
        {
            Console.WriteLine("Iteratoin: " + i);
        }
    }

    public static void EvenLoop()
    {


        for(int i = 0; i<20; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
    }

    public static void HealthLoop()
    {
        int health = 100;
        while(health > 0)
        {
            Console.WriteLine("Player is alive with health:" + health);
            Health = health - 10;
        }
    }
}