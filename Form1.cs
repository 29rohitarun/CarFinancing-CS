using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarFinancing
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> priceDictionary = new Dictionary<string, double>();
        string name;
        string model, car;
        int age, downPayment;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] priceArray;

            StreamReader dataReader = new StreamReader("pricedata.txt");

            // Parses through the text on loop and splits by comma delimeter
            while (dataReader.EndOfStream == false)
            {
                currentLine = dataReader.ReadLine();
                priceArray = currentLine.Split(',');

                // Stores cars and their respective prices in a dictionary using the 
                // car as the key and price as the value
                priceDictionary[priceArray[0]] = double.Parse(priceArray[1]);
            }

            dataReader.Close();

        }

        private void tbCtrlPurchasesMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the "Purchases Made" tab is selected, all of the data ouptutted to purchasesmade.txt
            // is read in to the list box
            try
            {
                if (tbCtrlPurchasesMade.SelectedIndex == 1)
                {
                    StreamReader dataReader = new StreamReader("purchasesmade.txt");
                    string currentLine;

                    lstPurchasesMade.Items.Clear();
                    while (dataReader.EndOfStream == false)
                    {
                        currentLine = dataReader.ReadLine();
                        lstPurchasesMade.Items.Add(currentLine);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No previous purchases made");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields, cmbbox, and radio buttons
            txtAge.Clear();
            txtName.Clear();
            txtDownPayment.Clear();
            lstMonthlyPayments.Items.Clear();
            rdBasic.Checked = false;
            rdHybrid.Checked = false;
            rdSport.Checked = false;
            cmbSelection.SelectedIndex = -1;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            // Input validation for Name, Age, and Down Payment
            if (txtName.Text == "" || txtAge.Text == "" || txtDownPayment.Text == "")
            {
                MessageBox.Show("All fields must be entered");
                return;
            }

            name = txtName.Text;

            bool parsed = int.TryParse(txtAge.Text, out age);

            // Input validation for valid integer input
            if (!parsed)
            {
                MessageBox.Show("Please enter valid age");
                return;
            }

            parsed = int.TryParse(txtDownPayment.Text, out downPayment);

            // Input validation for valid integer input
            if (!parsed)
            {
                MessageBox.Show("Please enter valid down payment amount");
                return;
            }

            // Validating if car is selected
            if (cmbSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a car");
                return;
            }

            car = cmbSelection.SelectedItem.ToString();

            // Store model type in global variable
            if (rdBasic.Checked)
            {
                model = "Basic";
            }
            else if (rdHybrid.Checked)
            {
                model = "Hybrid";
            }
            else if (rdSport.Checked)
            {
                model = "Sport";
            }
            else
            {
                // Input validation that model is selected
                MessageBox.Show("Must select model");
                return;
            }

            // Using StreamWriter for IO operations to text file
            StreamWriter dataWriter = new StreamWriter("purchasesmade.txt", append: true);
            dataWriter.WriteLine(name + ", " + age +
                ", " + car + ", " + model + ", " + downPayment.ToString("C"));

            dataWriter.Close();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // Variable initialization and declaration
            string line;
            int counter = 1;
            double annualInterestRate = .06;
            int loanTermMonths = 60;
            double carPrice = priceDictionary[car];

            // Price calculation for respective models
            if (model == "Hybrid")
            {
                carPrice += .2 * carPrice;
            }
            else if (model == "Sport")
            {
                carPrice += .3 * carPrice;
            }
 
            // Interest Calculation
            double monthlyInterestRate = annualInterestRate / 12;      
            double loanAmount = carPrice - downPayment;
            double monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -loanTermMonths));

            // Loop through monthly payments until the loan amount due is 0
            while (loanAmount - monthlyPayment > 0)
            {
                loanAmount = loanAmount - monthlyPayment;
                line = "Month " + counter.ToString() + ": " + monthlyPayment.ToString("C") + ", Remaining Balance: " + loanAmount.ToString("C");
                counter++;
                lstMonthlyPayments.Items.Add(line);
            }

            // Print out the last payment required to bring the balance to 0
            monthlyPayment = loanAmount;
            loanAmount = 0;
            counter++;
            line = "Month " + counter.ToString() + ": " + monthlyPayment.ToString("C") + ", Remaining Balance: " + loanAmount.ToString("C");
            lstMonthlyPayments.Items.Add(line);
        }
    }
}
