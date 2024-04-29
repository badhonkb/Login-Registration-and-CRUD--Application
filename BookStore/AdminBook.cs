using FontAwesome.Sharp;
using Guna.UI2.Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AdminBook : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=""Book_Store"";Integrated Security=True");
        int ID;
        public AdminBook()
        {
            InitializeComponent();
            DataGridViewShow();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled =false;
        }

      

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void textBoxBookTitle_Enter(object sender, EventArgs e)
        {
            if(textBoxBookTitle.Text == "Enter Book Title ")
            {
                textBoxBookTitle.Text = "";
            }
        }

        private void textBoxBookTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text == "")
            {
                textBoxBookTitle.Text = "Enter Book Title ";
            }
        }

        private void textBoxAuthorName_Enter(object sender, EventArgs e)
        {if(textBoxAuthorName.Text == "Enter Author Name")
            {
                textBoxAuthorName.Text="";
            }

        }

        private void textBoxAuthorName_Leave(object sender, EventArgs e)
        {
            if(textBoxAuthorName.Text =="")
            {
                textBoxAuthorName.Text = "Enter Author Name";
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text == "Enter Book Prize")
            {
                textBoxQuantity.Text = "";
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "")
            {
                textBoxQuantity.Text = "Enter Book Prize";
            }
        }

        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Enter Book Quantity")
            {
                textBoxPrice.Text= "";
            }
        }

        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "Enter Book Quantity";
            }
        }

        private void comboBoxCategory_Enter(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text== "Category")
            {
                comboBoxCategory.Text = "";
            }
        }

        private void comboBoxCategory_Leave(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "")
            {
                comboBoxCategory.Text = "Category";
            }
        }

       

        

       

      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text == "" || textBoxAuthorName.Text == "" || comboBoxCategory.Text == "" || textBoxPrice.Text == "" || textBoxQuantity.Text == "" || textBoxBookTitle.Text == "Enter Book Title " || textBoxAuthorName.Text == "Enter Author Name" || comboBoxCategory.Text == "Category" || textBoxPrice.Text == "Enter Book Quantity" || textBoxQuantity.Text == "Enter Book Prize" )
            {
                MessageBox.Show("Please enter all the data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into [BookInfo]  (Title, Author_Name, Category,  Quantity, Price ) " +
                        "values('" + textBoxBookTitle.Text + "','" + textBoxAuthorName.Text + "','" + comboBoxCategory.Text + "','" + textBoxPrice.Text + "','" + textBoxQuantity.Text + "')", conn);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Book Added Successfully");
                    DataGridViewShow();


                    textBoxBookTitle.Text = "Enter Book Title ";
                    textBoxAuthorName.Text = "Enter Author Name";
                    comboBoxCategory.Text = "Category";
                    textBoxPrice.Text = "Enter Book Price";
                    textBoxQuantity.Text = "Enter Book Quantity";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxBookTitle.Text = "Enter your Name";

            textBoxAuthorName.Text = "Enter Author Name";

            comboBoxCategory.Text = "Category";

            textBoxQuantity.Text = "Enter Book Quantity";
            textBoxPrice.Text = "Enter Book Price";



        }

        private void DataGridViewShow()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [BookInfo]", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridViewBookDetails.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void guna2DataGridViewBookDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxBookTitle.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAuthorName.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxCategory.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPrice.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxQuantity.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            buttonEdit.Enabled=true;
            buttonDelete.Enabled=true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
               
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [BookInfo] SET Title='" + textBoxBookTitle.Text + "',Author_Name='" + textBoxAuthorName.Text + "', Category='" + comboBoxCategory.Text + "', Quantity='" + textBoxPrice.Text + "',  Price='" + textBoxQuantity.Text + "' WHERE Book_ID = '" + ID + "'", conn);

                int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query and get the number of rows affected
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data has been Edited successfully");
                    DataGridViewShow(); // Refresh DataGridView after successful update
                }
                else
                {
                    MessageBox.Show("No records were Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [BookInfo] WHERE Book_ID = '" + ID + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your Record has beem Deleted");
                DataGridViewShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void comboBoxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxFilterCategory.Text;

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [BookInfo] WHERE Category = @Category", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Category", selectedCategory);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    guna2DataGridViewBookDetails.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

    }
}
