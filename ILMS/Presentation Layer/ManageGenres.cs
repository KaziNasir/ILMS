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
    public partial class ManageGenres : Form
    {
        public ManageGenres()
        {
            InitializeComponent();
            SyncData();
        }

        public void SyncData()
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreDataGridView.DataSource = genreDataAccess.GetAllGenres();
        }

        private void ManageGenres_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            if (addGenreTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (genreDataAccess.GenreExists(addGenreTextBox.Text) == true)
            {
                MessageBox.Show("This Genre already exists");
            }
            else
            {
                genreDataAccess = new GenreDataAccess();
                String flag = genreDataAccess.AddNewGenre(addGenreTextBox.Text);
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void genreDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editIdTextBox.Text = genreDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            editNameTextBox.Text = genreDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            if (editNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (editIdTextBox.Text == "")
            {
                MessageBox.Show("ID cannot be empty");
            }
            else if (genreDataAccess.GenreExists(editNameTextBox.Text) == true)
            {
                MessageBox.Show("This Genre already exists");
            }
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you want to change this Genre?","", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    genreDataAccess = new GenreDataAccess();
                    String flag = genreDataAccess.editGenreName(editIdTextBox.Text, editNameTextBox.Text);
                    MessageBox.Show(flag);
                    SyncData();
                }               
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            if (editNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (editIdTextBox.Text == "")
            {
                MessageBox.Show("ID cannot be empty");
            }
            else if (genreDataAccess.GenreExists(editNameTextBox.Text) == false)
            {
                MessageBox.Show("This Genre does not exists");
            }
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete this Genre?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    genreDataAccess = new GenreDataAccess();
                    String flag = genreDataAccess.deleteGenreName(editIdTextBox.Text);
                    MessageBox.Show(flag);
                    SyncData();
                }
            }
        }
    }
}
