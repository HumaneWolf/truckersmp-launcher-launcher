using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace tmp_l_l
{
    static class ServerList
    {
        private static BindingSource serverList = new BindingSource();
        private static List<Server> sortingList = new List<Server>();

        public static BindingSource list
        {
            get
            {
                return serverList;
            }
        }

        public static void updateServerList()
        {
            serverList.Clear();
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://api.truckersmp.com/v2/servers");
            }
            JObject o = JObject.Parse(json);

            //Does the API give an error?
            string error = (string)o["error"];
            if (!error.Equals("false", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The API returned an error when we requested the server statuses.",
                   "Unable to load servers",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            //Generate list
            foreach (JToken s in o["response"].Children())
            {
                sortingList.Add(new Server(
                    (string)s["game"],
                    (string)s["shortname"],
                    (bool)s["online"],
                    (int)s["players"],
                    (int)s["maxplayers"],
                    (int)s["queue"],
                    (bool)s["speedlimiter"]
                    ));
            }

            //Sort them
            sortingList.Sort();
            //Add to the data source
            foreach (Server s in sortingList)
            {
                serverList.Add(s);
            }
            //Clear the temporary sorting list.
            sortingList.Clear();
        }
    }
}
