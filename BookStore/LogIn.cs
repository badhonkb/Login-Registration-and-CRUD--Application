using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class LogIn : Form
    {
        public bool pass_see = false;
        public bool cursor_on_pass_Box = false;

        private const string conn = "Data Source=DESKTOP-BEUOR2E\\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";
        public LogIn()
        {
            InitializeComponent();
            textBoxUserId.Focus();
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        
        private void LogIn_Load(object sender, EventArgs e)
        {
            labelLogin.BackColor = Color.Transparent;
            labelID.BackColor = Color.Transparent;
            labelPassword.BackColor = Color.Transparent;
           
        }
       
        private void textBoxUserId_Enter(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "Enter your user ID")
            {
                textBoxUserId.Text = "";

                textBoxUserId.ForeColor = Color.Black;
            }
        }

        private void textBoxUserId_Leave(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "")
            {
                textBoxUserId.Text = "Enter your user ID";

                textBoxUserId.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter your Password")
            {
                textBoxPassword.Text = "";

                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
                cursor_on_pass_Box = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Enter your Password";

                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Silver;
                cursor_on_pass_Box = false;
            }
        }

        private bool CheckIfUserIDExists(string userID)
        {
            bool userIDExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();


                    // Query for  Admin
                    string adminQuery = "SELECT * FROM [Admin] WHERE UPPER(User_Id) = UPPER(@UserID)";
                    SqlDataAdapter adminAdapter = new SqlDataAdapter(adminQuery, connection);
                    adminAdapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataTable adminTable = new DataTable();
                    adminAdapter.Fill(adminTable);

                    // Check if  admin exists
                    userIDExists =  (adminTable.Rows.Count > 0);

                    //  display error message
                    if (!userIDExists)
                    {
                        MessageBox.Show("Invalid user ID. Please reenter ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, or throw it further up the call stack.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userIDExists;
        }

        private void iconButtonLogIn_Click(object sender, EventArgs e)
        {
            string userID = textBoxUserId.Text;
            string password = textBoxPassword.Text;

            if (CheckIfUserIDExists(userID))
            {
               
                if (IsAdmin(userID, password))
                {
                    OpenAdminPanel(userID, password);
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid. Please try again.");
            }
        }

      
        private bool IsAdmin(string userID, string password)
        {
            bool isAdmin = false;

            string query = "SELECT * FROM [Admin] WHERE User_Id = @UserID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        isAdmin = true;
                    }
                }
            }

            return isAdmin;
        }

        private void OpenAdminPanel(string userID, string password)
        {
           AdminBook adminHome = new AdminBook();
            adminHome.Show();
            this.Hide();
        }
      
    }
}
