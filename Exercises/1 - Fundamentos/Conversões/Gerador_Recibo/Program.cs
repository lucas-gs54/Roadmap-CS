using System.Globalization;

DateTime currentDate = DateTime.Now;
bool receiptGenerated = false;

Console.WriteLine("Qual o nome do produto comprado?");
string productName = Console.ReadLine()!;

do
{
    Console.WriteLine("Qual o valor unitario do produto?");
    if (decimal.TryParse(Console.ReadLine(), out decimal unitaryValue) && unitaryValue > 0)
    {
        do
        {
            Console.WriteLine("Quantas unidades foram compradas?");
            if (int.TryParse(Console.ReadLine(), out int totalUnits) && totalUnits > 0)
            {
                decimal totalValue = unitaryValue * totalUnits;

                // Receipt

                Console.WriteLine("\n===================================");
                Console.WriteLine("         RECIBO DE COMPRA          ");
                Console.WriteLine("===================================");
                Console.WriteLine($"Produto: {productName}");
                Console.WriteLine($"Valor Unitario: {unitaryValue.ToString("C", new CultureInfo("pt-BR"))}");
                Console.WriteLine($"Quantidade: {totalUnits}");
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Total: {totalValue.ToString("C", new CultureInfo("pt-BR"))}");
                Console.WriteLine($"Data: {currentDate:dd/MM/yyyy} {currentDate:HH:mm}");
                
                receiptGenerated = true;
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        } while (!receiptGenerated);
    }
    else
    {
        Console.WriteLine("Valor invalido");
    }
} while (!receiptGenerated);