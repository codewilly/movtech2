
using movtech.Desktop.Contracts;
using movtech.Desktop.Entities;
using movtech.Desktop.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movtech.Desktop.Forms
{
    public partial class EntranceAndExitForm : Form
    {
        #region Config

        private readonly EntranceAndExitsService _entranceAndExitsService;

        public EntranceAndExitForm()
        {
            InitializeComponent();

            _entranceAndExitsService = new EntranceAndExitsService();                
    

        }
        #endregion


        #region Buttons
        private void buttonClearEntrance_Click(object sender, EventArgs e)
        {
            maskedTextCPFEntrance.Text = "";
           
            maskedTextLicensePlateEntrance.Text = "";
            textKMEntrance.Text = "";
        }

        private void buttonClearExit_Click(object sender, EventArgs e)
        {
           maskedTextCPFExit.Text = "";
           maskedTextLicensePlateExit.Text = "";
        }

        private async void buttonRegisterExit_Click(object sender, EventArgs e)
        {
            var registerTry = await  _entranceAndExitsService.RegisterExit(new RegisterExitRequest(){
                
                LicensePlate = maskedTextLicensePlateExit.Text,
                DriverCPF = maskedTextCPFExit.Text

            });

            if (!registerTry)
            {
                textTeste.Text = "Deu ruim";
            }
            else{
                textTeste.Text = "Deu Certo";
            }
            
            
            
        }

        private async void buttonRegisterEntrance_Click(object sender, EventArgs e)
        {
            var registerTry = await _entranceAndExitsService.RegisterEntrance(new RegisterEntranceRequest()
            {

                LicensePlate = maskedTextLicensePlateEntrance.Text,
                DriverCPF = maskedTextCPFEntrance.Text,
                Quilometers = float.Parse(textKMEntrance.Text) 
                
            });

            if (!registerTry)
            {
                textTeste.Text = "Deu ruim";
            }
            else
            {
                textTeste.Text = "Deu Certo";
            }
            
        }
        #endregion 

        private async void EntranceAndExitForm_Load(object sender, EventArgs e)
        {
            this.dataGridVehicle.DataSource = await _entranceAndExitsService.GetAll();
        }
    }
}
