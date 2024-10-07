using System.Net.Http;
using System.Text;

namespace AiChat.Models
{
    public class Service1
    {
        public async Task<string> SendMessageAsync(string prompt)
        {
            string url = "aHR0cHM6Ly9hcGkuYmluamllLmZ1bi9hcGkvZ2VuZXJhdGVTdHJlYW0=";
            byte[] bytes = Convert.FromBase64String(url);
            url= Encoding.UTF8.GetString(bytes);
            string origin = "aHR0cHM6Ly9jaGF0MTguYWljaGF0b3M4LmNvbS8=";
            bytes = Convert.FromBase64String(origin);
            origin = Encoding.UTF8.GetString(bytes);
            var payload = new
            {
                prompt = prompt,
                userId = "#/chat/1728289918795",
                network = true,
                system = "",
                withoutContext = false,
                stream = false
            };

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    var jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);
                    request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    request.Headers.Accept.ParseAdd("application/json, text/plain, */*");
                    request.Headers.AcceptEncoding.ParseAdd("gzip, deflate, br, zstd");
                    request.Headers.AcceptLanguage.ParseAdd("tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                    request.Headers.Add("Origin", origin);
                    request.Headers.Referrer = new Uri(origin);
                    request.Headers.Add("Sec-CH-UA", "\"Not)A;Brand\";v=\"99\", \"Google Chrome\";v=\"127\", \"Chromium\";v=\"127\"");
                    request.Headers.Add("Sec-CH-UA-Mobile", "?0");
                    request.Headers.Add("Sec-CH-UA-Platform", "\"Windows\"");
                    request.Headers.Add("Sec-Fetch-Dest", "empty");
                    request.Headers.Add("Sec-Fetch-Mode", "cors");
                    request.Headers.Add("Sec-Fetch-Site", "cross-site");
                    request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36");

                    var response = await httpClient.SendAsync(request);

                    if (!response.IsSuccessStatusCode)
                    {
                        return $"Hata: {response.StatusCode} - Sistemde bir hata oluştu.";
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    return responseContent;
                }

            }

        }
    }
}
