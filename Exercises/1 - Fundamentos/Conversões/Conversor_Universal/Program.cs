namespace Conversor_Universal;

class Program
{
    public static void Main()
    {
        Menus menu = new Menus(); // Main, Temps, Peso, Distancia
        Helpers helpers = new Helpers();
        bool returnToMenu = false;
        do
        {
            menu.ReturnMenu("Main");
            int opt = helpers.SafeConvertToInt(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Clear();
                    menu.ReturnMenu("Temps");
                    int tempOption = helpers.SafeConvertToInt(Console.ReadLine());

                    switch (tempOption)
                    {
                        case 1: // Celsius -> Fahrenheit
                            helpers.SafeConvertTo("Celsius", "Fahrenheit", "Temps");
                            break;
                        case 2: // Celsius -> Kelvin
                            helpers.SafeConvertTo("Celsius", "Kelvin", "Temps");
                            break;
                        case 3: // Fahrenheit -> Celsius
                            helpers.SafeConvertTo("Fahrenheit", "Celsius", "Temps");
                            break;
                        case 4: // Fahrenheit -> Kelvin
                            helpers.SafeConvertTo("Fahrenheit", "Kelvin", "Temps");
                            break;
                        case 5: // Kelvin -> Celsius
                            helpers.SafeConvertTo("Kelvin", "Celsius", "Temps");
                            break;
                        case 6: // Kelvin -> Fahrenheit
                            helpers.SafeConvertTo("Kelvin", "Fahrenheit", "Temps");
                            break;
                        default:
                            Console.WriteLine("Opcao Invalida.");
                            break;
                    }

                    break;

                case 2:
                    Console.Clear();
                    menu.ReturnMenu("Peso");
                    int pesoOption = helpers.SafeConvertToInt(Console.ReadLine());

                    switch (pesoOption)
                    {
                        case 1: // Gramas -> Kilogramas
                            helpers.SafeConvertTo("Grams", "Kilograms", "Pesos");
                            break;
                        case 2: // Gramas -> Toneladas
                            helpers.SafeConvertTo("Grams", "Tons", "Pesos");
                            break;
                        case 3: // Kilogramas -> Gramas
                            helpers.SafeConvertTo("Kilograms", "Grams", "Pesos");
                            break;
                        case 4: // Kilogramas -> Toneladas
                            helpers.SafeConvertTo("Kilograms", "Tons", "Pesos");
                            break;
                        case 5: // Toneladas -> Gramas
                            helpers.SafeConvertTo("Tons", "Grams", "Pesos");
                            break;
                        case 6: // Toneladas -> Kilogramas
                            helpers.SafeConvertTo("Tons", "Kilograms", "Pesos");
                            break;
                        default:
                            Console.WriteLine("Opcao Invalida.");
                            break;
                    }

                    break;

                case 3:
                    Console.Clear();
                    menu.ReturnMenu("Distancia");
                    int distOption = helpers.SafeConvertToInt(Console.ReadLine());

                    switch (distOption)
                    {
                        case 1: // Metros -> Kilometros
                            helpers.SafeConvertTo("Meters", "Kilometers", "Distances");
                            break;
                        case 2: // Metros -> Milhas
                            helpers.SafeConvertTo("Meters", "Miles", "Distances");
                            break;
                        case 3: // Kilometros -> Metros
                            helpers.SafeConvertTo("Kilometers", "Meters", "Distances");
                            break;
                        case 4: // Kilometros -> Milhas
                            helpers.SafeConvertTo("Kilometers", "Miles", "Distances");
                            break;
                        case 5: // Milhas -> Metros
                            helpers.SafeConvertTo("Miles", "Meters", "Distances");
                            break;
                        case 6: // Milhas -> Kilometros
                            helpers.SafeConvertTo("Miles", "Kilometers", "Distances");
                            break;
                        default:
                            Console.WriteLine("Opcao Invalida.");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("Opcao Invalida.");
                    break;
            }
            
            Console.WriteLine("Gostaria de retornar ao menu e realizar outra conta?");
            Console.WriteLine("1 - sim | 2 - nao");
            
            bool validResponse = false;

            do
            {
                string input =  Console.ReadLine()!;
                
                if (input.Equals("sim", StringComparison.OrdinalIgnoreCase))
                {
                    returnToMenu = true;
                    validResponse = true;
                }
                else if (input.Equals("nao", StringComparison.OrdinalIgnoreCase))
                {
                    returnToMenu = false;
                    validResponse = true;
                }
                else if (int.TryParse(input, out int option))
                {
                    switch (option)
                    {
                        case 1:
                            returnToMenu = true;
                            validResponse = true;
                            break;

                        case 2:
                            returnToMenu = false;
                            validResponse = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            } while (!validResponse);
        } while (returnToMenu);
    }
}