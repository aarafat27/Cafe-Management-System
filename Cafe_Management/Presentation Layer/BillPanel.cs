using Cafe_Management.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.Presentation_Layer
{
    public partial class BillPanel : Form
    {
        public BillPanel()
        {
            InitializeComponent();
        }
        double total = 0;
        private void receiptButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            if(nameTextBox.Text!="" && phoneNumberTextBox.Text!="")
            {

                CustomerDataAccess customerDataAccess = new CustomerDataAccess();
                customerDataAccess.AddCustomer(nameTextBox.Text, phoneNumberTextBox.Text);

                // rtfReceipt.AppendText(Environment.NewLine);
                rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("\t\t" + "AIUB Cafe" + Environment.NewLine);
                rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("----------------------Quantity-------Price------------" + Environment.NewLine);
                if (NescafeCheckBox.Checked)
                {
                    string t = "Nescafe";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(nescafeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Nescafe -----------------" + nescafeTextBox.Text + "------------" + x + Environment.NewLine);
                }
                if (coldCofeeCheckBox.Checked)
                {
                    string t = "Cold Cofee";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(coldCofeeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Cold Cofee --------------" + coldCofeeTextBox.Text + "------------" + x + Environment.NewLine);
                }
                if (chocolateCofeeCheckBox.Checked)
                {
                    string t = "Chocolate Cofee";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(chocolateCofeeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Chocolate Cofee ------" + chocolateCofeeTextBox.Text + "------------" + x + Environment.NewLine);
                }
                if (coffeeCakeCheckBox.Checked)
                {
                    string t = "Cofee Cake";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(coffeeCakeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Cofee Cake -------------" + coffeeCakeTextBox.Text + "------------" + x + Environment.NewLine);
                }
                if (redValvetCakeCheckBox.Checked)
                {
                    string t = "Red Valbet Cake";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(redValvetCakeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Red Valbet Cake -----" + redValvetCakeTextBox.Text + "------------" + x + Environment.NewLine);
                }
                if (blackForestCakeCheckBox.Checked)
                {
                    string t = "Black Forest";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(blackForestCakeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Black Forest-------------" + blackForestCakeTextBox.Text + "------------" + x + Environment.NewLine);
                }


                if (cheeseCakeCheckBox.Checked)
                {
                    string t = "Cheese Cake";
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    double p = productDataAccess.GetProductsPriceByName(t).Price;

                    double x = (p * Convert.ToInt32(cheeseCakeTextBox.Text));
                    total = total + x;
                    rtfReceipt.AppendText("Cheese Cake-----------" + cheeseCakeTextBox.Text + "------------" + x + Environment.NewLine);
                }


                rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);

                rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Name \t\t\t\t" + nameTextBox.Text + Environment.NewLine);
                rtfReceipt.AppendText("Phone Number \t\t\t" + phoneNumberTextBox.Text + Environment.NewLine);
                rtfReceipt.AppendText("Total Cost \t\t\t" + total + Environment.NewLine);
                rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Please give customer name and phone number");
            }
        }


        private void backButton1_Click(object sender, EventArgs e)
        {
            EmployeePanel employeePanel = new EmployeePanel();
            employeePanel.Show();
            this.Hide();
        }

        private void BillPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nescafeTextBox.Text = "";
            coldCofeeTextBox.Text = "";
            chocolateCofeeTextBox.Text = "";
            redValvetCakeTextBox.Text = "";
            cheeseCakeTextBox.Text = "";
            coffeeCakeTextBox.Text = "";
            blackForestCakeTextBox.Text = "";

            NescafeCheckBox.Checked = false;
            coldCofeeCheckBox.Checked = false;
            chocolateCofeeCheckBox.Checked = false;
            redValvetCakeCheckBox.Checked = false;
            cheeseCakeCheckBox.Checked = false;
            coffeeCakeCheckBox.Checked = false;
            blackForestCakeCheckBox.Checked = false;
            rtfReceipt.Clear();

        }

        
    }
}
