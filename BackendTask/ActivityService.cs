using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackendTask
{
    public static class ActivityService
    {
        public static async Task<Activity> FetchActivity()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://bored-api.appbrewery.com/random");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Activity>(json);
                }
            }
            return null;
        }
    }
}
