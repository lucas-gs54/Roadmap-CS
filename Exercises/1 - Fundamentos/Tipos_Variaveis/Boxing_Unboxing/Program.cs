using System.Collections.Generic

List<object> objectsTypes = [1002789, 10.3287, "Testing"];

Console.WriteLine("Valores em Boxing:");
foreach (var item in objectsTypes)
{
    var itemType = item.GetType();
    Console.WriteLine($"Valor: {item} | Tipo: {itemType}");
}

Console.WriteLine("\nValores após o Unboxing:");
foreach (var item in objectsTypes)
{
    switch (item)
    {
        case int i:
            Console.WriteLine($"Int: {i}");
            break;

        case double d:
            Console.WriteLine($"Double: {d}");
            break;
            
        case string s:
            Console.WriteLine($"String: {s}");
            break;
    }
}