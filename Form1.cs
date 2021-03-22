using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime departDate = Convert.ToDateTime(txtDepartureDate.Text);
                DateTime arrDate = Convert.ToDateTime(txtArrivalDate.Text);
                int night = (departDate - arrDate).Days;

               
                txtNights.Text = Convert.ToString(night);

              //double total = 0;

                       int nightPrice;
                for(int i = 0; i < night; i++)
                {
                    if(arrDate.AddDays(i).DayOfWeek ==DayOfWeek.Friday || arrDate.AddDays(i).DayOfWeek == DayOfWeek.Saturday)
                    {
                        nightPrice = 150;
                        txtTotalPrice.Text = Convert.ToString(night * nightPrice);
                        txtAvgPrice.Text = Convert.ToString(nightPrice);
                    }
                    else
                    {
                        nightPrice = 150;

                        txtTotalPrice.Text = Convert.ToString(night * nightPrice);
      txtAvgPrice.Text = Convert.ToString(nightPrice);
                    }
                }

            }
            catch
            {
                
            }


        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArrivalDate.Clear();
            txtAvgPrice.Clear();
            txtDepartureDate.Clear();
            txtNights.Clear();
            txtTotalPrice.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtArrivalDate.Text = Convert.ToString(DateTime.Today);
            txtDepartureDate.Text = Convert.ToString(DateTime.Now.AddDays(3));
        }
    }
}