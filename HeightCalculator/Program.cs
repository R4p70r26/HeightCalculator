using System.Globalization;

const float oneInch = 2.54F;//in cm
const float oneFoot = 30.48F;

do
{
    Console.WriteLine();
    Console.WriteLine("Enter");
    Console.WriteLine("1) for cm/inches");
    Console.WriteLine("2) for inches/cm");
    Console.WriteLine("ESC to exit");
    Console.Write("=> ");

    ConsoleKeyInfo usrKey = Console.ReadKey();

    if (usrKey.Key == ConsoleKey.D1 || usrKey.Key == ConsoleKey.NumPad1)
    {
        Console.WriteLine();
        Console.Write("Enter height in cm(144.2): ");

        if (float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out float heightCm))
        {
            float feetWhole = heightCm / oneFoot;
            int feet = (int)Math.Truncate(feetWhole);
            float inches = (feetWhole - feet) * 12;

            Console.WriteLine($"{feet}\' {inches:N0}\"");
        } else
        {
            Console.WriteLine("Enter a valid value");
        }


    } else if (usrKey.Key == ConsoleKey.D2 || usrKey.Key == ConsoleKey.NumPad2)
    {
        Console.WriteLine();
        Console.Write("Enter height in feet separate with space(5 7): ");
        string? usrHeightInput = Console.ReadLine();

        if (usrHeightInput != null && usrHeightInput.Contains(' '))
        {
            string[] val = usrHeightInput.Split(' ');
            float.TryParse(val[0], out float feet);
            float.TryParse(val[1], out float inches);

            float calcInches = (feet * 12) + inches;

            Console.WriteLine($"{calcInches * oneInch:N2} cm");
        } else
        {
            Console.WriteLine("Enter a valid value");
        }

    } else if (usrKey.Key == ConsoleKey.Escape)
    {
        Environment.Exit(1);
    } else
    {
        Console.WriteLine("Please enter a valid option or ESC to exit");
    }

} while (true);
