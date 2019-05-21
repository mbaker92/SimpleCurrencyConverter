using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> ExchangeRateToEuro;

        public Form1()
        {
            InitializeComponent();
            ExchangeRateToEuro = new Dictionary<string, decimal>(); // Initialize the Dictionary used to store conversion values
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the rates from the internet (no error checking right now)
            LoadRates();

            // Set the selected index to 0 for each list
            FromCurrency.SelectedIndex = 0;
            ToCurrency.SelectedIndex = 0;
        }

        private void LoadRates()
        {
            // Initialize and load XML document from the European Central Bank.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");

            // Notify the User of when the rates were last updated in that XML file
            UpdateLabel.Text = "Rates Updated: " + xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].Attributes["time"].Value;

            // Read each conversion rate from the European Central Bank XML file
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                // Store the Currency and the Conversion Rate to Euros in a dictionary
                ExchangeRateToEuro.Add(node.Attributes["currency"].Value, decimal.Parse(node.Attributes["rate"].Value));

                // Add them to the drop down lists
                FromCurrency.Items.Add(node.Attributes["currency"].Value);
                ToCurrency.Items.Add(node.Attributes["currency"].Value);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Convert From Currency to Euros by doing FROM/Amount and then times that answer by the conversion rate of To Currnecy
            decimal conversionNum = (amount.Value / ExchangeRateToEuro[FromCurrency.Text]) * ExchangeRateToEuro[ToCurrency.Text];

            // Show answer to user
            ConvertValue.Text = amount.Value + " " + FromCurrency.Text + " = " + conversionNum.ToString("0.00") + " " + ToCurrency.Text;
        }

        private void amountLeave(object sender,EventArgs e)
        {
            // Make sure that the NumericUpDown is not empty so the user can't delete the info in the box completely
            if(amount.Text == string.Empty)
            {
                amount.Value = amount.Minimum;
                amount.Text = amount.Value.ToString();
            }
        }

    }
}
