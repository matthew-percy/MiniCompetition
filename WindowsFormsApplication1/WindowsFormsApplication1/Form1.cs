using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Color defaultTextColor;

        public Form1()
        {
            InitializeComponent();
            defaultTextColor = issuerLabel.ForeColor;

            CreditCard AmericanExpress = new CreditCard("American Express", 15, 34, 37);

            CreditCard DinerClubCarte = new CreditCard("Diners Club - Carte Blanche", 14, 300,301,302,303,304,305);
            CreditCard DinerClubInter = new CreditCard("Diners Club - International", 14, 36);
            CreditCard DinerClubUSACAN = new CreditCard("Diners Club - USA & Canada", 16,54);
            CreditCard InstaPayment = new CreditCard("InstaPayment", 16, 637,638,639);

            CreditCard JCB = new CreditCard(16, 3528, 3589, "JCB");
            CreditCard JCB2 = new CreditCard(19, 3528, 3589, "JCB");

            CreditCard Maestro = new CreditCard("Maestro",16,5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763);
            CreditCard Maestro2 = new CreditCard("Maestro", 19, 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763);

            CreditCard MasterCard = new CreditCard("Mastercard", 16, 51, 52, 53, 54, 55);
            CreditCard MasterCard2 = new CreditCard(16,222100,272099,"Mastercard");


            CreditCard Visa4 = new CreditCard("Visa Electron", 16, 4026, 417500, 4508, 4844, 4913, 4917);
            CreditCard Visa = new CreditCard("Visa", 13, 4);
            CreditCard Visa2 = new CreditCard("Visa", 16, 4);
            CreditCard Visa3 = new CreditCard("Visa", 19, 4);
            //MessageBox.Show(Math.Abs(((51 % 10)-10)).ToString());
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            creditCardTxt.Text = string.Empty;

            validateBtn.Enabled = true;
            
            ChangeIssuerText(string.Empty, false);
            creditCardTxt.Enabled = true;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            //copy to clipboard
            
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            CreditCard creditCardType;

            //valid credit card
            if (CreditCard.ValidateCreditCard(creditCardTxt.Text,out creditCardType))
            {
                //ChangeIssuerText("Visa", false);
                ChangeIssuerText(creditCardType.IssuerName, false);
                creditCardTxt.Enabled = false;

                validateBtn.Enabled = false;
                //clearBtn.Enabled = false;

                //Edit the text to be formatted correctly
                //if (creditCardType.length == 14)
                if (creditCardTxt.Text.Length == 13)
                {
                    //creditCardTxt.Text = creditCardTxt.Text.
                }
                if (creditCardTxt.Text.Length == 14)
                {
                    //creditCardTxt.Text = creditCardTxt.Text.
                }
                if (creditCardTxt.Text.Length == 15)
                {
                    //creditCardTxt.Text = creditCardTxt.Text.Insert(1, " ").Insert(4, " ").Insert(9, " ").Insert(13," ");

                }
                if (creditCardTxt.Text.Length == 16)
                {
                    //creditCardTxt.Text = creditCardTxt.Text.Insert(4, " ").Insert(9, " ").Insert(14," ");

                }
                if (creditCardTxt.Text.Length == 19)
                {
                    //creditCardTxt.Text = creditCardTxt.Text.Insert(1, " ").Insert(4, " ").Insert(9, " ").Insert(14," ").Insert(19, " ");
                    //creditCardTxt.Text = creditCardTxt.Text.
                }

            }
            else //invalid credit card
            {
                ChangeIssuerText("Invalid", true);
                //if (creditCardType != null)
                //{
                //    ChangeIssuerText(creditCardType.IssuerName, true);
                //}
                

                //move the focus to the text box and select all
            }


        }

        void ChangeIssuerText(string newText,bool isError)
        {
            issuerLabel.Text = "Issuer: " + newText;
            if (isError) issuerLabel.ForeColor = Color.Red;
            else issuerLabel.ForeColor = defaultTextColor;
        }

        private void creditCardTxt_KeyDown(object sender, KeyEventArgs e)
        {
            string validInputs = "1234567890";

            if (e.KeyCode == Keys.Back) return;

            foreach (char input in validInputs)
            {
                if (e.KeyCode.ToString().Last() == input)
                {
                    return;
                }
            }
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
