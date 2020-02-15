namespace olympics
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.Sldpanel = new System.Windows.Forms.Panel();
            this.About_btn = new System.Windows.Forms.Button();
            this.Add_res_button = new System.Windows.Forms.Button();
            this.up_res_button = new System.Windows.Forms.Button();
            this.Schedule_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Event_button = new System.Windows.Forms.Button();
            this.athlete_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoff = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Sldpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_timer
            // 
            this.login_timer.Interval = 30;
            this.login_timer.Tick += new System.EventHandler(this.login_timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackColor = System.Drawing.Color.White;
            this.contentpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentpanel.BackgroundImage")));
            this.contentpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(254, 36);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1190, 739);
            this.contentpanel.TabIndex = 2;
            // 
            // Sldpanel
            // 
            this.Sldpanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Sldpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sldpanel.BackgroundImage")));
            this.Sldpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sldpanel.Controls.Add(this.About_btn);
            this.Sldpanel.Controls.Add(this.Add_res_button);
            this.Sldpanel.Controls.Add(this.up_res_button);
            this.Sldpanel.Controls.Add(this.Schedule_button);
            this.Sldpanel.Controls.Add(this.button3);
            this.Sldpanel.Controls.Add(this.Event_button);
            this.Sldpanel.Controls.Add(this.athlete_button);
            this.Sldpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sldpanel.Location = new System.Drawing.Point(0, 36);
            this.Sldpanel.Name = "Sldpanel";
            this.Sldpanel.Size = new System.Drawing.Size(250, 739);
            this.Sldpanel.TabIndex = 1;
            // 
            // About_btn
            // 
            this.About_btn.BackColor = System.Drawing.Color.Transparent;
            this.About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_btn.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_btn.Location = new System.Drawing.Point(0, 276);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(250, 50);
            this.About_btn.TabIndex = 7;
            this.About_btn.Text = "About";
            this.About_btn.UseVisualStyleBackColor = false;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // Add_res_button
            // 
            this.Add_res_button.BackColor = System.Drawing.Color.Transparent;
            this.Add_res_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_res_button.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_res_button.Location = new System.Drawing.Point(0, 231);
            this.Add_res_button.Name = "Add_res_button";
            this.Add_res_button.Size = new System.Drawing.Size(250, 50);
            this.Add_res_button.TabIndex = 6;
            this.Add_res_button.Text = "Add Result";
            this.Add_res_button.UseVisualStyleBackColor = false;
            this.Add_res_button.Click += new System.EventHandler(this.Add_res_button_Click);
            // 
            // up_res_button
            // 
            this.up_res_button.BackColor = System.Drawing.Color.Transparent;
            this.up_res_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_res_button.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_res_button.Location = new System.Drawing.Point(0, 185);
            this.up_res_button.Name = "up_res_button";
            this.up_res_button.Size = new System.Drawing.Size(250, 50);
            this.up_res_button.TabIndex = 5;
            this.up_res_button.Text = "Update Result";
            this.up_res_button.UseVisualStyleBackColor = false;
            this.up_res_button.Click += new System.EventHandler(this.up_res_button_Click);
            // 
            // Schedule_button
            // 
            this.Schedule_button.BackColor = System.Drawing.Color.Transparent;
            this.Schedule_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schedule_button.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_button.ForeColor = System.Drawing.Color.Black;
            this.Schedule_button.Location = new System.Drawing.Point(0, 138);
            this.Schedule_button.Name = "Schedule_button";
            this.Schedule_button.Size = new System.Drawing.Size(250, 50);
            this.Schedule_button.TabIndex = 4;
            this.Schedule_button.Text = "Schedule";
            this.Schedule_button.UseVisualStyleBackColor = false;
            this.Schedule_button.Click += new System.EventHandler(this.Schedule_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Site";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Event_button
            // 
            this.Event_button.BackColor = System.Drawing.Color.Transparent;
            this.Event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event_button.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_button.ForeColor = System.Drawing.Color.Black;
            this.Event_button.Location = new System.Drawing.Point(0, 46);
            this.Event_button.Name = "Event_button";
            this.Event_button.Size = new System.Drawing.Size(250, 50);
            this.Event_button.TabIndex = 2;
            this.Event_button.Text = "Event";
            this.Event_button.UseVisualStyleBackColor = false;
            this.Event_button.Click += new System.EventHandler(this.Event_button_Click);
            // 
            // athlete_button
            // 
            this.athlete_button.BackColor = System.Drawing.Color.Transparent;
            this.athlete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.athlete_button.Font = new System.Drawing.Font("Museo Sans For Dell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athlete_button.ForeColor = System.Drawing.Color.Black;
            this.athlete_button.Location = new System.Drawing.Point(0, 0);
            this.athlete_button.Name = "athlete_button";
            this.athlete_button.Size = new System.Drawing.Size(250, 50);
            this.athlete_button.TabIndex = 1;
            this.athlete_button.Text = "Athlete";
            this.athlete_button.UseVisualStyleBackColor = false;
            this.athlete_button.Click += new System.EventHandler(this.athlete_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.logoff);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logoff
            // 
            this.logoff.BackColor = System.Drawing.Color.Transparent;
            this.logoff.BackgroundImage = global::olympics.Properties.Resources.log_off_icon;
            this.logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoff.Location = new System.Drawing.Point(1325, 4);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(38, 29);
            this.logoff.TabIndex = 2;
            this.logoff.UseVisualStyleBackColor = false;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::olympics.Properties.Resources.minimize;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Location = new System.Drawing.Point(1369, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 29);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::olympics.Properties.Resources.close;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Location = new System.Drawing.Point(1408, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 29);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 775);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.Sldpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.Sldpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel Sldpanel;
        private System.Windows.Forms.Button Schedule_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Event_button;
        private System.Windows.Forms.Button athlete_button;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button up_res_button;
        private System.Windows.Forms.Button Add_res_button;
        private System.Windows.Forms.Button About_btn;
    }
}