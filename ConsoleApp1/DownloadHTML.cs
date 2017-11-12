using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DownloadHTML
    {
        string http;
        public string getHttp()
        {
            return http;
        }
        public string baixarHTML(string portal)
        {
            WebClient web = new WebClient();
            try
            {
                portal = portal.Replace("<a href=", "");
                http = web.DownloadString(portal);
            }
            catch (System.Net.WebException e)
            {
                http = "Erro!";
            }
            return http;
        }
    }
}
