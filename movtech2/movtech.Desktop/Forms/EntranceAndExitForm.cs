
using movtech.Domain.Entities;
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
            //this.dataGridVehicle.DataSource = 
            GetAllVehicles();


        }
        public async void GetAllVehicles()
        {
            string APIURI = "https://localhost:44310/api/v1/Vehicles";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(APIURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var VehiclesJsonString = await response.Content.ReadAsStringAsync();
                        this.dataGridVehicle.DataSource = JsonConvert.DeserializeObject<Vehicle[]>(VehiclesJsonString).ToList();
                    }
                    else
                    {
                        textTeste.Text = "Fail";
                    }


                }

            }
        }
    }
}
