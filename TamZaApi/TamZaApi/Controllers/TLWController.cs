using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TamZaApi.Controllers
{
    public class TLWController : ApiController
    {
        public string Get()
        {
            return "Tod Tod Tod Puad Tod";
        }
        public async Task<string> Post([FromBody]LineResponse result)
        {
            await Task.Delay(20);
            if (result!=null)
            {
                if (result.events!=null)
                {
                    return result.events[0].type;
                }
            }
            return "Mai Puad Tod";
        }
    }
    public class LineResponse
    {
        public List<Events> events { get; set; }
    }

    public class Events
    {
        public string replyToken { get; set; }
        public string type { get; set; }
        //public string type { get; set; }

        //public string type { get; set; }
        //public string type { get; set; }
       // public string postback { get; set; }
      
      
    }
    public class Source
    {
        public string type { get; set; }
        public string userId { get; set; }
        public string groupId    { get; set; }
        public string roomId { get; set; }
    }
    public class Message
    {
        public string id { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string fileName { get; set; }
        public string fileSize { get; set; }
        public string address { get; set; }
        public string title { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string stickerId { get; set; }
        public string packageId { get; set; }

    }

}
