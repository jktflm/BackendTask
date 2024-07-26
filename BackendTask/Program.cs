using BackendTask;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 4 || args[0] != "-n" || args[2] != "-f")
            {
                Console.WriteLine("Usage: ./activity -n <number_of_times> -f <json|csv|console>");
                return;
            }

            int numberOfTimes;
            if (!int.TryParse(args[1], out numberOfTimes))
            {
                Console.WriteLine("Invalid number of times specified.");
                return;
            }

            string format = args[3];
            if (format != "json" && format != "csv" && format != "console")
            {
                Console.WriteLine("Invalid format specified. Use 'json', 'csv', or 'console'.");
                return;
            }

            List<Activity> activities = new List<Activity>();

            for (int i = 0; i < numberOfTimes; i++)
            {
                Activity activity = await ActivityService.FetchActivity();
                if (activity != null)
                {
                    activities.Add(activity);
                }
            }

            switch (format)
            {
                case "json":
                    ActivitySaver.SaveAsJson(activities);
                    break;
                case "csv":
                    ActivitySaver.SaveAsCsv(activities);
                    break;
                case "console":
                    ActivitySaver.PrintToConsole(activities);
                    break;
            }
        }
    }
}
