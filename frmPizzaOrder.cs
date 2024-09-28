using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }
        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThinkCrust.Tag);
        }
        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (cbExtraCheese.Checked)
                ToppingsPrice += Convert.ToSingle(cbExtraCheese.Tag);
            if (cbMushrooms.Checked)
                ToppingsPrice += Convert.ToSingle(cbMushrooms.Tag);
            if (cbTomates.Checked)
                ToppingsPrice += Convert.ToSingle(cbTomates.Tag);
            if (cbOlives.Checked)
                ToppingsPrice += Convert.ToSingle(cbOlives.Tag);
            if (cbOnion.Checked)
                ToppingsPrice += Convert.ToSingle(cbOnion.Tag);
            if (cbGreenPeppers.Checked)
                ToppingsPrice += Convert.ToSingle(cbGreenPeppers.Tag);

            return ToppingsPrice;
        }
        float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice()) * (float)numUpDownNbrOfPizza.Value;
        }

        void UpdateTotalPrice()
        {
            lbPrice.Text = CalculateTotalPrice().ToString() + "$";
        }
        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lbSizeChoiced.Text = rbSmall.Text;
            else if (rbLarge.Checked)
                lbSizeChoiced.Text = rbLarge.Text;
            else if(rbMedium.Checked)
                lbSizeChoiced.Text = rbMedium.Text;

        }
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
                lbCrustChoiced.Text = rbThinCrust.Text;
            else
                lbCrustChoiced.Text = rbThinkCrust.Text;
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";
            if (cbExtraCheese.Checked)
                Toppings += cbExtraCheese.Text + ",  ";

            if (cbMushrooms.Checked)
                Toppings += cbMushrooms.Text + ",  ";

            if (cbTomates.Checked)
                Toppings += cbTomates.Text + ",  ";

            if (cbOnion.Checked)
                Toppings += cbOnion.Text + ",  ";

            if (cbOlives.Checked)
                Toppings += cbOlives.Text + ",  ";

            if (cbGreenPeppers.Checked)
                Toppings += cbGreenPeppers.Text + ",  ";

            if (Toppings == "")
            {
                lbToppingChoiced.Text = "No Toppings";
                return;
            }
            if(Toppings.EndsWith(",  "))
            {
                Toppings = Toppings.Substring(0, Toppings.Length - 4);
            }
            lbToppingChoiced.Text = Toppings;
        }
        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lbWhereToEatChoiced.Text = rbEatIn.Text;
            else
                lbWhereToEatChoiced.Text = rbTakeOut.Text;
        }
        void ResetForm()
        {
            btnOrderPizza.Enabled = true;

            gbPizzaSize.Enabled = true;
            gbPizzaCrustType.Enabled = true;
            gbPizzaToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbMedium.Checked = true;

            rbThinCrust.Checked = true;

            rbEatIn.Checked = true;

            cbExtraCheese.Checked = false;
            cbMushrooms.Checked = false;
            cbTomates.Checked = false;
            cbOnion.Checked = false;
            cbOlives.Checked = false;
            cbGreenPeppers.Checked = false;
        }
        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {
            UpdateCrust();
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
           
        }
        private void lbSizeChoiced_Click(object sender, EventArgs e)
        {
            
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void gbPizzaToppings_Enter(object sender, EventArgs e)
        {
            

        }
        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void cbTomates_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                btnOrderPizza.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbPizzaCrustType.Enabled = false;
                gbPizzaToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                MessageBox.Show("Order placed successfully", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void numUpDownNbrOfPizza_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void numUpDownNbrOfPizza_Click(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }
    }
}
