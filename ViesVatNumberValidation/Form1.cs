using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CheckServices;

namespace ViesVatNumberValidation
{
    public partial class Form1 : Form
    {
        string vatNumber = "";
        string countryCode = "PL";
        string requesterVatNumber = "";
        string requesterCountryCode = "PL";
        string optionLabelText = "You can verify the validity of a VAT number issued by any Member State by selecting that\nMember State from the drop-down menu provided, and entering the number to be validated.";
        XDocument XmlDoc;
        

        public Form1()
        {
            InitializeComponent();
            PopulateComboBox(countryComboBox);
            PopulateComboBox(countryRequesterComboBox);

            vatNumberTextBox.Text = vatNumber.ToString();
            vatNumberRequesterTextBox.Text = vatNumber.ToString();
            countryComboBox.SelectedIndex = 20; // For Poland
            countryRequesterComboBox.SelectedIndex = 20;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Height = 233;
            requestLabel.Text = optionLabelText;
            this.textBoxOutput.Visible = false;
        }

        //
        // Added elements to comboBox  
        //
        private void PopulateComboBox(ComboBox comboBox)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("AT", "Austria");
            dict.Add("BE", "Belgium");
            dict.Add("BG", "Bulgaria");
            dict.Add("CY", "Cyprus");
            dict.Add("CZ", "Czech Republic");
            dict.Add("DE", "Germany");
            dict.Add("DK", "Denmark");
            dict.Add("EE", "Estonia");
            dict.Add("EL", "Greece");
            dict.Add("ES", "Spain");
            dict.Add("FI", "Finland");
            dict.Add("FR", "France");
            dict.Add("GB", "United Kingdom");
            dict.Add("HU", "Hungary");
            dict.Add("IE", "Ireland");
            dict.Add("IT", "Italy");
            dict.Add("LT", "Lithuania");
            dict.Add("LU", "Luxembourg");
            dict.Add("MT", "Malta");
            dict.Add("NL", "The Netherlands");
            dict.Add("PL", "Poland");
            dict.Add("PT", "Portugal");
            dict.Add("RO", "Romania");
            dict.Add("SE", "Sweden");
            dict.Add("SI", "Slovenia");
            dict.Add("SK", "Slovakia");

            comboBox.DataSource = new BindingSource(dict, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryCode = countryLabelShort.Text = countryComboBox.SelectedValue.ToString();
        }

        private void vatNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            vatNumber = vatNumberTextBox.Text;
        }

        private void countryRequesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requesterCountryCode = countryRequesterLabelShort.Text = countryRequesterComboBox.SelectedValue.ToString();
        }

        private void vatNumberRequesterTextBox_TextChanged(object sender, EventArgs e)
        {
            requesterVatNumber = vatNumberRequesterTextBox.Text;
        }

        //
        // checkVat
        //
        private void simpleButton_Click(object sender, EventArgs e)
        {

            requestLabel.Text = optionLabelText;
            this.Height = 233;
            textBoxOutput.Visible = false;
            try
            {
                if (countryComboBox.SelectedItem != null && vatNumberTextBox.Text.Length >= 9)
                {
                    simpleButton.Enabled = false;
                    this.Cursor = Cursors.WaitCursor;
                    VatModel viesVAT = CheckService.getDetails(countryCode, vatNumber);

                    if (viesVAT.Valid)
                    {
                        MessageBox.Show(
                        "VAT Number: " + viesVAT.VatNumber + "\n" + "Member State: " + viesVAT.CountryCode + "\n" + "is " + (viesVAT.Valid == true ? "VALID" : "INVALID") + "\n" +
                                "Name: " + viesVAT.Name + "\n" + "Address: " + viesVAT.Address,
                                "Results from EU VIES VAT Services",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(
                        "The VAT Number: " + viesVAT.VatNumber + "\n" + "Member State: " + viesVAT.CountryCode + " is " + (viesVAT.Valid == true ? "VALID" : "INVALID"),
                                "VAT Number Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Member State or VAT Number is incorect.",
                        "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The service has responded with an error. " + ex.Message,
                    "Service error occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                simpleButton.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        //
        // checkVatApprox
        //
        private void advancedButton_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (countryComboBox.SelectedItem != null &&
                    vatNumberTextBox.Text.Length >= 9 &&
                    countryRequesterComboBox.SelectedItem != null &&
                    vatNumberRequesterTextBox.Text.Length >= 9)
                {
                    advancedButton.Enabled = false;
                    this.Cursor = Cursors.WaitCursor;

                    VatModelApprox viesVAT = CheckService.getDetails(countryCode, vatNumber, requesterCountryCode, requesterVatNumber);

                    if (viesVAT.Valid)
                    {
                        this.Height = 400;
                        textBoxOutput.Text = viesVAT.MakeText();
                    }
                    else
                    {
                        this.Height = 400;
                        textBoxOutput.Text = viesVAT.MakeText();
                        
                    }
                    XmlDoc = viesVAT.MakeXml();
                    textBoxOutput.Visible = true;
                }
                else
                {
                    MessageBox.Show(
                        "Input parameters are incorrect.",
                        "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The service has responded with an error. " + ex.Message,
                    "Service error occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                advancedButton.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = string.Format("XML files (*.xml)|*.xml"),
                RestoreDirectory = true,
                ShowHelp = false,
                CheckFileExists = false
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                XmlDoc.Save(saveFileDialog1.FileName);
        }
    }
}
