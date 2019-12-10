using movtech.Desktop.Contracts;
using movtech.Desktop.Entities;
using movtech.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movtech.Desktop.Forms
{
    public partial class AuthenticationForm : Form
    {
        UserService _userService;
        public AuthenticationForm()
        {
            InitializeComponent();

            _userService = new UserService();

        }

        private async void ButtonSingIn_Click(object sender, EventArgs e)
        {
            if (!maskedTextCPFLogin.MaskCompleted  || textPassword.Text.Length == 0)
            {
                labelFail.Text = "Digite seu login e senha";
                labelFail.Visible = true;
            }
            UserLoginRequest _request = new UserLoginRequest()
            {
                CPF = maskedTextCPFLogin.Text,
                Password = textPassword.Text
            };
            User user = await _userService.Login(_request);

            if(user == null)
            {
                labelFail.Text = "Usuário ou Senha incorretos";
                labelFail.Visible = true;
            }
            else
            {
                Form form = new MainForm(user);
                this.Hide();
                form.Visible = true;
            }


           
           
           



        }

    }
}
