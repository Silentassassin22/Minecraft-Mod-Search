using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModList
{
    
    public partial class Form1 : Form
    {
        API API = new API();

        List<int> ids = new List<int>();

        string path = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string version = "";
            switch (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name)
            {
                case "v164":
                    version = "1.6.4";
                    break;
                case "v1710":
                    version = "1.7.10";
                    break;
                case "v1122":
                    version = "1.12.2";
                    break;
                default:
                    version = API.GetLatestVersion();
                    break;
            }
            //MessageBox.Show("Search: "+textBox2.Text);
            //MessageBox.Show("Searching version: "+version);
            List<Mod> content = API.SearchMods(textBox2.Text, version);
            //MessageBox.Show("Total Mods: "+ content.Count);
            foreach(Mod x in content)
            {
                CheckBox checkbox = new CheckBox();

                Panel panel = new Panel();
                panel.Size = new System.Drawing.Size(240, 295);
                panel.BackColor = BackColor = SystemColors.HotTrack;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Click += (a, b) =>
                {
                    if (path != "")
                    {
                        checkbox.Checked = !checkbox.Checked;
                    }
                };

                PictureBox picture = new PictureBox();
                picture.ImageLocation = x.piclink; //234
                picture.Size = new System.Drawing.Size(229, 160);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Location = new Point(3, 3);
                //picture.BorderStyle = BorderStyle.Fixed3D;
                picture.Click += (a, b) =>
                {
                    if(path != "")
                    {
                        checkbox.Checked = !checkbox.Checked;
                    }
                };

                checkbox.Location = new Point(0, 0);
                checkbox.Parent = picture;
                checkbox.Size = new System.Drawing.Size(30, 30);
                checkbox.BackColor = Color.Transparent;
                checkbox.Text = "";
                checkbox.CheckedChanged += (a, b) =>
                {
                    if(checkbox.Checked && !ids.Contains(x.id))
                    {
                        ids.Add(x.id);
                    }
                };

                Label label = new Label();
                label.Text = "";
                label.BorderStyle = BorderStyle.Fixed3D;
                label.AutoSize = false;
                label.Location = new Point(0, picture.Bounds.Bottom + 20);
                label.Height = 2;
                label.Width = 240;

                TextBox text = new TextBox();
                text.Multiline = true;
                text.Size = new System.Drawing.Size(234, 123);
                text.Location = new Point(picture.Location.X, picture.Bounds.Bottom + Padding.Top);
                text.TextAlign = HorizontalAlignment.Center;
                text.Font = new Font(text.Font.FontFamily, 12);
                text.BackColor = SystemColors.HotTrack;
                text.ForeColor = System.Drawing.Color.White;
                text.BorderStyle = BorderStyle.None;
                text.Text = x.title + Environment.NewLine + x.description;

                text.Click += (a, b) =>
                {
                    if (path != "")
                    {
                        checkbox.Checked = !checkbox.Checked;
                    }
                };

                panel.Controls.Add(checkbox);
                panel.Controls.Add(picture);
                panel.Controls.Add(label);
                panel.Controls.Add(text);

                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel1.Invalidate();
                //flowLayoutPanel1.Controls.Add(panel = new Panel() { Size = new System.Drawing.Size(240, 295), BackColor = SystemColors.HotTrack });
            }
            
            
            /*tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            MessageBox.Show(Convert.ToString(tableLayoutPanel1.RowCount));
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Monkey", AutoSize = true }, 0, 0);*/
        }

        private void downloadbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (downloadbutton.Checked)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                DialogResult result = folder.ShowDialog();
                path = folder.SelectedPath;

            }
        }

        private void Panel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();

            base.OnScroll(e);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Transform = new Matrix(1, 0, 0, 1, this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void StartNew()
        {
            System.Diagnostics.Process.Start("https://google.com");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void download_Click(object sender, EventArgs e)
        {
            foreach(var x in ids)
            {
                API.DownloadFile(x, path);
            }
        }
    }
}
