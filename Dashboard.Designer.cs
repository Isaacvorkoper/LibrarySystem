
namespace LibarySystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.dashStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBooks,
            this.dashStudent,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.dashExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBooks
            // 
            this.dashBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookDrop,
            this.viewBooks});
            this.dashBooks.Image = ((System.Drawing.Image)(resources.GetObject("dashBooks.Image")));
            this.dashBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashBooks.Name = "dashBooks";
            this.dashBooks.Size = new System.Drawing.Size(113, 54);
            this.dashBooks.Text = "Books";
            // 
            // addBookDrop
            // 
            this.addBookDrop.DoubleClickEnabled = true;
            this.addBookDrop.Image = ((System.Drawing.Image)(resources.GetObject("addBookDrop.Image")));
            this.addBookDrop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookDrop.Name = "addBookDrop";
            this.addBookDrop.Size = new System.Drawing.Size(219, 56);
            this.addBookDrop.Text = "Add new book";
            this.addBookDrop.Click += new System.EventHandler(this.addBookDrop_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Image = ((System.Drawing.Image)(resources.GetObject("viewBooks.Image")));
            this.viewBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(219, 56);
            this.viewBooks.Text = "View books";
            // 
            // dashStudent
            // 
            this.dashStudent.BackColor = System.Drawing.Color.OldLace;
            this.dashStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudent,
            this.viewStudent});
            this.dashStudent.Image = ((System.Drawing.Image)(resources.GetObject("dashStudent.Image")));
            this.dashStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashStudent.Name = "dashStudent";
            this.dashStudent.Size = new System.Drawing.Size(124, 54);
            this.dashStudent.Text = "Student";
            // 
            // addStudent
            // 
            this.addStudent.Image = ((System.Drawing.Image)(resources.GetObject("addStudent.Image")));
            this.addStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(237, 56);
            this.addStudent.Text = "Add student";
            // 
            // viewStudent
            // 
            this.viewStudent.Image = ((System.Drawing.Image)(resources.GetObject("viewStudent.Image")));
            this.viewStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudent.Name = "viewStudent";
            this.viewStudent.Size = new System.Drawing.Size(237, 56);
            this.viewStudent.Text = "View student info";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 54);
            this.toolStripMenuItem3.Text = "Issue books";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.OldLace;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 54);
            this.toolStripMenuItem4.Text = "Return books";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(218, 54);
            this.toolStripMenuItem5.Text = "Complete book detail";
            // 
            // dashExit
            // 
            this.dashExit.BackColor = System.Drawing.Color.OldLace;
            this.dashExit.DoubleClickEnabled = true;
            this.dashExit.Image = ((System.Drawing.Image)(resources.GetObject("dashExit.Image")));
            this.dashExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashExit.Name = "dashExit";
            this.dashExit.Size = new System.Drawing.Size(97, 54);
            this.dashExit.Text = "Exit";
            this.dashExit.Click += new System.EventHandler(this.dashExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 463);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBooks;
        private System.Windows.Forms.ToolStripMenuItem addBookDrop;
        private System.Windows.Forms.ToolStripMenuItem booksMenu;
        private System.Windows.Forms.ToolStripMenuItem dashtudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem viewBooks;
        private System.Windows.Forms.ToolStripMenuItem addStudent;
        private System.Windows.Forms.ToolStripMenuItem viewStudent;
        private System.Windows.Forms.ToolStripMenuItem dashExit;
        private System.Windows.Forms.ToolStripMenuItem dashStudent;
    }
}