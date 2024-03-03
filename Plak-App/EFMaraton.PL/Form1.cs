using EFMaraton.BLL.Manager.Concrete;
using EFMaraton.BLL.Models;

namespace EFMaraton.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUserName.PlaceholderText = "UserName";
            txtPw.PlaceholderText = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPw.Text))
                {
                    UserModel userModel = new UserModel();
                    UserManager userManager = new UserManager();
                    userModel.UserName = txtUserName.Text;
                    userModel.Password = txtPw.Text;
                    var userLogin = userManager.Search(x => x.UserName == txtUserName.Text && x.Password == userModel.Password);


                    if (userLogin.Count > 0)
                    {

                        //MessageBox.Show($"Welcome back {userManager.Search(x => x.Id == userLogin.FirstOrDefault().Id).FirstOrDefault().UserName}!");
                        MessageBox.Show("basarili");

                        MainForm main = new MainForm();
                        this.Hide();
                        main.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
        }
    }
}
