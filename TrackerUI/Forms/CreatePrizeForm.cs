using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameValue.Text, PlaceNumberValue.Text, AmountValue.Text, PercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                ResetForm();
            }
        }

        private void ResetForm()
        {
            PlaceNameValue.Clear();
            PlaceNumberValue.Clear();
            AmountValue.Text = "0";
            PercentageValue.Text = "0";
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(AmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PercentageValue.Text, out prizePercentage);
            if (!placeNumberValid)
            {
                MessageBox.Show("Please enter a valid place number. (integer)");
                output = false;
            }

            else if (placeNumber < 1)
            {
                MessageBox.Show("Please enter a place number greater than 0.");
                output = false;
            }

            else if (PlaceNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a place name.");
                output = false;
            }

            else if (!prizeAmountValid || !prizePercentageValid)
            {
                MessageBox.Show("Please enter either a valid prize amount or percentage.");
                output = false;
            }

            else if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                MessageBox.Show("Please enter a prize amount or percentage greater than 0.");
                output = false;
            }

            else if (prizePercentage < 0 || prizePercentage > 100)
            {
                MessageBox.Show("Please enter a prize amount or percentage in between 0 and 100.");
                output = false;
            }

            return output;
        }
    }
}
