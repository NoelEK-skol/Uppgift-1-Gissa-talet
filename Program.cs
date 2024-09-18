Random random = new Random();
int randomNumber = random.Next(1, 101); //slumpar ett tal mellan 1 och 100
Console.WriteLine("Gissa vilket tal jag tänker på mellan 1 och 100!");
int number;
do
{
    string str = Console.ReadLine();
    number = Convert.ToInt32(str);

    if(number < randomNumber)
    {
        Console.WriteLine("Gissningen är för låg");
    }
    else if(number > randomNumber)
    {
        Console.WriteLine("Gissningen är för hög");
    }
} while (number != randomNumber);
Console.WriteLine("Rätt!");