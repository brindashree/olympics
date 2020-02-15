namespace olympics
{
    partial class Event_UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EtID_txtbox = new System.Windows.Forms.TextBox();
            this.EtName_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EtIDsearch_txtbox = new System.Windows.Forms.TextBox();
            this.Search_Event_Button = new System.Windows.Forms.Button();
            this.Add_Event = new System.Windows.Forms.Button();
            this.Update_Event = new System.Windows.Forms.Button();
            this.Delete_Event = new System.Windows.Forms.Button();
            this.Clear_Event = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "EventID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "EventName";
            // 
            // EtID_txtbox
            // 
            this.EtID_txtbox.Location = new System.Drawing.Point(408, 519);
            this.EtID_txtbox.Name = "EtID_txtbox";
            this.EtID_txtbox.Size = new System.Drawing.Size(300, 22);
            this.EtID_txtbox.TabIndex = 2;
            // 
            // EtName_txtbox
            // 
            this.EtName_txtbox.Location = new System.Drawing.Point(408, 610);
            this.EtName_txtbox.Name = "EtName_txtbox";
            this.EtName_txtbox.Size = new System.Drawing.Size(300, 22);
            this.EtName_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "EventId";
            // 
            // EtIDsearch_txtbox
            // 
            this.EtIDsearch_txtbox.Location = new System.Drawing.Point(352, 51);
            this.EtIDsearch_txtbox.Name = "EtIDsearch_txtbox";
            this.EtIDsearch_txtbox.Size = new System.Drawing.Size(300, 22);
            this.EtIDsearch_txtbox.TabIndex = 5;
            // 
            // Search_Event_Button
            // 
            this.Search_Event_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Search_Event_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Event_Button.Location = new System.Drawing.Point(771, 44);
            this.Search_Event_Button.Name = "Search_Event_Button";
            this.Search_Event_Button.Size = new System.Drawing.Size(200, 45);
            this.Search_Event_Button.TabIndex = 6;
            this.Search_Event_Button.Text = "Search";
            this.Search_Event_Button.UseVisualStyleBackColor = false;
            this.Search_Event_Button.Click += new System.EventHandler(this.Search_Event_Button_Click);
            // 
            // Add_Event
            // 
            this.Add_Event.BackColor = System.Drawing.Color.PapayaWhip;
            this.Add_Event.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Event.Location = new System.Drawing.Point(140, 412);
            this.Add_Event.Name = "Add_Event";
            this.Add_Event.Size = new System.Drawing.Size(200, 45);
            this.Add_Event.TabIndex = 7;
            this.Add_Event.Text = "Add";
            this.Add_Event.UseVisualStyleBackColor = false;
            this.Add_Event.Click += new System.EventHandler(this.Add_Event_Click);
            // 
            // Update_Event
            // 
            this.Update_Event.BackColor = System.Drawing.Color.PapayaWhip;
            this.Update_Event.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Event.Location = new System.Drawing.Point(372, 412);
            this.Update_Event.Name = "Update_Event";
            this.Update_Event.Size = new System.Drawing.Size(200, 45);
            this.Update_Event.TabIndex = 8;
            this.Update_Event.Text = "Update";
            this.Update_Event.UseVisualStyleBackColor = false;
            this.Update_Event.Click += new System.EventHandler(this.Update_Event_Click);
            // 
            // Delete_Event
            // 
            this.Delete_Event.BackColor = System.Drawing.Color.PapayaWhip;
            this.Delete_Event.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Event.Location = new System.Drawing.Point(598, 412);
            this.Delete_Event.Name = "Delete_Event";
            this.Delete_Event.Size = new System.Drawing.Size(200, 45);
            this.Delete_Event.TabIndex = 9;
            this.Delete_Event.Text = "Delete";
            this.Delete_Event.UseVisualStyleBackColor = false;
            this.Delete_Event.Click += new System.EventHandler(this.Delete_Event_Click);
            // 
            // Clear_Event
            // 
            this.Clear_Event.BackColor = System.Drawing.Color.PapayaWhip;
            this.Clear_Event.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Event.Location = new System.Drawing.Point(817, 412);
            this.Clear_Event.Name = "Clear_Event";
            this.Clear_Event.Size = new System.Drawing.Size(200, 45);
            this.Clear_Event.TabIndex = 10;
            this.Clear_Event.Text = "Clear";
            this.Clear_Event.UseVisualStyleBackColor = false;
            this.Clear_Event.Click += new System.EventHandler(this.Clear_Event_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 250);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(352, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 5);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(408, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(408, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 5);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Museo Sans For Dell", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1018, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Event";
            // 
            // Event_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clear_Event);
            this.Controls.Add(this.Delete_Event);
            this.Controls.Add(this.Update_Event);
            this.Controls.Add(this.Add_Event);
            this.Controls.Add(this.Search_Event_Button);
            this.Controls.Add(this.EtIDsearch_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EtName_txtbox);
            this.Controls.Add(this.EtID_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Event_UserControl1";
            this.Size = new System.Drawing.Size(1190, 739);
            this.Load += new System.EventHandler(this.Event_UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EtID_txtbox;
        private System.Windows.Forms.TextBox EtName_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EtIDsearch_txtbox;
        private System.Windows.Forms.Button Search_Event_Button;
        private System.Windows.Forms.Button Add_Event;
        private System.Windows.Forms.Button Update_Event;
        private System.Windows.Forms.Button Delete_Event;
        private System.Windows.Forms.Button Clear_Event;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}
