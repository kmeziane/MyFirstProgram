// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrez un nombre inférieur à 100 : ");

// variable
string numberStr = Console.ReadLine();

// conversion
int number = Convert.ToInt32(numberStr);

// Si le nombre est inférieur à 100 et pair
if ((number < 100) && (number % 2 == 0))
{
    int sum = 0;
    Console.WriteLine("Nombre pairs jusqu'à " + number + ": ");
    for (int i = 2; i <= number; i = i + 2)
    {        
        Console.WriteLine(i);
        sum += i;
    }
    Console.WriteLine("Somme = " + sum);
}

// Sinon, on vérifie si le nombre est supérieur ou égal à 100
else if (number >= 100)
{
    Console.WriteLine("Le nombre doit être inférieur à 100");
}

// Sinon le nombre est impair
else 
{
    Console.WriteLine("Le nombre doit être pair");
}

