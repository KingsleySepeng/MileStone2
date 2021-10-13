using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileStone2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
            FileHandler fh = new FileHandler();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            bool foundUser = fh.getUsers(username, password);
            if (foundUser == true)
            {
                MessageBox.Show("Welcome " + username);
                frmCRUD frm1 = new frmCRUD();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Sorry, the user does not exist");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string addName = txtAddUserName.Text;
            string addPassword = txtAddPassword.Text;
            bool validUser = true;
            foreach (char c in addName)
            {
                if (!char.IsLetter(c))
                {
                    if (c != ' ')
                    {
                        validUser = false;
                    }
                }
            }
            if (addPassword.Length < 8)
            {
                validUser = false;
            }
            if (validUser == true)
            {
                bool existingUser = fh.ifExist(addName, addPassword);
                if (existingUser == true)
                {
                    MessageBox.Show("Sorry, the user already exists");
                }
                else 
                {
                    fh.addUser(addName, addPassword);
                    MessageBox.Show("User details has been successfully added");
                    frmCRUD frm1 = new frmCRUD();
                    frm1.Show();
                }
            }
            else
            {
                MessageBox.Show("Please make sure your password is 8 characters or longer and your name only has letters");
            }
        }
    }
}
