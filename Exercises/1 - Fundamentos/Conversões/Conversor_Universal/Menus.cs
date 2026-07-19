namespace Conversor_Universal;

public class Menus
{
    public void ReturnMenu(string menuType)
    {
        switch (menuType)
        {
            case "Main":
                Console.WriteLine("==================================");
                Console.WriteLine("      Conversor Universal v1      ");
                Console.WriteLine("==================================");
                Console.WriteLine("      1 - Temperaturas            ");
                Console.WriteLine("      2 - Peso                    ");
                Console.WriteLine("      3 - Distancia               ");
                Console.WriteLine("==================================");
                break;
            case "Temps":
                Console.WriteLine("========================================");
                Console.WriteLine("              Temperaturas              ");
                Console.WriteLine("=========================================");
                Console.WriteLine("       1 - Celsius -> Fahrenheit         ");
                Console.WriteLine("       2 - Celsius -> Kelvin             ");
                Console.WriteLine("       3 - Fahrenheit -> Celsius         ");
                Console.WriteLine("       4 - Fahrenheit -> Kelvin          ");
                Console.WriteLine("       5 - Kelvin -> Celsius             ");
                Console.WriteLine("       6 - Kelvin -> Fahrenheit         ");
                Console.WriteLine("=========================================");
                break;
            case "Peso":
                Console.WriteLine("========================================");
                Console.WriteLine("                 Pesos                  ");
                Console.WriteLine("========================================");
                Console.WriteLine("       1 - Gramas -> Kilogramas         ");
                Console.WriteLine("       2 - Gramas -> Toneladas          ");
                Console.WriteLine("       3 - Kilogramas -> Gramas         ");
                Console.WriteLine("       4 - Kilogramas -> Toneladas      ");
                Console.WriteLine("       5 - Toneladas -> Gramas          ");
                Console.WriteLine("       6 - Toneladas -> Kilogramas      ");
                Console.WriteLine("========================================");
                break;
            case "Distancia":
                Console.WriteLine("========================================");
                Console.WriteLine("                Distancia               ");
                Console.WriteLine("========================================");
                Console.WriteLine("       1 - Metros -> Kilometros         ");
                Console.WriteLine("       2 - Metros -> Milhas             ");
                Console.WriteLine("       3 - Kilometros -> Metros         ");
                Console.WriteLine("       4 - Kilometros -> Milhas         ");
                Console.WriteLine("       5 - Milhas -> Metros             ");
                Console.WriteLine("       6 - Milhas -> Kilometros         ");
                Console.WriteLine("========================================");
                break;
        }
    }
}