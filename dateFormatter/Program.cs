//Date Formatter Activity Using Switch Case

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Date Formatter***");
        Console.WriteLine("Please enter the Month from 1 to 12: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the Date: ");
        int date = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("January " + date + ", " + year);
                break;
            case 2:
                Console.WriteLine("February " + date + ", " + year);
                break;
            case 3:
                Console.WriteLine("March " + date + ", " + year);
                break;
            case 4:
                Console.WriteLine("April " + date + ", " + year);
                break;
            case 5:
                Console.WriteLine("May " + date + ", " + year);
                break;
            case 6:
                Console.WriteLine("June " + date + ", " + year);
                break;
            case 7:
                Console.WriteLine("July " + date + ", " + year);
                break;
            case 8:
                Console.WriteLine("August " + date + ", " + year);
                break;
            case 9:
                Console.WriteLine("September " + date + ", " + year);
                break;
            case 10:
                Console.WriteLine("October " + date + ", " + year);
                break;
            case 11:
                Console.WriteLine("November " + date + ", " + year);
                break;
            case 12:
                Console.WriteLine("December " + date + ", " + year);
                break;
            default:
                Console.WriteLine("Invalid Month Input");
                break;
        }
    }
}
