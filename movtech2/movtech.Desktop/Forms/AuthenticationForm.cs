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
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void ButtonSingIn_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "teste" && textPassword.Text == "teste")
            {


                this.Visible = false;

                var main = new MainForm();
                main.Visible = true;
            }
            else if (textLogin.Text.Length == 0 || textPassword.Text.Length == 0)
            {
                labelFail.Text = "Digite seu login e senha";
                labelFail.Visible = true;
            }
            else
            {
                labelFail.Text = "Login ou Senha Incorretos";
                labelFail.Visible = true;
            }



        }

    }
}
