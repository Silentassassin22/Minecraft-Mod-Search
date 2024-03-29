﻿using System;
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
        WebClient client2 = new WebClient();

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
                content = client2.DownloadString("https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter="+search+"&gameVersion="+version);
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
                mods.Add(new Mod(Convert.ToString(x.name), Convert.ToString(x.attachments[0].url), Convert.ToString(x.summary), Convert.ToString(x.websiteUrl)));
            }
            System.Windows.Forms.MessageBox.Show("Total mods before returning: "+mods.Count);
            return mods;
        }

        public string GetLatestVersion()
        {
            string content;
            try
            {
                content = client2.DownloadString("https://addons-ecs.forgesvc.net/api/v2/minecraft/version");
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
