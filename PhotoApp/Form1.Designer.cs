namespace PhotoApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.filter = new System.Windows.Forms.ToolStripMenuItem();
            this.gray = new System.Windows.Forms.ToolStripMenuItem();
            this.bright = new System.Windows.Forms.ToolStripMenuItem();
            this.invert = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom25 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom50 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom150 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom300 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.filter,
            this.edit,
            this.zoom});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFile,
            this.saveFile,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // LoadFile
            // 
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(152, 22);
            this.LoadFile.Text = "Load";
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(152, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // filter
            // 
            this.filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gray,
            this.bright,
            this.invert,
            this.color});
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(45, 20);
            this.filter.Text = "Filter";
            // 
            // gray
            // 
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(152, 22);
            this.gray.Text = "GrayScale";
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // bright
            // 
            this.bright.Name = "bright";
            this.bright.Size = new System.Drawing.Size(152, 22);
            this.bright.Text = "Brightness";
            this.bright.Click += new System.EventHandler(this.bright_Click);
            // 
            // invert
            // 
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(152, 22);
            this.invert.Text = "Invert";
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(152, 22);
            this.color.Text = "Color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(39, 20);
            this.edit.Text = "Edit";
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(152, 22);
            this.undo.Text = "Undo";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // zoom
            // 
            this.zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom25,
            this.zoom50,
            this.zoom100,
            this.zoom150,
            this.zoom200,
            this.zoom300});
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(51, 20);
            this.zoom.Text = "Zoom";
            // 
            // zoom25
            // 
            this.zoom25.Name = "zoom25";
            this.zoom25.Size = new System.Drawing.Size(152, 22);
            this.zoom25.Text = "25%";
            this.zoom25.Click += new System.EventHandler(this.zoom25_Click);
            // 
            // zoom50
            // 
            this.zoom50.Name = "zoom50";
            this.zoom50.Size = new System.Drawing.Size(152, 22);
            this.zoom50.Text = "50%";
            this.zoom50.Click += new System.EventHandler(this.zoom50_Click);
            // 
            // zoom100
            // 
            this.zoom100.Name = "zoom100";
            this.zoom100.Size = new System.Drawing.Size(152, 22);
            this.zoom100.Text = "100%";
            this.zoom100.Click += new System.EventHandler(this.zoom100_Click);
            // 
            // zoom150
            // 
            this.zoom150.Name = "zoom150";
            this.zoom150.Size = new System.Drawing.Size(152, 22);
            this.zoom150.Text = "150%";
            this.zoom150.Click += new System.EventHandler(this.zoom150_Click);
            // 
            // zoom200
            // 
            this.zoom200.Name = "zoom200";
            this.zoom200.Size = new System.Drawing.Size(152, 22);
            this.zoom200.Text = "200%";
            this.zoom200.Click += new System.EventHandler(this.zoom200_Click);
            // 
            // zoom300
            // 
            this.zoom300.Name = "zoom300";
            this.zoom300.Size = new System.Drawing.Size(152, 22);
            this.zoom300.Text = "300%";
            this.zoom300.Click += new System.EventHandler(this.zoom300_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(618, 364);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem LoadFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem filter;
        private System.Windows.Forms.ToolStripMenuItem gray;
        private System.Windows.Forms.ToolStripMenuItem bright;
        private System.Windows.Forms.ToolStripMenuItem invert;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem zoom;
        private System.Windows.Forms.ToolStripMenuItem zoom25;
        private System.Windows.Forms.ToolStripMenuItem zoom50;
        private System.Windows.Forms.ToolStripMenuItem zoom100;
        private System.Windows.Forms.ToolStripMenuItem zoom150;
        private System.Windows.Forms.ToolStripMenuItem zoom200;
        private System.Windows.Forms.ToolStripMenuItem zoom300;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

