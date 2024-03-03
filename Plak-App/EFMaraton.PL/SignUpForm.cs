using EFMaraton.BLL.Manager.Concrete;
using EFMaraton.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EFMaraton.PL
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        //string[] specialChars = { "!", ":", "+", "*" };
        string specialChars = "!:+*";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int specialCharCount = txtUserPw.Text.Count(x => specialChars.Contains(x));

            if (txtUserPw.Text == txtUserPwControl.Text && txtUserPw.Text.Length >= 8)
            {
                if (txtUserPw.Text.Count(char.IsUpper) >= 2 && txtUserPw.Text.Count(char.IsLower) >= 3 && specialCharCount >= 2)
                {
                    UserManager userManager = new UserManager();
                    UserModel userModel = new UserModel();
                    userModel.UserName = txtUserName.Text;
                    userModel.Password = txtUserPw.Text;
                    userManager.Add(userModel);
                    MessageBox.Show("Succeed.");
                }

            }
            else
                MessageBox.Show("Password");
        }

       
    }
}
