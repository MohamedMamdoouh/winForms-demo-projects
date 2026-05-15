using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateSizePrice()
        {
            if (rbSmall.Checked)
            {
                gbSize.Tag = rbSmall.Tag;
            }

            else if (rbMedium.Checked)
            {
                gbSize.Tag = rbMedium.Tag;
            }

            else if (rbLarge.Checked)
            {
                gbSize.Tag = rbLarge.Tag;
            }

            else
            {
                gbSize.Tag = 0;
            }
        }

        private void UpdateCrustTypePrice()
        {
            if (rbThinCrust.Checked)
            {
                gbCrustType.Tag = rbThinCrust.Tag;
            }

            else if (rbThickCrust.Checked)
            {
                gbCrustType.Tag = rbThickCrust.Tag;
            }

            else
            {
                gbSize.Tag = 0;
            }

        }

        private void UpdateToppongsPrice()
        {
            Single Price = 0;

            if (chkExtraCheese.Checked)
            {
                Price += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                Price += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                Price += Convert.ToSingle(chkTomatoes.Tag);

            }

            if (chkOnion.Checked)
            {
                Price += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                Price += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                Price += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            gbToppings.Tag = Convert.ToString(Price);
        }
        private void UpdateToppings()
        {
            UpdateTotalPrice();

            List<string> Toppings = new List<string>();

            if (chkExtraCheese.Checked)
            {
                Toppings.Add("\nExtra Cheese");
            }

            if (chkMushrooms.Checked)
            {
                Toppings.Add("\nMushrooms");
            }

            if (chkTomatoes.Checked)
            {
                Toppings.Add("\nTomatoes");
            }

            if (chkOnion.Checked)
            {
                Toppings.Add("\nOnion");
            }

            if (chkOlives.Checked)
            {
                Toppings.Add("\nOlives");
            }

            if (chkGreenPeppers.Checked)
            {
                Toppings.Add("\nGreen Peppers");
            }
            label2.Text = Toppings.Count > 0 ? string.Join(",", Toppings) : "No Toppings";
        }

        private void UpdateTotalPrice()
        {
            UpdateSizePrice();
            UpdateCrustTypePrice();
            UpdateToppongsPrice();
            UpdateFinalPrice();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                txtSize.Text = "Small";
            }

            else if (rbMedium.Checked)
            {
                txtSize.Text = "Medium";
            }

            else if (rbLarge.Checked)
            {
                txtSize.Text = "Large";
            }

            else
            {
                txtSize.Text = "";
            }
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThickCrust.Checked)
            {
                txtCrustType.Text = "Thick Crust";
            }

            else if (rbThinCrust.Checked)
            {
                txtCrustType.Text = "Thin Crust";
            }

            else
            {
                txtCrustType.Text = "None";
            }
        }

        private void UpdateWhereToEat()
        {
            if (rdEatIn.Checked)
            {
                txtWhereToEat.Text = "Eat In";
            }

            else if (rdEatOut.Checked)
            {
                txtWhereToEat.Text = "Eat Out";
            }

            else
            {
                txtWhereToEat.Text = "";
            }
        }

        private void DisableAfterConfirmOrder()
        {
            gbSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
            btnOrderPizza.Enabled = false;
        }

        private void UpdateFinalPrice()
        {
            Single Price = 0;
            Price += Convert.ToSingle(gbSize.Tag);
            Price += Convert.ToSingle(gbCrustType.Tag);
            Price += Convert.ToSingle(gbWhereToEat.Tag);
            Price += Convert.ToSingle(gbToppings.Tag);

            txtTotalPrice.Text = Convert.ToString(Price) + "$";
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rdEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void LoadDefaultValues()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            rdEatIn.Checked = true;

            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAfterConfirmOrder();
            }

            else
            {
                MessageBox.Show("Order Cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDefaultValues();

            }
        }

    }
}

