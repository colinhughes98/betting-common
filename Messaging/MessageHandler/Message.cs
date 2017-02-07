using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.MessageHandler
{
    public class Message
    {
        public static string GetRequest(string URL)
        {
            string responseDoc;
            //read URL
            var request = (HttpWebRequest)WebRequest.Create(URL);
            var response = request.GetResponse();

            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                responseDoc = stream.ReadToEnd();
            }
            return responseDoc;
        }
    }
}
