namespace Conversor_Universal;

public static class ConvertMath
{
    public static double CmConvertToV(this double value, string? typeToConvert, string? typeToBeConverted)
    {
        double convertedValue = 0;

        switch (typeToConvert)
        {
            case "Celsius":
                switch (typeToBeConverted)
                {
                    case "Fahrenheit":
                        convertedValue = value * 9 / 5 + 32;
                        break;
                    case "Kelvin":
                        convertedValue = value + 273.15;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Kelvin":
                switch (typeToBeConverted)
                {
                    case "Celsius":
                        convertedValue = value - 273.15;
                        break;
                    case "Fahrenheit":
                        convertedValue = (value - 273.15) * 9 / 5 + 32;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Fahrenheit":
                switch (typeToBeConverted)
                {
                    case "Celsius":
                        convertedValue = (value - 32) * 5 / 9;
                        break;
                    case "Kelvin":
                        convertedValue = (value - 32) * 5 / 9 + 273.15;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Grams":
            {
                switch (typeToBeConverted)
                {
                    case "Kilograms":
                        convertedValue = value / 1000;
                        break;
                    case "Tons":
                        convertedValue = value / 1000000;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
            }
                break;

            case "Kilograms":
            {
                switch (typeToBeConverted)
                {
                    case "Grams":
                        convertedValue = value * 1000;
                        break;
                    case "Tons":
                        convertedValue = value / 1000;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
            }
                break;

            case "Tons":
                switch (typeToBeConverted)
                {
                    case "Grams":
                        convertedValue = value * 1000000;
                        break;
                    case "Kilograms":
                        convertedValue = value * 1000;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Meters":
                switch (typeToBeConverted)
                {
                    case "Kilometers":
                        convertedValue = value / 1000;
                        break;
                    case "Miles":
                        convertedValue = value / 1609.34;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Kilometers":
                switch (typeToBeConverted)
                {
                    case "Meters":
                        convertedValue = value * 1000;
                        break;
                    case "Miles":
                        convertedValue = value / 1.60934;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            case "Miles":
                switch (typeToBeConverted)
                {
                    case "Meters":
                        convertedValue = value * 1609.34;
                        break;
                    case "Kilometers":
                        convertedValue = value * 1.60934;
                        break;
                    default:
                        Console.WriteLine("Erro, Unidade Inexistente");
                        break;
                }
                break;

            default:
                Console.WriteLine("Erro, Unidade Inexistente");
                break;
        }
        return convertedValue;
    }
}