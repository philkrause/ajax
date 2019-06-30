using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ajax
{
  class Program
  {
    static void Main(string[] args)
    {
      using (HttpClient client = new HttpClient())
      {
        using (HttpResponseMessage response = await client.GetAsynch(url))
        {
          using (HttpContent content = response.Content)
          {
            string mycontent = await content.ReadAsStringAsync();
            Console.WriteLine(mycontent);
          }
        }
      }
    }
  }
}


