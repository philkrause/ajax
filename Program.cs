using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TweetSharp;

// Pass your credentials to the service
namespace ajax
{
  class Program
  {
    static void Main(string[] args)
    {
      var service = new TwitterService("EeLGNkkIdj2dpNzDKjnFy1nDu", "nUd2E1YqjyQXsWABthjZYd4gNJIXRMakFaS2q9f2ElBokXuDNJ");
      service.AuthenticateWith("3180045288-mHoT4gpwBKHSBbZ4mcvZgb108Vze6xz6yyUV58v", "HpThtEwYysmlIp1aV19wPycWg4ZEebxIQd9VZE7dljGN1");
      TwitterStatus result = service.SendTweet(new SendTweetOptions
      {
        Status = "Hello, world!"
      });

    }
  }
}


//   using (HttpClient client = new HttpClient())
//       {
//         using (HttpResponseMessage response = await client.GetAsync(url))
//         {
//           using (HttpContent content = response.Content)
//           {
//             string mycontent = await content.ReadAsStringAsync();
//             Console.WriteLine(mycontent);
//           }
//         }
//       }

