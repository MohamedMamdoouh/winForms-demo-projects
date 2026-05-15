using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club
{
    public partial class frmPoolClub : Form
    {
        public frmPoolClub()
        {
            InitializeComponent();
            ctrlPool1.PlayCompleted += OnPlayCompleted;
            ctrlPool2.PlayCompleted += OnPlayCompleted;
            ctrlPool3.PlayCompleted += OnPlayCompleted;
            ctrlPool4.PlayCompleted += OnPlayCompleted;
            ctrlPool5.PlayCompleted += OnPlayCompleted;
            ctrlPool6.PlayCompleted += OnPlayCompleted;
            ctrlPool7.PlayCompleted += OnPlayCompleted;
            ctrlPool8.PlayCompleted += OnPlayCompleted;
            ctrlPool9.PlayCompleted += OnPlayCompleted;

        }

        private void OnPlayCompleted(object sender, ctrlPool.PlayCompletedEventArgs e)
        {
            MessageBox.Show($"Time Consumed = {e.TimeText}\nTotal Seconds = {e.TotalSeconds} Seconds\n" +
                $"Hourly Rate = {e.HourlyRate}$\nTotal Fees = {e.TotalFees.ToString("F2")}", "Your Overall Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
