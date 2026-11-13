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
    public partial class ParentForm : Form
    {
        public int EntityId { get; set; } = -1;
        public ParentForm()
        {
            InitializeComponent();;
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void HideBackButton()
        {
            backButton.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }

        private void ShowUser()
        {
            if (UserSession.User != null)
            {
                fullNameLabel.Text = $"{UserSession.User}";
                roleLabel.Text = UserSession.User.Roles.RoleName.ToString();
            }
            //throw new NotImplementedException();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AuthManager.Login("g");
            FormManager.NavigateTo(new ProductListForm(), this);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            ShowUser();
        }
    }
}
