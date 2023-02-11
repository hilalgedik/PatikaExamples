using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserLoginForm.Business;
using UserLoginForm.DataAccess.EntityFramework;
using UserLoginForm.Entities;

namespace UserLoginForm
{
    public partial class UserLoginForm : DevExpress.XtraEditors.XtraForm
    {
        private bool UserValidated; 
        public UserLoginForm(UserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }

        private UserManager _userManager;


        private void textEdit1_Validated(object sender, EventArgs e)
        {

           //if (_userManager.Get(txtUserName.Text) == null)
           //{
           //    MessageBox.Show("Kullanıcı adı bulunamamaktadır.");

           //}
           //else
           //{
           //    txtPassword.Focus();
           //}
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (_userManager.GetPassword(txtUserName.Text,txtPassword.Text)== null)
            {
                MessageBox.Show("Kullanıcı bilgileriniz doğrulanamadı.");
            }
            else
            {
                UserValidated=true;
            }
           
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (UserValidated==true)
            {
                VotingForm votingForm = new VotingForm(new CategoryManager(new EfCategoryDal(), new Category()));
                votingForm.Show();
            }
        }

        private void txtSignIn_Click(object sender, EventArgs e)
        {
            UserSignInForm signInForm = new UserSignInForm(new UserManager(new EfUserDal()),new User());
            signInForm.Show();
        }
    }
}
