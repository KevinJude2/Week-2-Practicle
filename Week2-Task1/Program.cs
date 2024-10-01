




main();
void main()
{
    PrintMenu();
   



    int num;
    do
    {
        

        Console.WriteLine("Enter a number (greater than 5 to quit): ");
        num = Convert.ToInt32(Console.ReadLine());
        InputOption();
    } 
    while (num < 5 );

    

    Console.WriteLine($"You entered: {num} which quit the program.");

}


static void PrintMenu()
{


    Console.WriteLine("Please enter in a valid option from below: ");
    Console.WriteLine("1. Hello in French? ");
    Console.WriteLine("2. Hello in Spanish? ");
    Console.WriteLine("3. Hello in German? ");
    Console.WriteLine("4. Hello in Italian? ");
    Console.WriteLine("Exit application");

}
void InputOption()
{
    try
    {
        Console.Write("Select your choice (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        GetMessage(choice);
    }
    
    catch (Exception ex)
    {

        Console.WriteLine($"Error:{ex.Message}. Please enter a valid option.");
    }
    finally
    {
       
    }
    
}

void GetMessage (int choice)
{

    

    switch (choice)
    {
        case 0:
            Console.Write("Goodbye");
            break;

        case 1:
            Console.Write("Bonjour");
            break;

        case 2:
            Console.Write("Ola");
            break;

        case 3:
            Console.Write("Hallo");
            break;

        case 4:
            Console.Write("CIao");
            break;

        default:
            Console.Write("Please enter in a valid option");
            break;

    }

}






