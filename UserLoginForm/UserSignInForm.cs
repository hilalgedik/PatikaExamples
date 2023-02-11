using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering;
using UserLoginForm.Business;
using UserLoginForm.Core;
using UserLoginForm.Entities;

namespace UserLoginForm
{
    public partial class UserSignInForm : DevExpress.XtraEditors.XtraForm
    {
        private UserManager _userManager;
        private User _user;
        public UserSignInForm(UserManager userManager, User user)
        {
            this._userManager = userManager;
            _user = user;
            InitializeComponent();
        }

        private void UserSignInForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        public IDataResult<User> Register()
        {
            
            var user = new User
            {
                Email = txtMail.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
               

            };
            _userManager.Add(user);
            return new SuccessDataResult<User>(user,"Kayıt Alındı." );

        }

        public bool UserExists(string name,string password)
        {
            if (_userManager.GetPassword(name, password) != null)
            {
                //kullanıcı zaten kayıtlı!
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ControlAndSave()
        {
            if (txtUserName.Text!="" && txtPassword.Text!="" && txtMail.Text!="")
            {
                if (UserExists(txtUserName.Text,txtPassword.Text)==false)
                {
                    MessageBox.Show("Kullanıcı zaten kayıtlı!");
                    return false;
                }
                Register();
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtMail.Text = "";
                return true;
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurduğunuzdan emin olun.!");
                return false;
            }
           
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ControlAndSave();
        }
    }
}