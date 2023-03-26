using LibraryProject.Business;
using LibraryProject.Service.Services;
using LibraryProject.Service.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Presentation
{
    public partial class LoginPage : Form
    {
        private UserService userService;
        public LoginPage()
        {
            InitializeComponent();
            userService = Session.UserService;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = userService.GetAllAsync().FirstOrDefault(x => x.Email == EmailBox.Text);
                if (user == null)
                {
                    throw new ArgumentException("Account not found");
                }

                if (user.Username != UsernameBox.Text)
                {
                    throw new ArgumentException("Icorrect Username");
                }
                if (user.Password != PasswordBox.Text)
                {
                    throw new ArgumentException("Icorrect Password");
                }
                
                StatusInfoLabel.Text = "Logged in successfully"; 
            }
            catch(ArgumentException ex)
            {
                StatusInfoLabel.Text = ex.Message;
            }
            
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Text;
            string username = UsernameBox.Text;
            User user = new User(username, email, password, DateTime.Now);
            await userService.CreateAsync(user);
            await userService.UpdateAsync();
            StatusInfoLabel.Text = "Signed Up Successfully";
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
