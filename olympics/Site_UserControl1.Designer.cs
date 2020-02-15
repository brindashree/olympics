namespace olympics
{
    partial class Site_UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Site_UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.Yearsearch_textbox = new System.Windows.Forms.TextBox();
            this.Search_Site_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.year_txtbox = new System.Windows.Forms.TextBox();
            this.Cntry_txtbox = new System.Windows.Forms.TextBox();
            this.city_txtbox = new System.Windows.Forms.TextBox();
            this.EventID_txtbox = new System.Windows.Forms.TextBox();
            this.Add_Site_Button = new System.Windows.Forms.Button();
            this.Update_Site_Button = new System.Windows.Forms.Button();
            this.Delete_Site_Button = new System.Windows.Forms.Button();
            this.Clear_Site_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.site_sel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Yearsearch_textbox
            // 
            this.Yearsearch_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Yearsearch_textbox.Location = new System.Drawing.Point(389, 57);
            this.Yearsearch_textbox.Name = "Yearsearch_textbox";
            this.Yearsearch_textbox.Size = new System.Drawing.Size(300, 15);
            this.Yearsearch_textbox.TabIndex = 1;
            this.Yearsearch_textbox.TextChanged += new System.EventHandler(this.Yearsearch_textbox_TextChanged);
            // 
            // Search_Site_Button
            // 
            this.Search_Site_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Search_Site_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Site_Button.Location = new System.Drawing.Point(766, 41);
            this.Search_Site_Button.Name = "Search_Site_Button";
            this.Search_Site_Button.Size = new System.Drawing.Size(200, 45);
            this.Search_Site_Button.TabIndex = 2;
            this.Search_Site_Button.Text = "Search";
            this.Search_Site_Button.UseVisualStyleBackColor = false;
            this.Search_Site_Button.Click += new System.EventHandler(this.Search_Site_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "EventID";
            // 
            // year_txtbox
            // 
            this.year_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year_txtbox.Location = new System.Drawing.Point(300, 510);
            this.year_txtbox.Name = "year_txtbox";
            this.year_txtbox.Size = new System.Drawing.Size(300, 15);
            this.year_txtbox.TabIndex = 8;
            // 
            // Cntry_txtbox
            // 
            this.Cntry_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cntry_txtbox.Location = new System.Drawing.Point(300, 632);
            this.Cntry_txtbox.Name = "Cntry_txtbox";
            this.Cntry_txtbox.Size = new System.Drawing.Size(300, 15);
            this.Cntry_txtbox.TabIndex = 9;
            // 
            // city_txtbox
            // 
            this.city_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.city_txtbox.Location = new System.Drawing.Point(775, 509);
            this.city_txtbox.Name = "city_txtbox";
            this.city_txtbox.Size = new System.Drawing.Size(300, 15);
            this.city_txtbox.TabIndex = 10;
            // 
            // EventID_txtbox
            // 
            this.EventID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventID_txtbox.Location = new System.Drawing.Point(775, 631);
            this.EventID_txtbox.Name = "EventID_txtbox";
            this.EventID_txtbox.Size = new System.Drawing.Size(300, 15);
            this.EventID_txtbox.TabIndex = 11;
            // 
            // Add_Site_Button
            // 
            this.Add_Site_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Add_Site_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Site_Button.Location = new System.Drawing.Point(22, 420);
            this.Add_Site_Button.Name = "Add_Site_Button";
            this.Add_Site_Button.Size = new System.Drawing.Size(200, 45);
            this.Add_Site_Button.TabIndex = 12;
            this.Add_Site_Button.Text = "Add";
            this.Add_Site_Button.UseVisualStyleBackColor = false;
            this.Add_Site_Button.Click += new System.EventHandler(this.Add_Site_Button_Click);
            // 
            // Update_Site_Button
            // 
            this.Update_Site_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Update_Site_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Site_Button.Location = new System.Drawing.Point(500, 420);
            this.Update_Site_Button.Name = "Update_Site_Button";
            this.Update_Site_Button.Size = new System.Drawing.Size(200, 45);
            this.Update_Site_Button.TabIndex = 13;
            this.Update_Site_Button.Text = "Update";
            this.Update_Site_Button.UseVisualStyleBackColor = false;
            this.Update_Site_Button.Click += new System.EventHandler(this.Update_Site_Button_Click);
            // 
            // Delete_Site_Button
            // 
            this.Delete_Site_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Delete_Site_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Site_Button.Location = new System.Drawing.Point(734, 420);
            this.Delete_Site_Button.Name = "Delete_Site_Button";
            this.Delete_Site_Button.Size = new System.Drawing.Size(200, 45);
            this.Delete_Site_Button.TabIndex = 14;
            this.Delete_Site_Button.Text = "Delete";
            this.Delete_Site_Button.UseVisualStyleBackColor = false;
            this.Delete_Site_Button.Click += new System.EventHandler(this.Delete_Site_Button_Click);
            // 
            // Clear_Site_Button
            // 
            this.Clear_Site_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Clear_Site_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Site_Button.Location = new System.Drawing.Point(976, 420);
            this.Clear_Site_Button.Name = "Clear_Site_Button";
            this.Clear_Site_Button.Size = new System.Drawing.Size(200, 45);
            this.Clear_Site_Button.TabIndex = 15;
            this.Clear_Site_Button.Text = "Clear";
            this.Clear_Site_Button.UseVisualStyleBackColor = false;
            this.Clear_Site_Button.Click += new System.EventHandler(this.Clear_Site_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(389, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 5);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(300, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(300, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 5);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(775, 523);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 5);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(775, 649);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 5);
            this.panel5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1019, 692);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Site";
            // 
            // site_sel_btn
            // 
            this.site_sel_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.site_sel_btn.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_sel_btn.Location = new System.Drawing.Point(261, 420);
            this.site_sel_btn.Name = "site_sel_btn";
            this.site_sel_btn.Size = new System.Drawing.Size(200, 45);
            this.site_sel_btn.TabIndex = 18;
            this.site_sel_btn.Text = "Select";
            this.site_sel_btn.UseVisualStyleBackColor = false;
            this.site_sel_btn.Click += new System.EventHandler(this.site_sel_btn_Click);
            // 
            // Site_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.site_sel_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear_Site_Button);
            this.Controls.Add(this.Delete_Site_Button);
            this.Controls.Add(this.Update_Site_Button);
            this.Controls.Add(this.Add_Site_Button);
            this.Controls.Add(this.EventID_txtbox);
            this.Controls.Add(this.city_txtbox);
            this.Controls.Add(this.Cntry_txtbox);
            this.Controls.Add(this.year_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_Site_Button);
            this.Controls.Add(this.Yearsearch_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Site_UserControl1";
            this.Size = new System.Drawing.Size(1190, 739);
            this.Load += new System.EventHandler(this.Site_UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Yearsearch_textbox;
        private System.Windows.Forms.Button Search_Site_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox year_txtbox;
        private System.Windows.Forms.TextBox Cntry_txtbox;
        private System.Windows.Forms.TextBox city_txtbox;
        private System.Windows.Forms.TextBox EventID_txtbox;
        private System.Windows.Forms.Button Add_Site_Button;
        private System.Windows.Forms.Button Update_Site_Button;
        private System.Windows.Forms.Button Delete_Site_Button;
        private System.Windows.Forms.Button Clear_Site_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button site_sel_btn;
    }
}
