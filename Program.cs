// See https://aka.ms/new-console-template for more information
Menu();
//Start(6);

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Secconds ==> 10s = 10 secconds");
    Console.WriteLine("M = Minutes = 1m = 1 minute");
    Console.WriteLine("0 = Exit");
    Console.WriteLine();
    Console.WriteLine("How much time do you want to count?");

    try
    {

        string? data = Console.ReadLine();
        string dataToLower = String.Empty;

        if (String.IsNullOrEmpty(data))
        {
            Console.WriteLine("Sorry, I can't count the void yet... let's try again...");
            Thread.Sleep(2500);
            Menu();
        }
        else
        {
            dataToLower = data.ToString().ToLower();
        }

        char type = dataToLower.LastOrDefault();

        if (type != 'm' && type != 's')
        {
            Console.WriteLine("Sorry, I couldn't understand what kind of time do you want to count, let's try again..");
            Thread.Sleep(2500);
            Menu();
        }


        int time = int.Parse(dataToLower.Substring(0, dataToLower.Length - 1));

        if (char.Equals('m', type))
            time = time * 60;

        if (time == 0)
            Menu();

        PreStart(time);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Sorry, I couldn't understand what exactly how much time do you want to count, let's try again...");
        Thread.Sleep(2500);
        Menu();
    }





}

static void Start(int time)
{

    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finished!");
    Thread.Sleep(1000);
    Menu();

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);
}