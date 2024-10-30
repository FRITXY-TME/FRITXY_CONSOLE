class Program
{
    static void Main()
    {
        Console.Title = "FRITXY CONSOLE";
        Console.WriteLine(@"
    ______ ____   ____ ______ _  ____  __   ______ ____   _   __ _____  ____   __     ______
   / ____// __ \ /  _//_  __/| |/ /\ \/ /  / ____// __ \ / | / // ___/ / __ \ / /    / ____/
  / /_   / /_/ / / /   / /   |   /  \  /  / /    / / / //  |/ / \__ \ / / / // /    / __/   
 / __/  / _, _/_/ /   / /   /   |   / /  / /___ / /_/ // /|  / ___/ // /_/ // /___ / /___   
/_/    /_/ |_|/___/  /_/   /_/|_|  /_/   \____/ \____//_/ |_/ /____/ \____//_____//_____/");

        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine("Please Wait While The FRITXY Console Checks If Your PC Can Run The FRITXY Console!");
        Thread.Sleep(5000);
        Console.WriteLine("Your PC Can Run It! Wait 2 Seconds Now Please");
        Thread.Sleep(2000);
        Console.WriteLine("Starting FRITXY Console Now...");
        Thread.Sleep(3000);
        Console.WriteLine("This May Take A While...");
        Thread.Sleep(4000);
        Console.WriteLine("Choose What You Would Like To Do In The FRITXY Console");
        Thread.Sleep(200);
        while (true)
        {
            Console.WriteLine("[1] Spam Hello");
            Console.WriteLine("[2] Hello Goofy");
            Console.WriteLine("[3] Notepad");
            Console.WriteLine("[4] Hello Hevy");
            Console.WriteLine("[5] Close The Launcher");
            Console.Write("[?] Please Choose A Number From The Above: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": SpamHello(); break;
                case "2": HelloGoofy(); break;
                case "3": Notes(); break;
                case "4": HelloHevy(); break;
                case "5": CloseFRITXY(); break;
                default:
                Console.WriteLine("The FRITXY Console Does NOT Have This Option At The Moment Sorry."); break;
            }
        }
    }
    public static void HelloGoofy()
    {
        while (true)
        {
            Console.WriteLine("HELLO GOOFY!");
        }    
    }
    public static void HelloHevy()
    {
        while (true)
        {
            Console.WriteLine("HELLO HEVY!");
        }
    }
    public static void SpamHello()
    {
        while (true)
        {
            Console.WriteLine("Hello");
        }
    }
    public static void CloseFRITXY()
    {
        Console.WriteLine("Closing FRITXY Console...");
        Environment.Exit(0);
    }

    public static void Notes()
    {
        Console.WriteLine("You Are Now In NOTEPAD Mode If You Press Enter It Will Reopen The Options Tab! Have Fun");
        Console.ReadKey();
        Console.ReadLine();
    }
}
