using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movtech.Desktop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenFormInContainer(new HomeForm());
        }

        // funcoes para podermos "arrastar" a janela pelo painel de cima ( onde esta o hamburguer e os botoes de redimensionamento)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void pictureHamburguer_Click(object sender, EventArgs e)
        {
            if (panelSidebar.Width == 250)
            {
                panelSidebar.Width = 70;
            }
            else
            {
                panelSidebar.Width = 250;
            }

        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // evento que ativa a "arrastada" da janela
        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void OpenFormInContainer(Form sonForm)
        {
            //se tiver algum outro  form dentro do container, esse form é removido
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }



            sonForm.TopLevel = false;
            sonForm.Dock = DockStyle.Fill;

            this.panelContainer.Controls.Add(sonForm);
            this.panelContainer.Tag = sonForm;

            sonForm.Show();



        }



        private void ButtonHome_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new HomeForm());
        }



        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonEntranceAndExit_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new EntranceAndExitForm());
        }
    }
}
