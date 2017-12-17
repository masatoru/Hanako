using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanako.Models
{
    public class HKHttpUtil
    {
        public static async Task<string> getXmlTextAsync(string baseUrl, string subUrl)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(subUrl);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}