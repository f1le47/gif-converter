namespace CourseWorkIT.forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.height_input = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.width_input = new System.Windows.Forms.TextBox();
            this.gif_resolution = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delay_input = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.input_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 510);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.gif_resolution);
            this.panel5.Location = new System.Drawing.Point(9, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 62);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.height_input);
            this.panel7.Location = new System.Drawing.Point(210, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 33);
            this.panel7.TabIndex = 6;
            // 
            // height_input
            // 
            this.height_input.BackColor = System.Drawing.Color.White;
            this.height_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.height_input.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.height_input.Location = new System.Drawing.Point(3, 7);
            this.height_input.Name = "height_input";
            this.height_input.Size = new System.Drawing.Size(189, 19);
            this.height_input.TabIndex = 2;
            this.height_input.TextChanged += new System.EventHandler(this.height_input_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.width_input);
            this.panel6.Location = new System.Drawing.Point(3, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 33);
            this.panel6.TabIndex = 5;
            // 
            // width_input
            // 
            this.width_input.BackColor = System.Drawing.Color.White;
            this.width_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.width_input.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.width_input.Location = new System.Drawing.Point(3, 7);
            this.width_input.Name = "width_input";
            this.width_input.Size = new System.Drawing.Size(189, 19);
            this.width_input.TabIndex = 2;
            this.width_input.TextChanged += new System.EventHandler(this.width_input_TextChanged);
            // 
            // gif_resolution
            // 
            this.gif_resolution.AutoSize = true;
            this.gif_resolution.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gif_resolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.gif_resolution.Location = new System.Drawing.Point(-3, 3);
            this.gif_resolution.Name = "gif_resolution";
            this.gif_resolution.Size = new System.Drawing.Size(350, 19);
            this.gif_resolution.TabIndex = 3;
            this.gif_resolution.Text = "GIF resolution (width x height)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.delay_input);
            this.panel4.Location = new System.Drawing.Point(12, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 33);
            this.panel4.TabIndex = 4;
            // 
            // delay_input
            // 
            this.delay_input.BackColor = System.Drawing.Color.White;
            this.delay_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delay_input.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delay_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.delay_input.Location = new System.Drawing.Point(3, 7);
            this.delay_input.Name = "delay_input";
            this.delay_input.Size = new System.Drawing.Size(396, 19);
            this.delay_input.TabIndex = 2;
            this.delay_input.TextChanged += new System.EventHandler(this.delay_input_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.input_label);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 62);
            this.panel3.TabIndex = 3;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.input_label.Location = new System.Drawing.Point(-3, 3);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(372, 19);
            this.input_label.TabIndex = 3;
            this.input_label.Text = "Delay between frames (in seconds)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.back_button);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 101);
            this.panel2.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.AutoSize = true;
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Font = new System.Drawing.Font("Cunia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.Location = new System.Drawing.Point(31, 34);
            this.back_button.MinimumSize = new System.Drawing.Size(32, 32);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(32, 32);
            this.back_button.TabIndex = 1;
            this.back_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Cunia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(429, 101);
            this.title.TabIndex = 0;
            this.title.Text = "Settings";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label back_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox delay_input;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label gif_resolution;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox width_input;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox height_input;
    }
}