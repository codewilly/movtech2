
using movtech.Desktop.Entities;

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
        
        public EntranceAndExitForm()
        {
            InitializeComponent();
                       
            
            GetAll();



        }
        public async void GetAll()
        {
           
            string APIURI = "https://localhost:44310/api/v1/EntranceAndExits/log";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(APIURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EntranceAndExitsJsonString = await response.Content.ReadAsStringAsync();
                        var listaEntranceAndExit = JsonConvert.DeserializeObject<EntranceAndExit[]>(EntranceAndExitsJsonString).ToList();

                        var listaFormModel = from fields in listaEntranceAndExit
                                             select new 
                                             {
                                                 CreationDate = fields.CreationDate,
                                                 VehicleBrand = fields.Vehicle.Brand,
                                                 DriverName = fields.Driver.Name,
                                                 Description = fields.Description

                                             };
                        this.dataGridVehicle.DataSource = listaFormModel.OrderByDescending(p => p.CreationDate).ToList();


                    }
                    else
                    {
                        return;

                    }


                }

            }
            
        }
      
       

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

       
    }
}
