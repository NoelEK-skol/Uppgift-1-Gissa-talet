{
    Random random = new Random();
    int randomNumber = random.Next(1, 101); //slumpar ett tal mellan 1 och 100

    Console.WriteLine("Gissa vilket tal jag tänker på mellan 1 och 100!");
    string str = Console.ReadLine();
    int number = Convert.ToInt32(str);

do
    {
        str = Console.ReadLine();

    if(number < randomNumber)
        {
            Console.WriteLine("Gissningen är för låg");
        }
    else if(number > randomNumber)
        {
            Console.WriteLine("Gissningen är för hög");
        }
    }
    while (number == randomNumber);
            Console.WriteLine("Rätt!");
        
        Console.ReadLine();
}