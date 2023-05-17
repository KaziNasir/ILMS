
namespace ILMS.Presentation_Layer
{
    partial class ManageBooks
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
            this.searchByDataGridView = new System.Windows.Forms.DataGridView();
            this.sortByGenreDataGridView = new System.Windows.Forms.DataGridView();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortByGenreComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.serachByTextBox = new System.Windows.Forms.TextBox();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.manageBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.publishedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.issuedTextBox = new System.Windows.Forms.TextBox();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByGenreDataGridView)).BeginInit();
            this.sortGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.manageBooksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchByDataGridView
            // 
            this.searchByDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchByDataGridView.Location = new System.Drawing.Point(35, 78);
            this.searchByDataGridView.Name = "searchByDataGridView";
            this.searchByDataGridView.RowHeadersWidth = 51;
            this.searchByDataGridView.RowTemplate.Height = 24;
            this.searchByDataGridView.Size = new System.Drawing.Size(634, 221);
            this.searchByDataGridView.TabIndex = 0;
            this.searchByDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchByDataGridView_CellClick);
            // 
            // sortByGenreDataGridView
            // 
            this.sortByGenreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortByGenreDataGridView.Location = new System.Drawing.Point(35, 73);
            this.sortByGenreDataGridView.Name = "sortByGenreDataGridView";
            this.sortByGenreDataGridView.RowHeadersWidth = 51;
            this.sortByGenreDataGridView.RowTemplate.Height = 24;
            this.sortByGenreDataGridView.Size = new System.Drawing.Size(634, 247);
            this.sortByGenreDataGridView.TabIndex = 0;
            this.sortByGenreDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sortByGenreDataGridView_CellClick);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortByGenreComboBox);
            this.sortGroupBox.Controls.Add(this.sortByGenreDataGridView);
            this.sortGroupBox.Controls.Add(this.label1);
            this.sortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupBox.Location = new System.Drawing.Point(496, 28);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(691, 339);
            this.sortGroupBox.TabIndex = 1;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort by Genre";
            // 
            // sortByGenreComboBox
            // 
            this.sortByGenreComboBox.FormattingEnabled = true;
            this.sortByGenreComboBox.Items.AddRange(new object[] {
            "All Genre"});
            this.sortByGenreComboBox.Location = new System.Drawing.Point(436, 20);
            this.sortByGenreComboBox.Name = "sortByGenreComboBox";
            this.sortByGenreComboBox.Size = new System.Drawing.Size(222, 30);
            this.sortByGenreComboBox.TabIndex = 1;
            this.sortByGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByGenreComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.serachByTextBox);
            this.searchGroupBox.Controls.Add(this.searchByDataGridView);
            this.searchGroupBox.Controls.Add(this.searchByComboBox);
            this.searchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.Location = new System.Drawing.Point(496, 384);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(691, 326);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search by";
            // 
            // serachByTextBox
            // 
            this.serachByTextBox.Location = new System.Drawing.Point(338, 29);
            this.serachByTextBox.Name = "serachByTextBox";
            this.serachByTextBox.Size = new System.Drawing.Size(320, 28);
            this.serachByTextBox.TabIndex = 2;
            this.serachByTextBox.TextChanged += new System.EventHandler(this.serachByTextBox_TextChanged);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Title",
            "Author"});
            this.searchByComboBox.Location = new System.Drawing.Point(126, 27);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(178, 30);
            this.searchByComboBox.TabIndex = 1;
            // 
            // manageBooksGroupBox
            // 
            this.manageBooksGroupBox.Controls.Add(this.publishedDateDateTimePicker);
            this.manageBooksGroupBox.Controls.Add(this.deleteButton);
            this.manageBooksGroupBox.Controls.Add(this.updateButton);
            this.manageBooksGroupBox.Controls.Add(this.genreComboBox);
            this.manageBooksGroupBox.Controls.Add(this.addButton);
            this.manageBooksGroupBox.Controls.Add(this.issuedTextBox);
            this.manageBooksGroupBox.Controls.Add(this.editionTextBox);
            this.manageBooksGroupBox.Controls.Add(this.authorTextBox);
            this.manageBooksGroupBox.Controls.Add(this.idTextBox);
            this.manageBooksGroupBox.Controls.Add(this.titleTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label6);
            this.manageBooksGroupBox.Controls.Add(this.label5);
            this.manageBooksGroupBox.Controls.Add(this.label4);
            this.manageBooksGroupBox.Controls.Add(this.label3);
            this.manageBooksGroupBox.Controls.Add(this.label7);
            this.manageBooksGroupBox.Controls.Add(this.label8);
            this.manageBooksGroupBox.Controls.Add(this.label2);
            this.manageBooksGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksGroupBox.Location = new System.Drawing.Point(12, 28);
            this.manageBooksGroupBox.Name = "manageBooksGroupBox";
            this.manageBooksGroupBox.Size = new System.Drawing.Size(439, 682);
            this.manageBooksGroupBox.TabIndex = 3;
            this.manageBooksGroupBox.TabStop = false;
            this.manageBooksGroupBox.Text = "Add / Update / Edit Books";
            // 
            // publishedDateDateTimePicker
            // 
            this.publishedDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.publishedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.publishedDateDateTimePicker.Location = new System.Drawing.Point(163, 352);
            this.publishedDateDateTimePicker.Name = "publishedDateDateTimePicker";
            this.publishedDateDateTimePicker.Size = new System.Drawing.Size(255, 28);
            this.publishedDateDateTimePicker.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(306, 613);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 42);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(163, 613);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 42);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Title",
            "Aurher"});
            this.genreComboBox.Location = new System.Drawing.Point(81, 194);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(337, 30);
            this.genreComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 613);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // issuedTextBox
            // 
            this.issuedTextBox.Location = new System.Drawing.Point(81, 488);
            this.issuedTextBox.Name = "issuedTextBox";
            this.issuedTextBox.Size = new System.Drawing.Size(337, 28);
            this.issuedTextBox.TabIndex = 1;
            // 
            // editionTextBox
            // 
            this.editionTextBox.Location = new System.Drawing.Point(81, 420);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(337, 28);
            this.editionTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(81, 287);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(337, 28);
            this.authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(81, 128);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(337, 28);
            this.titleTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Issued";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Published Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(81, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(337, 28);
            this.idTextBox.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1072, 717);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 35);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 764);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.manageBooksGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.sortGroupBox);
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageBooks_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.searchByDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByGenreDataGridView)).EndInit();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.manageBooksGroupBox.ResumeLayout(false);
            this.manageBooksGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchByDataGridView;
        private System.Windows.Forms.DataGridView sortByGenreDataGridView;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.ComboBox sortByGenreComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox serachByTextBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.GroupBox manageBooksGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DateTimePicker publishedDateDateTimePicker;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox issuedTextBox;
        private System.Windows.Forms.TextBox editionTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backButton;
    }
}