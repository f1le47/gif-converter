namespace CourseWorkIT.forms
{
    partial class GifCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifCreator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.Label();
            this.file_names = new System.Windows.Forms.ListBox();
            this.create_gif = new System.Windows.Forms.Button();
            this.add_images = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.notify);
            this.panel1.Controls.Add(this.file_names);
            this.panel1.Controls.Add(this.create_gif);
            this.panel1.Controls.Add(this.add_images);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 510);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(74)))));
            this.notify.Location = new System.Drawing.Point(14, 413);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 24);
            this.notify.TabIndex = 4;
            // 
            // file_names
            // 
            this.file_names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
            this.file_names.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.file_names.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.file_names.FormattingEnabled = true;
            this.file_names.ItemHeight = 19;
            this.file_names.Location = new System.Drawing.Point(12, 113);
            this.file_names.Name = "file_names";
            this.file_names.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.file_names.Size = new System.Drawing.Size(405, 228);
            this.file_names.TabIndex = 3;
            // 
            // create_gif
            // 
            this.create_gif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.create_gif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_gif.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create_gif.FlatAppearance.BorderSize = 3;
            this.create_gif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.create_gif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.create_gif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_gif.Font = new System.Drawing.Font("Cunia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_gif.ForeColor = System.Drawing.Color.White;
            this.create_gif.Location = new System.Drawing.Point(12, 376);
            this.create_gif.Name = "create_gif";
            this.create_gif.Size = new System.Drawing.Size(405, 58);
            this.create_gif.TabIndex = 2;
            this.create_gif.Text = "Создать GIF";
            this.create_gif.UseVisualStyleBackColor = false;
            this.create_gif.Visible = false;
            this.create_gif.Click += new System.EventHandler(this.create_gif_Click);
            // 
            // add_images
            // 
            this.add_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.add_images.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_images.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_images.FlatAppearance.BorderSize = 3;
            this.add_images.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.add_images.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(61)))));
            this.add_images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_images.Font = new System.Drawing.Font("Cunia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_images.ForeColor = System.Drawing.Color.White;
            this.add_images.Location = new System.Drawing.Point(12, 440);
            this.add_images.Name = "add_images";
            this.add_images.Size = new System.Drawing.Size(405, 58);
            this.add_images.TabIndex = 1;
            this.add_images.Text = "Добавить изображения";
            this.add_images.UseVisualStyleBackColor = false;
            this.add_images.Click += new System.EventHandler(this.add_images_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.settings_button);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 101);
            this.panel2.TabIndex = 0;
            // 
            // settings_button
            // 
            this.settings_button.AutoSize = true;
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.Font = new System.Drawing.Font("Cunia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.Image = ((System.Drawing.Image)(resources.GetObject("settings_button.Image")));
            this.settings_button.Location = new System.Drawing.Point(347, 9);
            this.settings_button.MinimumSize = new System.Drawing.Size(32, 32);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(32, 32);
            this.settings_button.TabIndex = 2;
            this.settings_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Cunia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(385, 9);
            this.close_button.MinimumSize = new System.Drawing.Size(32, 32);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(32, 32);
            this.close_button.TabIndex = 1;
            this.close_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
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
            this.title.Text = "Изображения в GIF";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // GifCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GifCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gifcreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.Button add_images;
        private System.Windows.Forms.Button create_gif;
        private System.Windows.Forms.ListBox file_names;
        private System.Windows.Forms.Label settings_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label notify;
    }
}