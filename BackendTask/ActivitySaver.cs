using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace BackendTask
{
    public static class ActivitySaver
    {
        public static void SaveAsJson(List<Activity> activities)
        {
            string json = JsonConvert.SerializeObject(activities, Formatting.Indented);
            File.WriteAllText("activities.json", json);
            Console.WriteLine("Data saved as activities.json");
        }

        public static void SaveAsCsv(List<Activity> activities)
        {
            using (var writer = new StreamWriter("activities.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(activities);
            }
            Console.WriteLine("Data saved as activities.csv");
        }

        public static void PrintToConsole(List<Activity> activities)
        {
            foreach (var activity in activities)
            {
                Console.WriteLine($"Activity: {activity.ActivityType}, Type: {activity.Type}, Participants: {activity.Participants}");
            }
        }
    }
}
