using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class CreditCard
    {
        public static List<CreditCard> allValidCreditCardTypes = new List<CreditCard>();


        int[] startingValues;

        public int length { get; private set; }

        public string IssuerName { get; private set; }

        public CreditCard(string issuerName,int length,params int[] startingValues)
        {
            this.startingValues = startingValues;
            IssuerName = issuerName;

            this.length = length;

            allValidCreditCardTypes.Add(this);
        }
        public CreditCard(int length, int startRange,int endRange, string issuerName)
        {
            //this.startingValues = startingValues;
            //int length = endRange - startRange;

            startingValues = new int[endRange - startRange];


            for (int i = startRange; i < endRange; i++)
            {
                startingValues[i - startRange] = i;
            }

            IssuerName = issuerName;

            this.length = length;

            allValidCreditCardTypes.Add(this);
        }


        //public void AddCreditCardLengths(params int[] length)
        //{
        //    this.length = length;
        //}

        static CreditCard DetermineCreditCardIssuer(string cardNumber)
        {
            foreach (CreditCard cardType in allValidCreditCardTypes)
            {
                foreach (int startValue in cardType.startingValues)
                {
                    //if the start of the card matches the start value of the card type it potentially matches a vendor
                    //turns out i could have used the function "StartsWith" but oh well
                    if (cardNumber.Remove(startValue.ToString().Length).Contains(startValue.ToString()))
                    {

                        if (cardNumber.Length == cardType.length) //length of both cards are the same, therefore the card is this type
                        {
                            //creditCardType = cardType;
                            return cardType;
                            //break;
                        }
                    }



                    /*
                    if (cardNumber.Contains(startValue.ToString())) //contains start value
                    {



                        if (cardNumber.Length == cardType.length) //card mathces a vendor
                        {
                            //creditCardType = cardType;
                            return cardType;
                            //break;
                        }

                    }*/
                }
            }
            return null;
        }


        public static bool ValidateCreditCard(string cardNumber, out CreditCard creditCardType)
        {
            //make sure it is an existing type of credit card


            //creditCardType = new CreditCard("Test",123);
            try
            {

                creditCardType = DetermineCreditCardIssuer(cardNumber);

                if (creditCardType == null)
                    return false;


                //return true;

                //int test = int.Parse(" ");

                //4024007108952119

                char lastDigit = cardNumber.Last();

                //MessageBox.Show(lastDigit.ToString());

                //reverse the sequence

                string InverseCard = "";

                foreach (char digit in cardNumber)
                {
                    InverseCard = digit + InverseCard;
                }
                //MessageBox.Show("Inverse card before:" + InverseCard);
                InverseCard = InverseCard.Remove(0, 1); //reversed card with last digit removed
                                                        //MessageBox.Show("Inverse card after:" + InverseCard);
                                                        //MessageBox.Show(InverseCard);
                List<int> allDigits = new List<int>();

                foreach (char digit in InverseCard)
                {
                    allDigits.Add(int.Parse(digit.ToString()));
                }

                // MessageBox.Show(InverseCard);
                for (int i = 1; i <= allDigits.Count; i++)
                {
                    if (i % 2 != 0) //if it is odd
                    {
                        //MessageBox.Show("Odd number: " + allDigits[i - 1].ToString());
                        allDigits[i - 1] = allDigits[i - 1] * 2; //multiply by 2

                        if (allDigits[i - 1] > 9) allDigits[i - 1] = allDigits[i - 1] - 9; //remove values greater than 9
                                                                                           //MessageBox.Show("Odd number: " + allDigits[i - 1].ToString());
                    }
                }

                int sum = 0;
                foreach (int digit in allDigits)
                {
                    sum += digit;
                }

                //MessageBox.Show(sum.ToString());

                //MessageBox.Show((sum % 10).ToString());

                int theLastDigit = int.Parse(lastDigit.ToString());

                if (theLastDigit == 0)
                {
                    if (sum % 10 == theLastDigit)
                    {
                        return true;
                    }
                }
                else
                {
                    if (Math.Abs(((sum % 10) - 10)) == theLastDigit)
                    {
                        return true;
                    }
                }


                //if(sum % 10 == 


                //if (sum % 10 == int.Parse(lastDigit.ToString()))
                {
                    //MessageBox.Show("valid!");
                    // return true;
                }

                //5446524879266203
                //4556737586899855

                //Visa
                //4024007108952119
                //4556617775265813
                //4532907326248223613
                //379124657771490 --valid

                //VALIDS
                //2221002708219170 
                //379124657771490


                //MessageBox.Show(sum.ToString());



                /*
                MessageBox.Show(InverseCard);
                int i = 1;
                foreach (int digit in allDigits)
                {
                    if (i % 2 != 0) //if the digit is odd
                    {

                        digit = digit * 2;
                        //MessageBox.Show(digit.ToString());
                    }
                    i++;
                }
                */





                return false;
            }
            catch (Exception e)
            {
                creditCardType = null;
                return false;
            }
        }



    }
}
