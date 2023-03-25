using LibraryProject.Business;
using LibraryProject.Service.Services;
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
            userService = ServiceLocator.GetService<UserService>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            User user = userService.GetAllAsync().FirstOrDefault(x => x.Email == EmailBox.Text);
            if (user != null)
            {
                if (user.Username != UsernameBox.Text)
                {
                    StatusInfoLabel.Text = "Incorrect Username";
                }
                else if (user.Password != PasswordBox.Text)
                {
                    StatusInfoLabel.Text = "Incorrect Password";
                }
                else
                {
                    StatusInfoLabel.Text = "Logged in successfully";
                }
            }
            else
            {
                StatusInfoLabel.Text = "Account not found";
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
