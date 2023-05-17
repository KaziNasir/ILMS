using ILMS.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILMS.Presentation_Layer
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();            
            sortByGenreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            sortByGenreComboBox.SelectedItem = null;
            genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;

            SyncData();
        }

        public Book GetTextBoxToBookObj()
        {
            Book book = new Book();
            if (idTextBox.Text != "")
            {
                book.Id = Convert.ToInt32(idTextBox.Text);
            }            
            book.Title = titleTextBox.Text;
            book.Genre = genreComboBox.Text;
            book.Author = authorTextBox.Text;
            book.PublishedDate = publishedDateDateTimePicker.Text;
            book.Edition = editionTextBox.Text;
            book.Issued = issuedTextBox.Text;

            return book;
        }

        public void SyncData()
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (sortByGenreComboBox.SelectedItem == null)
            {                
                sortByGenreDataGridView.DataSource = bookDataAccess.GetAllBooks();
            }
            else
            {
                GenreDataAccess genreDataAccess = new GenreDataAccess();
                sortByGenreDataGridView.DataSource = bookDataAccess.GetBooksByGenre(genreDataAccess.GetGenreIdByName(sortByGenreComboBox.Text));
            }

            if (searchByComboBox.Text == "Title")
            {
                bookDataAccess = new BookDataAccess();
                searchByDataGridView.DataSource = bookDataAccess.searchBooksByTitle(serachByTextBox.Text);
            }
            else if (searchByComboBox.Text== "Author")
            {
                bookDataAccess = new BookDataAccess();
                searchByDataGridView.DataSource = bookDataAccess.searchBooksByAurthor(serachByTextBox.Text);
            }
            else
            {
                bookDataAccess = new BookDataAccess();
                searchByDataGridView.DataSource = bookDataAccess.GetAllBooks();
            }            
        }

        private void ManageBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
            }
            else if (genreComboBox.Text == null)
            {
                MessageBox.Show("Genre cannot be empty");
            }
            else if (authorTextBox.Text == "")
            {
                MessageBox.Show("Author cannot be empty");
            }
            else if (editionTextBox.Text == "")
            {
                MessageBox.Show("Edition cannot be empty");
            }            
            else if (bookDataAccess.BookExists(GetTextBoxToBookObj()) == true)
            {
                MessageBox.Show("This Book already exists");
            }
            else
            {
                bookDataAccess = new BookDataAccess();
                String flag = bookDataAccess.AddNewBook(GetTextBoxToBookObj());
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
            }
            else if (genreComboBox.Text == null)
            {
                MessageBox.Show("Genre cannot be empty");
            }
            else if (authorTextBox.Text == "")
            {
                MessageBox.Show("Author cannot be empty");
            }
            else if (editionTextBox.Text == "")
            {
                MessageBox.Show("Edition cannot be empty");
            }
            else if (bookDataAccess.BookExists(GetTextBoxToBookObj()) == true)
            {
                MessageBox.Show("This Book already exists");
            }           
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you want to change this Genre?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bookDataAccess = new BookDataAccess();
                    String flag = bookDataAccess.UpdateBook(GetTextBoxToBookObj());
                    MessageBox.Show(flag);
                    SyncData();
                }
            }            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
            }
            else if (genreComboBox.Text == null)
            {
                MessageBox.Show("Genre cannot be empty");
            }
            else if (authorTextBox.Text == "")
            {
                MessageBox.Show("Author cannot be empty");
            }
            else if (editionTextBox.Text == "")
            {
                MessageBox.Show("Edition cannot be empty");
            }
            else if (bookDataAccess.BookExists(GetTextBoxToBookObj()) == false)
            {
                MessageBox.Show("This Book does not exists");
            }
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you want to change this Genre?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bookDataAccess = new BookDataAccess();
                    String flag = bookDataAccess.deleteBook(idTextBox.Text);
                    MessageBox.Show(flag);
                    SyncData();
                }
            }
        }

        private void sortByGenreDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            idTextBox.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            titleTextBox.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            genreComboBox.SelectedItem = genreDataAccess.GetGenreNameById(sortByGenreDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            authorTextBox.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            publishedDateDateTimePicker.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            editionTextBox.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            issuedTextBox.Text = sortByGenreDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void searchByDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            idTextBox.Text= searchByDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            titleTextBox.Text = searchByDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            genreComboBox.SelectedItem = genreDataAccess.GetGenreNameById(searchByDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            authorTextBox.Text = searchByDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            publishedDateDateTimePicker.Text = searchByDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            editionTextBox.Text = searchByDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            issuedTextBox.Text = searchByDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void sortByGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void serachByTextBox_TextChanged(object sender, EventArgs e)
        {
            SyncData();
        }
    }
}
