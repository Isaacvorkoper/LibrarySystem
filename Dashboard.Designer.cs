
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
            this.addStudentDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.returnbooksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.completeDetailMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.issueBooksMenu,
            this.returnbooksMenu,
            this.completeDetailMenu,
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
            this.viewBooks.DoubleClickEnabled = true;
            this.viewBooks.Image = ((System.Drawing.Image)(resources.GetObject("viewBooks.Image")));
            this.viewBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(219, 56);
            this.viewBooks.Text = "View books";
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // dashStudent
            // 
            this.dashStudent.BackColor = System.Drawing.Color.OldLace;
            this.dashStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentDrop,
            this.viewStudentDrop});
            this.dashStudent.Image = ((System.Drawing.Image)(resources.GetObject("dashStudent.Image")));
            this.dashStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashStudent.Name = "dashStudent";
            this.dashStudent.Size = new System.Drawing.Size(124, 54);
            this.dashStudent.Text = "Student";
            // 
            // addStudentDrop
            // 
            this.addStudentDrop.Image = ((System.Drawing.Image)(resources.GetObject("addStudentDrop.Image")));
            this.addStudentDrop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentDrop.Name = "addStudentDrop";
            this.addStudentDrop.Size = new System.Drawing.Size(237, 56);
            this.addStudentDrop.Text = "Add student";
            this.addStudentDrop.Click += new System.EventHandler(this.addStudentDrop_Click);
            // 
            // viewStudentDrop
            // 
            this.viewStudentDrop.DoubleClickEnabled = true;
            this.viewStudentDrop.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentDrop.Image")));
            this.viewStudentDrop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentDrop.Name = "viewStudentDrop";
            this.viewStudentDrop.Size = new System.Drawing.Size(237, 56);
            this.viewStudentDrop.Text = "View student info";
            this.viewStudentDrop.Click += new System.EventHandler(this.viewStudentDrop_Click);
            // 
            // issueBooksMenu
            // 
            this.issueBooksMenu.DoubleClickEnabled = true;
            this.issueBooksMenu.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksMenu.Image")));
            this.issueBooksMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksMenu.Name = "issueBooksMenu";
            this.issueBooksMenu.Size = new System.Drawing.Size(149, 54);
            this.issueBooksMenu.Text = "Issue books";
            this.issueBooksMenu.Click += new System.EventHandler(this.issueBooksMenu_Click);
            // 
            // returnbooksMenu
            // 
            this.returnbooksMenu.BackColor = System.Drawing.Color.OldLace;
            this.returnbooksMenu.DoubleClickEnabled = true;
            this.returnbooksMenu.Image = ((System.Drawing.Image)(resources.GetObject("returnbooksMenu.Image")));
            this.returnbooksMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnbooksMenu.Name = "returnbooksMenu";
            this.returnbooksMenu.Size = new System.Drawing.Size(160, 54);
            this.returnbooksMenu.Text = "Return books";
            this.returnbooksMenu.Click += new System.EventHandler(this.returnbooksMenu_Click);
            // 
            // completeDetailMenu
            // 
            this.completeDetailMenu.Image = ((System.Drawing.Image)(resources.GetObject("completeDetailMenu.Image")));
            this.completeDetailMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeDetailMenu.Name = "completeDetailMenu";
            this.completeDetailMenu.Size = new System.Drawing.Size(218, 54);
            this.completeDetailMenu.Text = "Complete book detail";
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
        private System.Windows.Forms.ToolStripMenuItem Issuebook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem viewBooks;
        private System.Windows.Forms.ToolStripMenuItem addStudentStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStudent;
        private System.Windows.Forms.ToolStripMenuItem dashExit;
        private System.Windows.Forms.ToolStripMenuItem dashStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentDrop;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDrop;
        private System.Windows.Forms.ToolStripMenuItem issueBooksMenu;
        private System.Windows.Forms.ToolStripMenuItem returnbooksMenu;
        private System.Windows.Forms.ToolStripMenuItem completeDetailMenu;
    }
}