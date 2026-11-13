using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            HideBackButton();
        }

        private void loggingInButton_Click(object sender, EventArgs e)
        {

            try
            {
                AuthManager.Login(usernameTextBox.Text);
                FormManager.NavigateTo(new ProductListForm(), this);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Имя пользователя неверно.", "Имя пользователя неверно.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AuthManager.Login("g");
            FormManager.NavigateTo(new ProductListForm(), this);
        }


    }
}
