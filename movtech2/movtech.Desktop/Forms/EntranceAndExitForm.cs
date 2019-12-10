
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
            labelStatus.Visible = false;
            labelImage.Visible = false;
        }

        private void buttonClearExit_Click(object sender, EventArgs e)
        {
            
           maskedTextCPFExit.Text = "";
           maskedTextLicensePlateExit.Text = "";
           labelStatus.Visible = false;
           labelImage.Visible = false;
        }

        private async void buttonRegisterExit_Click(object sender, EventArgs e)
        {
            try
            {


                if (!maskedTextCPFExit.MaskCompleted || !maskedTextLicensePlateExit.MaskCompleted)
                {

                    SetStyle("Campos de saída preenchidos incorretamente", Color.Orange);

                    return;
                }

                var registerTry = await _entranceAndExitsService.RegisterExit(new RegisterExitRequest()
                {

                    LicensePlate = maskedTextLicensePlateExit.Text,
                    DriverCPF = maskedTextCPFExit.Text

                });

                if (!registerTry)
                {

                    SetStyle("Não foi possível registrar a saída", Color.Red);


                }
                else
                {
                    SetStyle("Saída registrada com sucesso!", Color.Green);

                }
                this.dataGridVehicle.DataSource = await _entranceAndExitsService.GetAll();
            }
            catch(Exception ex)
            {
                SetStyle(ex.Message, Color.Red);
            }


        }

        private async void buttonRegisterEntrance_Click(object sender, EventArgs e)
        {
            try
            {


                if (!maskedTextLicensePlateEntrance.MaskCompleted || !maskedTextCPFEntrance.MaskCompleted)
                {
                    SetStyle("Campos de entrada preenchidos incorretamente", Color.Orange);

                    return;
                }


                var registerTry = await _entranceAndExitsService.RegisterEntrance(new RegisterEntranceRequest()
                {

                    LicensePlate = maskedTextLicensePlateEntrance.Text,
                    DriverCPF = maskedTextCPFEntrance.Text,
                    Quilometers = float.Parse(textKMEntrance.Text)

                });

                if (!registerTry)
                {

                    SetStyle("Não foi possível registrar a entrada", Color.Red);

                }
                else
                {
                    SetStyle("Entrada registrada com sucesso!", Color.Green);

                }
                this.dataGridVehicle.DataSource = await _entranceAndExitsService.GetAll();
            }
            catch (Exception ex)
            {
                SetStyle("Insira a Quilometragem com apenas Numeros!", Color.Red);
            }


        }
        #endregion



        #region Methods

        private async void EntranceAndExitForm_Load(object sender, EventArgs e)
        {
            var lista = await _entranceAndExitsService.GetAll();
            if(lista.Count < 1 )
            {
                SetStyle("Nenhuma Entrada/Saída registrada", Color.Red);
            }
            this.dataGridVehicle.DataSource = lista;
            
        }

        private void SetStyle(string message, Color errorColor)
        {

            if (errorColor == Color.Orange)
            {

                labelImage.Image = Properties.Resources.warning;



            }
            if (errorColor == Color.Red)
            {

                labelImage.Image = Properties.Resources.cancel;


            }
            if (errorColor == Color.Green)
            {
                labelImage.Image = Properties.Resources.success;

            }
            labelStatus.Text = message;
            labelStatus.ForeColor = errorColor;
            labelStatus.Visible = true;
            labelImage.Visible = true;

        }

        #endregion


    }
}
