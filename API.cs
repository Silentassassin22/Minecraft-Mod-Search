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
        WebClient client = new WebClient();

        public List<Mod> SearchMods(string search, string version) 
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
                content = client.DownloadString("https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter="+search+"&gameVersion="+version);
            }
            catch (Exception)
            { 
                throw;
            }
            dynamic json = JsonConvert.DeserializeObject(content);
            for (int i = 0; i < json.Count; i++)
            {
                if(i >= 100)
                {
                    System.Windows.Forms.MessageBox.Show("Cut off after 100 mods");
                    break;
                }
                var x = json[i];
                mods.Add(new Mod(Convert.ToInt32(x.id), Convert.ToString(x.name), Convert.ToString(x.attachments[0].url), Convert.ToString(x.summary), Convert.ToString(x.websiteUrl)));
            }
            System.Windows.Forms.MessageBox.Show("Total mods before returning: "+mods.Count);
            return mods;
        }

        public void DownloadFile(int id, string path)
        {
            string content;
            dynamic files = GetAddonFiles(id);
            string link = files.downloadUrl;
            string filename = files.fileName;
            try
            {
                client.DownloadFile(link, path + @"\" + filename);
                //System.Windows.Forms.MessageBox.Show("Downloaded to: " + path + @"\" + filename);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object GetAddonFiles(int id)
        {
            string content;
            try
            {
                content = client.DownloadString("https://addons-ecs.forgesvc.net/api/v2/addon/" + id + "/files");
            }
            catch (Exception)
            {
                throw;
            }
            dynamic json = JsonConvert.DeserializeObject(content);
            return json[0];
        }

        public string GetLatestVersion()
        {
            string content;
            try
            {
                content = client.DownloadString("https://addons-ecs.forgesvc.net/api/v2/minecraft/version");
            }
            catch (Exception)
            {
                throw;
            }
            dynamic json = JsonConvert.DeserializeObject(content);

            System.Windows.Forms.MessageBox.Show("Latest version: " + json[0].versionString);

            return json[0].versionString;
        }
    }
}
