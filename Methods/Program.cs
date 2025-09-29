/*  Menu choice example
 * 
CreateMenu();

void CreateMenu()
{
    try
    {
        // Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

        // Accept the users choice
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
}

static void SayHello()
{
    Console.WriteLine("Hello, world!");
}

static void AddNumbers()
{
    Console.Write("Enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}

Menu choice example    */


// Rectangle area method

Main();

void Main()
{
    try
    {
        Console.WriteLine("PLease enter rectangle length");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter rectangle width");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calling the method and storing the result
        double area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

// New method declaration called CalculateArea
// Double is the return type
// 'double length' and 'double width' are parameters

static double CalculateArea(double length, double width)
{
    // Method body
    double area = length * width;
    return area; // Returning calculated area
}