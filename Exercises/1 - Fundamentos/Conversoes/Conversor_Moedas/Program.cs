using System.Globalization;

const decimal cotDolar = 5.11m;
const decimal cotEuro = 5.87m;
bool converted = false;

do
{
    Console.WriteLine("Escreva um valor em BRL");
    if (decimal.TryParse(Console.ReadLine(), out decimal valueConverted))
    {
        do
        {
            Console.WriteLine("Qual moeda gostaria de converter?");
            Console.WriteLine("1 - Dolar | 2 - Euro");
            if (int.TryParse(Console.ReadLine(), out int outNumber))
            {
                switch (outNumber)
                {
                    case 1:
                        decimal dolar = valueConverted / cotDolar;
                        Console.WriteLine($"Valor convertido: {dolar.ToString("C", new CultureInfo("en-US"))}");
                        converted = true;
                        break;
                    case 2:
                        decimal euro = valueConverted / cotEuro;
                        Console.WriteLine($"Valor convertido: {euro.ToString("C", new CultureInfo("fr-FR"))}");
                        converted = true;
                        break;
                    default:
                        Console.WriteLine("Erro, Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro, valor invalido!");
            }
        } while (!converted);
    }
    else
    {
        Console.WriteLine("Erro, valor invalido.");
    }
} while (!converted);