using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using TeamsCardSender.Models;

var root = new Root()
{
    Type = "message",
    Attachments = new List<Attachment>()
                {
                    new Attachment()
                    {
                        ContentType = "application/vnd.microsoft.card.adaptive",
                        Content = new Content()
                        {
                            Schema = "http://adaptivecards.io/schemas/adaptive-card.json",
                            Type = "AdaptiveCard",
                            Version = "1.2",
                            Body = new List<Body>()
                            {
                                new Body()
                                {
                                    Type = "Message",
                                    Text =  "Hello there..."
                                }
                            }
                        }
                    }
                }
};

var stringContent = new StringContent(JsonConvert.SerializeObject(root), Encoding.UTF8, "application/json");

var url = "CONNECTOR_STRING";

using HttpClient httpclient = new();

httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

var response = await httpclient.PostAsync(url, stringContent);

Console.WriteLine(response.Content.ReadAsStringAsync().Result);