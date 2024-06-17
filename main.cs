using System;


class Program
{




    public static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 21); // Número aleatório entre 1 e 6
        if (randomNumber == 20)
        {
            Console.WriteLine($"{randomNumber}\nEstorou, vintão");
        }
        Console.WriteLine("Número aleatório entre 1 e 20: " + randomNumber);

    }


}