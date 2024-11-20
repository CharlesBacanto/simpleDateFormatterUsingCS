//Date Formatter Activity Using Switch Case

using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("**********Date Formatter**********\n");//Header
        //Prompt the user to Enter the needed inputs;
        Console.Write("Please enter the Month from 1 to 12: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the Date: ");
        int date = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (month <= 12) //Validate Months
        {
            if (date <= 31)//Validate Date
            {
                if (year <= 9999)//Validate Year
                {
                    Console.WriteLine("\n");//Create Space
                    Console.WriteLine("Month          : " + month);
                    Console.WriteLine("Date           : " + date);
                    Console.WriteLine("Year           : " + year);
                    Console.WriteLine("\n");//Create Space
                    Console.Write("Formatted Date : ");


                    //Switch Cases for each month
                    switch (month)
                    {
                        case 1:
                            Console.Write("January " + date + ", " + year);
                            break;
                        case 2:
                            Console.Write("February " + date + ", " + year);
                            break;
                        case 3:
                            Console.Write("March " + date + ", " + year);
                            break;
                        case 4:
                            Console.Write("April " + date + ", " + year);
                            break;
                        case 5:
                            Console.Write("May " + date + ", " + year);
                            break;
                        case 6:
                            Console.Write("June " + date + ", " + year);
                            break;
                        case 7:
                            Console.Write("July " + date + ", " + year);
                            break;
                        case 8:
                            Console.Write("August " + date + ", " + year);
                            break;
                        case 9:
                            Console.Write("September " + date + ", " + year);
                            break;
                        case 10:
                            Console.Write("October " + date + ", " + year);
                            break;
                        case 11:
                            Console.Write("November " + date + ", " + year);
                            break;
                        case 12:
                            Console.Write("December " + date + ", " + year);
                            break;
                        default:
                            Console.WriteLine("Invalid Month Input"); // Print out for the invalid month numbers
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Year");//Print out invalid Year
                }
            }
            else
            {
                Console.WriteLine("Invalid Date");//Print out invalid Date
            }
            
        } else
        {
            Console.WriteLine("Invalid Month"); // Print out invalid Month
        }

    }  
}
