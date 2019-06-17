using System;

namespace NumberSystem
{
   public class ConversionNumberToWords
    {
        public String ConvertNumberToWords(double number)
        {
            string words = "";
            double intPart;

            if (number == 0)
                return "zero";
            try
            {
                //supported only for integer part
                string[] splitter = number.ToString().Split('.');
                intPart = double.Parse(splitter[0]);

            }
            catch
            {
                intPart = number;
            }

            words = ConvertIntPartToWords(intPart);
            return words;
        }

        public String ConvertIntPartToWords(double number) //converts double to words
        {
            string[] numbersArr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensArr = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] suffixesArr = new string[] { "thousand", "million" };
            string words = "";

            bool tens = false;

            if (number < 0)
            {
                words += "negative ";
                number *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (number >= pow)
                {
                    if (number % pow > 0)
                    {
                        words += ConvertIntPartToWords(Math.Floor(number / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                    }
                    else if (number % pow == 0)
                    {
                        words += ConvertIntPartToWords(Math.Floor(number / pow)) + " " + suffixesArr[(power / 3) - 1];
                    }
                    number %= pow;
                }
                power -= 3;
            }
            if (number >= 1000)
            {
                //if (number % 1000 > 0)
                words += ConvertIntPartToWords(Math.Floor(number / 1000)) + " thousand, ";
                //else
                //words += ConvertIntPartToWords(Math.Floor(number / 1000)) + " thousand";
                number %= 1000;
            }
            if (0 <= number && number <= 999)
            {
                if ((int)number / 100 > 0)
                {
                    words += ConvertIntPartToWords(Math.Floor(number / 100)) + " hundred";
                    number %= 100;
                }
                if ((int)number / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)number / 10 - 2];
                    tens = true;
                    number %= 10;
                }

                if (number < 20 && number > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? "-" + numbersArr[(int)number - 1] : numbersArr[(int)number - 1]);
                    number -= Math.Floor(number);
                }
            }

            return words;

        }

    }
}
