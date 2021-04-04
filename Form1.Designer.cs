namespace ModList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.v164 = new System.Windows.Forms.RadioButton();
            this.v1710 = new System.Windows.Forms.RadioButton();
            this.v1122 = new System.Windows.Forms.RadioButton();
            this.v1165 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 0);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 20);
            this.textBox2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1531, 593);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.v1165);
            this.groupBox1.Controls.Add(this.v1122);
            this.groupBox1.Controls.Add(this.v1710);
            this.groupBox1.Controls.Add(this.v164);
            this.groupBox1.Location = new System.Drawing.Point(763, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minecraft Version";
            // 
            // v164
            // 
            this.v164.AutoSize = true;
            this.v164.Location = new System.Drawing.Point(6, 19);
            this.v164.Name = "v164";
            this.v164.Size = new System.Drawing.Size(49, 17);
            this.v164.TabIndex = 0;
            this.v164.TabStop = true;
            this.v164.Text = "1.6.4";
            this.v164.UseVisualStyleBackColor = true;
            this.v164.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // v1710
            // 
            this.v1710.AutoSize = true;
            this.v1710.Location = new System.Drawing.Point(62, 19);
            this.v1710.Name = "v1710";
            this.v1710.Size = new System.Drawing.Size(55, 17);
            this.v1710.TabIndex = 1;
            this.v1710.TabStop = true;
            this.v1710.Text = "1.7.10";
            this.v1710.UseVisualStyleBackColor = true;
            // 
            // v1122
            // 
            this.v1122.AutoSize = true;
            this.v1122.Location = new System.Drawing.Point(123, 19);
            this.v1122.Name = "v1122";
            this.v1122.Size = new System.Drawing.Size(55, 17);
            this.v1122.TabIndex = 2;
            this.v1122.TabStop = true;
            this.v1122.Text = "1.12.2";
            this.v1122.UseVisualStyleBackColor = true;
            // 
            // v1165
            // 
            this.v1165.AutoSize = true;
            this.v1165.Checked = true;
            this.v1165.Location = new System.Drawing.Point(184, 19);
            this.v1165.Name = "v1165";
            this.v1165.Size = new System.Drawing.Size(55, 17);
            this.v1165.TabIndex = 3;
            this.v1165.TabStop = true;
            this.v1165.Text = "1.16.5";
            this.v1165.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1526, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton v164;
        private System.Windows.Forms.RadioButton v1165;
        private System.Windows.Forms.RadioButton v1122;
        private System.Windows.Forms.RadioButton v1710;
    }
}

