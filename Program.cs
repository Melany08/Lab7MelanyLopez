public enum Temperature
{
    Celsius,
    Fahrenheit,
    Kelvin,
}
public enum Lenght
{
    Inch,
    Feet,
    Yard,
}
public enum Time
{
    Seconds,
    Minutes,
    Hours,
}
public class EnumConversion
{
    public static void Main()
    {

        Console.WriteLine("=============================================================================================================");
        Console.WriteLine("<<<<< MENU TEMPERATURE >>>>>");
        Console.WriteLine("Here are the options:");
        Console.WriteLine("1-Convert Celsius to Fahrenheit and Kelvin.");
        Console.WriteLine("2-Convert Fahrenheit to Celsius and Kelvin.");
        Console.WriteLine("3-Convert Kelvin to Celsius and Fahrenheit.");
        Console.WriteLine("4-Exit.");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Choose an option");

        int opt;
        opt = Convert.ToInt32(Console.ReadLine());
        switch (opt)
        {

            case 1:

                Console.Write("Enter the amount of Celsius: ");
                float celsius = Convert.ToSingle(Console.ReadLine());
                Console.Write(Temperature.Fahrenheit);
                Console.WriteLine(" = {0}", celsius * 18 / 10 + 32);
                Console.Write(Temperature.Kelvin);
                Console.WriteLine(" = {0}", celsius + 273.15);
                break;

            case 2:
                Console.Write("Enter the amount of Fahrenheit: ");
                float Fahrenheit = Convert.ToSingle(Console.ReadLine());
                Console.Write(Temperature.Celsius);
                Console.WriteLine(" = {0}", (Fahrenheit - 32) * 5 / 9);
                Console.Write(Temperature.Kelvin);
                Console.WriteLine(" = {0}", (Fahrenheit - 32) * 5 / 9 + 273.15);
                break;

            case 3:
                Console.Write("Enter the amount of Kelvin: ");
                float Kelvin = Convert.ToSingle(Console.ReadLine());
                Console.Write(Temperature.Celsius);
                Console.WriteLine(" = {0}", Kelvin - 273.15);
                Console.Write(Temperature.Fahrenheit);
                Console.WriteLine(" = {0}", (Kelvin - 273.15) * 9 / 5 + 32);
                break;

            case 4:
                break;

            default:
                Console.WriteLine("Incorrect option");
                break;
        }


        Console.WriteLine("=============================================================================================================");
        Console.WriteLine("<<<<< MENU LENGHT >>>>>");
        Console.WriteLine("Here are the options:");
        Console.WriteLine("1-Convert Inch to Feet and Yard.");
        Console.WriteLine("2-Convert Feet to Inch and Yard.");
        Console.WriteLine("3-Convert Yard to Inch and Feet.");
        Console.WriteLine("4-Exit.");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Choose an option");

        int opti;
        opti = Convert.ToInt32(Console.ReadLine());
        switch (opti)
        {

            case 1:


                Console.Write("Enter the amount of Inches: ");
                float Inch = Convert.ToSingle(Console.ReadLine());
                Console.Write(Lenght.Feet);
                Console.WriteLine(" = {0}", Inch / 12);
                Console.Write(Lenght.Yard);
                Console.WriteLine(" = {0}", Inch / 36);
                break;
            case 2:
                Console.Write("Enter the amount of Feet: ");
                float Feet = Convert.ToSingle(Console.ReadLine());
                Console.Write(Lenght.Inch);
                Console.WriteLine(" = {0}", Feet * 12);
                Console.Write(Lenght.Yard);
                Console.WriteLine(" = {0}", Feet / 3);
                break;
            case 3:

                Console.Write("Enter the amount of Yards: ");
                float Yard = Convert.ToSingle(Console.ReadLine());
                Console.Write(Lenght.Inch);
                Console.WriteLine(" = {0}", Yard * 36);
                Console.Write(Lenght.Feet);
                Console.WriteLine(" = {0}", Yard * 3);
                break;
            case 4:
                break;

            default:
                Console.WriteLine("Incorrect option");
                break;
        }

        Console.WriteLine("=============================================================================================================");
        Console.WriteLine("<<<<< MENU TIME >>>>>");
        Console.WriteLine("Here are the options:");
        Console.WriteLine("1-Convert Seconds to Minutes and Hours.");
        Console.WriteLine("2-Convert Hours to Seconds and Minutes.");
        Console.WriteLine("3-Convert Minutes to Hours and Seconds.");
        Console.WriteLine("4-Exit.");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Choose an option");

        int optio;
        optio = Convert.ToInt32(Console.ReadLine());
        switch (optio)
        {

            case 1:


                Console.Write("Enter the amount of Seconds: ");
                float Second = Convert.ToSingle(Console.ReadLine());
                Console.Write(Time.Hours);
                Console.WriteLine(" = {0}", Second / 3600);
                Console.Write(Time.Minutes);
                Console.WriteLine(" = {0}", Second / 60);
                break;

            case 2:

                Console.Write("Enter the amount of Hours: ");
                float Hours = Convert.ToSingle(Console.ReadLine());
                Console.Write(Time.Seconds);
                Console.WriteLine(" = {0}", Hours * 3600);
                Console.Write(Time.Minutes);
                Console.WriteLine(" = {0}", Hours * 60);

                break;

            case 3:
                Console.Write("Enter the amount of Minutes: ");
                float Minutes = Convert.ToSingle(Console.ReadLine());
                Console.Write(Time.Hours);
                Console.WriteLine(" = {0}", Minutes / 60);
                Console.Write(Time.Seconds);
                Console.WriteLine(" = {0}", Minutes * 60);
                break;

            case 4:
                break;

            default:
                Console.WriteLine("Incorrect option");
                break;
        }

        Console.WriteLine("=============================================================================================================");
    }
}


