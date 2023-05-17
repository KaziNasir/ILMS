
namespace ILMS.Presentation_Layer
{
    partial class ManageGenres
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
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addGenreGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editGenreGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.editIdTextBox = new System.Windows.Forms.TextBox();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.addGenreGroupBox.SuspendLayout();
            this.editGenreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Location = new System.Drawing.Point(670, 49);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.RowHeadersWidth = 51;
            this.genreDataGridView.RowTemplate.Height = 24;
            this.genreDataGridView.Size = new System.Drawing.Size(341, 480);
            this.genreDataGridView.TabIndex = 0;
            this.genreDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreDataGridView_CellClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(922, 543);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 43);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addGenreGroupBox
            // 
            this.addGenreGroupBox.Controls.Add(this.addButton);
            this.addGenreGroupBox.Controls.Add(this.addGenreTextBox);
            this.addGenreGroupBox.Controls.Add(this.label1);
            this.addGenreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenreGroupBox.Location = new System.Drawing.Point(48, 49);
            this.addGenreGroupBox.Name = "addGenreGroupBox";
            this.addGenreGroupBox.Size = new System.Drawing.Size(547, 191);
            this.addGenreGroupBox.TabIndex = 2;
            this.addGenreGroupBox.TabStop = false;
            this.addGenreGroupBox.Text = "Add New Genre";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(264, 121);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(165, 65);
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(333, 30);
            this.addGenreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // editGenreGroupBox
            // 
            this.editGenreGroupBox.Controls.Add(this.deleteButton);
            this.editGenreGroupBox.Controls.Add(this.updateButton);
            this.editGenreGroupBox.Controls.Add(this.editIdTextBox);
            this.editGenreGroupBox.Controls.Add(this.editNameTextBox);
            this.editGenreGroupBox.Controls.Add(this.label3);
            this.editGenreGroupBox.Controls.Add(this.label2);
            this.editGenreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGenreGroupBox.Location = new System.Drawing.Point(48, 292);
            this.editGenreGroupBox.Name = "editGenreGroupBox";
            this.editGenreGroupBox.Size = new System.Drawing.Size(547, 237);
            this.editGenreGroupBox.TabIndex = 2;
            this.editGenreGroupBox.TabStop = false;
            this.editGenreGroupBox.Text = "Edit / Delete Genre";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(358, 170);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 42);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(185, 170);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 42);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editIdTextBox
            // 
            this.editIdTextBox.Enabled = false;
            this.editIdTextBox.Location = new System.Drawing.Point(161, 66);
            this.editIdTextBox.Name = "editIdTextBox";
            this.editIdTextBox.Size = new System.Drawing.Size(333, 30);
            this.editIdTextBox.TabIndex = 1;
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.Location = new System.Drawing.Point(161, 120);
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(333, 30);
            this.editNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // ManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 598);
            this.Controls.Add(this.editGenreGroupBox);
            this.Controls.Add(this.addGenreGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.genreDataGridView);
            this.Name = "ManageGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Genres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageGenres_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.addGenreGroupBox.ResumeLayout(false);
            this.addGenreGroupBox.PerformLayout();
            this.editGenreGroupBox.ResumeLayout(false);
            this.editGenreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox addGenreGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addGenreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox editGenreGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editIdTextBox;
        private System.Windows.Forms.Label label3;
    }
}