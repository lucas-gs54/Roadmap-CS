bool hasFilledForm = false;
do
{
    Console.WriteLine("Qual o ano de seu nascimento?");
    if (int.TryParse(Console.ReadLine(), out int birthYear) && birthYear >= 1 && birthYear <= DateTime.Now.Year)
    {
        do
        {
            Console.WriteLine("Qual o mes de seu nascimento?");
            if (int.TryParse(Console.ReadLine(), out int birthMonth) && birthMonth is >= 1 and <= 12)
            {
                do
                {
                    int daysInMonth = DateTime.DaysInMonth(birthYear, birthMonth);
                    
                    Console.WriteLine("Qual o dia de seu nascimento?");
                    if (int.TryParse(Console.ReadLine(), out int birthDay) && birthDay >= 1 && birthDay <= daysInMonth)
                    {
                        hasFilledForm = true;
                        DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
                        TimeSpan age = DateTime.Now - birthDate;
                        
                        // Ficha de nascimento
                        
                        Console.WriteLine($"Voce nasceu em: {birthDay}/{birthMonth}/{birthYear}");
                        Console.WriteLine($"Voce viveu {age.Days} dias.");
                        Console.WriteLine($"Isso e aproximadamente {age.Days/365} anos.");
                    }
                    else
                    {
                        Console.WriteLine("Dia de nascimento invalido.");
                    }
                } while (!hasFilledForm);
            }
            else
            {
                Console.WriteLine("Mes de nascimento invalido.");
            }
        } while (!hasFilledForm);
    }
    else
    {
        Console.WriteLine("Ano de nascimento invalido.");
    }
} while (!hasFilledForm);