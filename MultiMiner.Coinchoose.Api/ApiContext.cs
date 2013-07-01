﻿using Newtonsoft.Json.Linq;
using System.Net;

namespace MultiMiner.Coinchoose.Api
{
    public static class ApiContext
    {
        public static JArray GetCoinInformation()
        {
            WebClient client = new WebClient();
            string jsonString = client.DownloadString("http://www.coinchoose.com/api.php");
            JArray jsonArray = JArray.Parse(jsonString);
            return jsonArray;
        }
    }
}
