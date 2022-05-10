using System;
using System.Drawing;
using EKAWindowApplication.Properties;
using Logic.Data;
using Logic.Service;

namespace EKAWindowApplication.UI.Form
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserService.IsLoggedIn) 
                UserService.Logout();

            var result = UserService.Login(txtUserName.Text, txtPassword.Text);
            

            switch (result.Status)
            {
                case ResultStatus.Ok:
                    lblResult.ForeColor = Color.DarkGreen;
                    lblResult.Text =
                        $@" Welcome {UserService.Me.FirstName} {UserService.Me.LastName}";
                    Hide();
                    Clear();
                    new Main().ShowDialog();
                    Show();
                    break;
                case ResultStatus.NotFound:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = @"The username/password entered is not valid";
                    break;
                case ResultStatus.AccessFail:
                    lblResult.ForeColor = Color.DarkOrange;
                    lblResult.Text = @"You are not allowed to enter";
                    break;
                default:
                    lblResult.ForeColor = Color.Black;
                    lblResult.Text = @"There was a problem, contact with IT group";
                    break;

            }
        }

        private void Clear()
        {
            lblResult.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
    }

}
