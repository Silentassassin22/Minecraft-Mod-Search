using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

namespace ModList
{
    class API
    {
        HttpClient client = new HttpClient();
        WebClient client2 = new WebClient();

        public List<Mod> SearchMods(string search) 
        {
            List<Mod> mods = new List<Mod>();
            string content;
            /*Debug.WriteLine("test");
            System.Windows.Forms.MessageBox.Show("URL: "+ "https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter=" + search);
            var content = await client.GetStringAsync("https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter="+search);
            //System.Windows.Forms.MessageBox.Show(content);
            return content;*/
            try
            {
                content = client2.DownloadString("https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter="+search);
            }
            catch (Exception)
            { 
                throw;
            }
            dynamic json = JsonConvert.DeserializeObject(content);
            foreach(var x in json)
            {
                mods.Add(new Mod(Convert.ToString(x.name), Convert.ToString(x.attachments[0].url), Convert.ToString(x.summary), Convert.ToString(x.websiteUrl)));
            }
            System.Windows.Forms.MessageBox.Show("Total mods before returning: "+mods.Count);
            return mods;
        }
    }
}
