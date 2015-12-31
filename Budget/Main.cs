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
using System.Threading;
using System.Globalization;

namespace BudgetCSV
{
    public partial class Main : Form
    {
        AutoResetEvent waitInput = new AutoResetEvent(false);
        double category1Total, category2Total, category3Total, category4Total;
        double incomeTotal;
        int locationIndex, debitIndex, incomeIndex;
        int minLocationNameLength;

        public Main()
        {
            InitializeComponent();
            category1Total = 0.00;
            category2Total = 0.00;
            category3Total = 0.00;
            category4Total = 0.00;

            incomeTotal = 0.00;

            // default values
            locationIndex = 2;
            debitIndex = 3;
            incomeIndex = 4;

            minLocationNameLength = 4;


            //inputFileTextBox.Text = "C:\\Users\\v-tyhill\\Downloads\\transactions.CSV";
        }

        private void category1Button_Click(object sender, EventArgs e)
        {
            calculateTotals(sender);
        }

        private void category2Button_Click(object sender, EventArgs e)
        {
            calculateTotals(sender);
        }

        private void category3Button_Click(object sender, EventArgs e)
        {
            calculateTotals(sender);
        }

        private void category4Button_Click(object sender, EventArgs e)
        {
            calculateTotals(sender);
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            string inputFile = "";
            DialogResult inputFileResult = openFileDialog1.ShowDialog();
            if (inputFileResult == DialogResult.OK)
            {
                try
                {
                    inputFile = openFileDialog1.FileName;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            inputFileTextBox.Text = inputFile;
            if (isThereInputFile())
                inputFileTextBox.SelectionStart = inputFileTextBox.Text.Length - 1;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isThereInputFile() == false)
                MessageBox.Show("Input File Required.");

            Thread inputProcessingThread = new Thread(readAllLines);
            inputProcessingThread.IsBackground = true;
            inputProcessingThread.Start();

            toggleButtons();
        }



        private void readAllLines()
        {
            string inputFile = inputFileTextBox.Text;
            using (StreamReader reader = new StreamReader(inputFile))
            {
                reader.ReadLine();      // skip first line
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        string[] lineItems = line.Split(',');
                        lineItems[locationIndex] = removeQuotations(lineItems[locationIndex]);
                        lineItems[locationIndex] = getLocationName(lineItems[locationIndex]);
                        
                        lineItems[debitIndex] = removeQuotations(lineItems[debitIndex]);

                        if (lineItems[debitIndex].Length > 0)
                        {
                            updateLineItemDisplay(inputLocationTextBox, lineItems[locationIndex]);
                            updateLineItemDisplay(inputAmountTextBox, lineItems[debitIndex]);
                        }
                        else
                        {
                            updateIncomeTotal(lineItems[incomeIndex]);
                        }
                        waitInput.WaitOne();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            toggleButtons();
            MessageBox.Show("Finished Parsing.");
        }

        private string removeQuotations (string s)
        {
            return s.Trim('\"');
        }

        private string getLocationName(string locationLine)
        {
            char[] letters = locationLine.ToCharArray();
            string locationName = "";
            for (int i = 0; i < letters.Length; i++)
            {
                if (Char.IsDigit(letters[i]))
                {
                    locationName = string.Concat(letters.Take(i));
                    break;
                }
                    
            }
            if (locationName.Length > minLocationNameLength)
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(locationName.ToLower());
            else
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(locationLine.ToLower());
        }

        private void updateIncomeTotal(string amount)
        {
            incomeTotal += Convert.ToDouble(amount);
            if (incomeAmountLabel.InvokeRequired)
            {
                incomeAmountLabel.BeginInvoke((MethodInvoker)delegate () { incomeAmountLabel.Text = "$" + amount; ; });
            }
            else
            {
                incomeAmountLabel.Text = "$" + amount;
            }

            waitInput.Set();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    category1Button.PerformClick();
                    break;
                case '2':
                    category2Button.PerformClick();
                    break;
                case '3':
                    category3Button.PerformClick();
                    break;
                case '4':
                    category4Button.PerformClick();
                    break;
            }
        }

        private void updateLineItemDisplay(TextBox display, string lineItem)
        {
            if (display.InvokeRequired)
            {
                display.BeginInvoke((MethodInvoker)delegate () { display.Text = lineItem; ; });
            }
            else
            {
                display.Text = lineItem;
            }
        }

        private void toggleButtons()
        {
            Button[] toggleButtons = new Button[] { startButton, category1Button, category2Button, category3Button, category4Button };
            foreach (Button b in toggleButtons) {
                if (b.InvokeRequired)
                {
                    b.BeginInvoke((MethodInvoker)delegate () { b.Enabled = !b.Enabled; ; });
                }
                else
                {
                    b.Enabled = !startButton.Enabled;
                }
            }
        }

        private bool isThereInputFile()
        {
            if (inputFileTextBox.Text.Length > 0)
                return true;
            else
                return false;
        }

        private void calculateTotals(object sender)
        {
            if (sender == category1Button)
                category1Total += Convert.ToDouble(inputAmountTextBox.Text);
            if (sender == category2Button)
                category2Total += Convert.ToDouble(inputAmountTextBox.Text);
            if (sender == category3Button)
                category3Total += Convert.ToDouble(inputAmountTextBox.Text);
            if (sender == category4Button)
                category4Total += Convert.ToDouble(inputAmountTextBox.Text);

            updateCategoryTotalsDisplay();
        }

        private void updateCategoryTotalsDisplay()
        {
            category1Label.Text = "$" + category1Total;
            category2Label.Text = "$" + category2Total;
            category3Label.Text = "$" + category3Total;
            category4Label.Text = "$" + category4Total;

            waitInput.Set();
        }
    }
}
