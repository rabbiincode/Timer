using System.Timers;

public class Example
{
    private static System.Timers.Timer timer;
    
    public static void Main()
    {
        Console.WriteLine("Timer Application");
        Console.WriteLine("Ready to work?? set your timer for now");

        int workTime;
        int restTime;

        Console.Write("Enter work Time in minutes : ");
        workTime = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter rest Time in minutes : ");
        restTime = Convert.ToInt32(Console.ReadLine());

        WorkTime(workTime);
        Console.ReadLine();
        //timer.Stop();
        //timer.Dispose();
        //Console.WriteLine("Terminating the application...");


        static void WorkTime(int workTime)
        {
            //convert to miliseconds
            timer = new System.Timers.Timer(workTime * 60000);
            Console.WriteLine("Work time starts {0:HH:mm:ss.fff} and will last for {1} minutes", DateTime.Now, workTime);
            
            // Hook up the Elapsed event for the work timer. 
            timer.Elapsed += OnTimedEventWork;
            timer.AutoReset = false;
            timer.Enabled = true;
        }

        static void RestTime(int restTime)
        {
            //convert to miliseconds
            timer = new System.Timers.Timer(restTime * 60000);
            Console.WriteLine("Rest time starts {0:HH:mm:ss.fff} and will last for {1} minutes", DateTime.Now, restTime);

            // Hook up the Elapsed event for the rest timer. 
            timer.Elapsed += OnTimedEventRest;
            timer.AutoReset = false;
            timer.Enabled = true;
        }

        static void OnTimedEventWork(Object source, ElapsedEventArgs e)
        {
            Console.Write("");
        }

        static void OnTimedEventRest(Object source, ElapsedEventArgs e)
        {
            Console.Write("");
        }

        WorkTime(workTime);
        RestTime(restTime);
        timer.Stop();
        timer.Dispose();
    }
}