namespace Conversor_Universal;
public class Helpers
{
    private readonly string[] _temps = ["Celsius", "Fahrenheit", "Kelvin"];
    private readonly string[] _weights = ["Tons", "Kilograms", "Grams"];
    private readonly string[] _distances = ["Miles", "Kilometers", "Meters"];
    private bool CheckIfExists(string? value, string[] type)
    {
        return type.Contains(value);
    }
    public int SafeConvertToInt(string? value)
    {
        bool returned = false;
        int unitToReturn = 0;
        
        do
        {
            if (int.TryParse(value, out int safeValue) && safeValue > 0)
            {
                unitToReturn = safeValue;
                returned = true;
            }
            else
            {
                value = Console.ReadLine();
            }

        } while (!returned);
        return unitToReturn;
    }

    private double SafeConvertToDouble(string? value)
    {
        bool returned = false;
        double unitToReturn = 0;
        do
        {
            if (double.TryParse(value, out double safeValue) && safeValue > 0)
            {
                unitToReturn = safeValue;
                returned = true;
            }
            else
            {
                value = Console.ReadLine();
            }
        } while (!returned);
        return unitToReturn;
    }

    public double SafeConvertTo(string? unitToConvert, string? unitToBeConverted, string? unitType) // unitType (Temps, Peso Etc)
    {
        double valueConverted = 0;

        switch (unitType)
        {
            
            case "Temps":
                if (CheckIfExists(unitToConvert,_temps) && CheckIfExists(unitToBeConverted,_temps))
                { 
                    Console.WriteLine($"Escreva o valor pra converter {unitToConvert} -> {unitToBeConverted}");
                    double value = SafeConvertToDouble(Console.ReadLine());
                    valueConverted = value.CmConvertToV(unitToConvert, unitToBeConverted);
                    Console.WriteLine($"Valor convertido em {unitToBeConverted}: {valueConverted:F2}");
                }
                break;
            case "Pesos":
                if (CheckIfExists(unitToConvert, _weights) && CheckIfExists(unitToBeConverted, _weights))
                {
                    Console.WriteLine($"Escreva o valor pra converter {unitToConvert} -> {unitToBeConverted}");
                    double value = SafeConvertToDouble(Console.ReadLine());
                    valueConverted = value.CmConvertToV(unitToConvert, unitToBeConverted);
                    Console.WriteLine($"Valor convertido em {unitToBeConverted}: {valueConverted:F2}");
                }
                break;
            case "Distances":
                if (CheckIfExists(unitToConvert, _distances) && CheckIfExists(unitToBeConverted, _distances))
                {
                    Console.WriteLine($"Escreva o valor pra converter {unitToConvert} -> {unitToBeConverted}");
                    double value = SafeConvertToDouble(Console.ReadLine());
                    valueConverted = value.CmConvertToV(unitToConvert, unitToBeConverted);
                    Console.WriteLine($"Valor convertido em {unitToBeConverted}: {valueConverted:F2}");
                }

                break;
        }
        return valueConverted;
    }
}