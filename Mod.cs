﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModList
{
    class Mod
    {
        public int id { get; set; }
        public string title { get; set; }
        public string piclink { get; set; }
        public string description { get; set; }
        public string pagelink { get; set; }

        public Mod(int Id,  string Title, string Piclink, string Description, string Pagelink)
        {
            id = Id;
            title = Title;
            piclink = Piclink;
            description = Description;
            pagelink = Pagelink;
            //System.Windows.Forms.MessageBox.Show("New mod added!" + title);
        }
    }
}
