using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IMDBApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IMDBApi.HelperClass
{

    public class HTMLParser
    {


        public string GetMovie(string url)
        {
            WebRequest req = HttpWebRequest.Create(url);
            WebResponse res = req.GetResponse();
            StreamReader data = new StreamReader(res.GetResponseStream());
            string content = data.ReadToEnd();
            int start = content.IndexOf("<script type=\"application/ld+json\">");
            int end = content.IndexOf("\"uploadDate");
            string htmlResult = content.Substring(start, end - start).Trim();
            htmlResult = htmlResult.Substring(0, htmlResult.Length - 1) + "}}";
            htmlResult = htmlResult.Replace("<script type=\"application/ld+json\">", "");

            return htmlResult;
        }


    }
}
