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
    public partial class BookRegister : Form
    {
        public BookRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ContributorModeMain conMain = new ContributorModeMain();
            conMain.Show();
            this.Hide();
        }

        private void registerBookButton_Click(object sender, EventArgs e)
        { 
        }
    }
}
