using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DOTNETPRACTICE
{


    public class NumInWords
    {
        
 string[] ones = new String[] { "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE","TEN" ,"ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
        string[] Tens = new String[] { "", "", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
        string words;
        int value;
        int num;
        public  void numinwords()
        {

            do
            {
                Console.WriteLine("Enter number to print words and -1 to exit");
                num= Int32.Parse(Console.ReadLine());
                words = "";

                while (num > 0)
                {
                    if (num > 0 && num < 20)
                    {
                        // value = num / 10;
                        words += " " + ones[num];
                        break;

                    }
                    else if (num > 20 && num <= 99)
                    {
                        value = num / 10;
                        num = num - value * 10;
                        words += " " + Tens[value] + " ";

                    }
                    else if (num > 99 && num <= 999)
                    {
                        value = num / 100;
                        num = num - value * 100;

                        words += " " + ones[value] + " " + "Hundrade";

                    }
                    else if (num > 19999 && num <= 99999)
                    {
                        value = num / 10000;
                        num = num - value * 10000;
                        words += " " + Tens[value];

                    }

                    else if (num > 999 && num <=99999)
                    {
                        if (num > 19999 && num <=99999)
                        {
                            value = num / 10000;
                            num = num - value * 10000;
                            words += " " + ones[value] + " " + "Thousand";
                        }
                        else
                        {
                            value = num / 1000;
                            num = num - value * 1000;
                            words += " " + ones[value] + " " + "Thousand";
                        }


                    }
                    
                    else if (num > 199999 && num <= 999999)
                    {
                        value = num / 100000;
                        num = num - value * 100000;
                        words += " " + ones[value]+"" + "Laks";

                    }

                    else if (num > 99999 && num <= 999999)
                    {
                        value = num / 100000;
                        num = num - value * 100000;
                        words += " " + ones[value] + " " + "Laks";
                    }
                   

                    else
                    {
                        Console.Write("Enter value less than 1000000");
                        break;
                    }


                }

                Console.WriteLine(words+" Received on Phone Pay Thank You Boss!!\n");
            }while (num!=-1);


        }
    }
}
