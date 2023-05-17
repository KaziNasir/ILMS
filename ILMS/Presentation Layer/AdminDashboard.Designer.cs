
namespace ILMS.Presentation_Layer
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.homePageGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.homePageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentsToolStripMenuItem,
            this.manageBooksToolStripMenuItem,
            this.manageGenresToolStripMenuItem,
            this.manageIssuesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageStudentsToolStripMenuItem
            // 
            this.manageStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdminToolStripMenuItem,
            this.manageStudentsToolStripMenuItem1});
            this.manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            this.manageStudentsToolStripMenuItem.Size = new System.Drawing.Size(215, 42);
            this.manageStudentsToolStripMenuItem.Text = "Manage Users";
            // 
            // addNewAdminToolStripMenuItem
            // 
            this.addNewAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdminToolStripMenuItem1});
            this.addNewAdminToolStripMenuItem.Name = "addNewAdminToolStripMenuItem";
            this.addNewAdminToolStripMenuItem.Size = new System.Drawing.Size(337, 42);
            this.addNewAdminToolStripMenuItem.Text = "Manage Admin";
            // 
            // addNewAdminToolStripMenuItem1
            // 
            this.addNewAdminToolStripMenuItem1.Name = "addNewAdminToolStripMenuItem1";
            this.addNewAdminToolStripMenuItem1.Size = new System.Drawing.Size(325, 42);
            this.addNewAdminToolStripMenuItem1.Text = "Add New Admin";
            // 
            // manageStudentsToolStripMenuItem1
            // 
            this.manageStudentsToolStripMenuItem1.Name = "manageStudentsToolStripMenuItem1";
            this.manageStudentsToolStripMenuItem1.Size = new System.Drawing.Size(337, 42);
            this.manageStudentsToolStripMenuItem1.Text = "Manage Students";
            // 
            // manageBooksToolStripMenuItem
            // 
            this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
            this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(225, 42);
            this.manageBooksToolStripMenuItem.Text = "Manage Books";
            this.manageBooksToolStripMenuItem.Click += new System.EventHandler(this.manageBooksToolStripMenuItem_Click);
            // 
            // manageGenresToolStripMenuItem
            // 
            this.manageGenresToolStripMenuItem.Name = "manageGenresToolStripMenuItem";
            this.manageGenresToolStripMenuItem.Size = new System.Drawing.Size(235, 42);
            this.manageGenresToolStripMenuItem.Text = "Manage Genres";
            this.manageGenresToolStripMenuItem.Click += new System.EventHandler(this.manageGenresToolStripMenuItem_Click);
            // 
            // manageIssuesToolStripMenuItem
            // 
            this.manageIssuesToolStripMenuItem.Name = "manageIssuesToolStripMenuItem";
            this.manageIssuesToolStripMenuItem.Size = new System.Drawing.Size(320, 42);
            this.manageIssuesToolStripMenuItem.Text = "Manage Issue Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Books due today";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books past due";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(445, 326);
            this.dataGridView2.TabIndex = 2;
            // 
            // homePageGroupBox
            // 
            this.homePageGroupBox.Controls.Add(this.dataGridView2);
            this.homePageGroupBox.Controls.Add(this.dataGridView1);
            this.homePageGroupBox.Controls.Add(this.label2);
            this.homePageGroupBox.Controls.Add(this.label1);
            this.homePageGroupBox.Location = new System.Drawing.Point(22, 103);
            this.homePageGroupBox.Name = "homePageGroupBox";
            this.homePageGroupBox.Size = new System.Drawing.Size(1054, 481);
            this.homePageGroupBox.TabIndex = 4;
            this.homePageGroupBox.TabStop = false;
            this.homePageGroupBox.Text = "Home Page";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1088, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.homePageGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.homePageGroupBox.ResumeLayout(false);
            this.homePageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageIssuesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox homePageGroupBox;
    }
}