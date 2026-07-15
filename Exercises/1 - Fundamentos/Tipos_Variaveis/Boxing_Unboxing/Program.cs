// Requer: using System.Collections.Generic;

// Cria uma lista de objetos contendo valores dos tipos | int | double | string | (Boxing)
List<object> objectsTypes = [1002789, 10.3287, "Testing"];

// Exibe o valor e o tipo de cada objeto.
Console.WriteLine("Valores em Boxing:");
foreach (var item in objectsTypes)
{
    var itemType = item.GetType();
    Console.WriteLine($"Valor: {item} | Tipo: {itemType}");
}

// Percorre cada valor da lista e converte seu tipo original de volta (Unboxing)
Console.WriteLine("\nValores após o Unboxing:");
foreach (var item in objectsTypes)
{
    switch (item)
    {
        // Converte o objeto para int e armazena o valor na variável 'i'
        case int i:
            Console.WriteLine($"Int: {i}");
            break;

        // Converte o objeto para double e armazena o valor na variável 'd'
        case double d:
            Console.WriteLine($"Double: {d}");
            break;

        // Converte o objeto para string e armazena o valor na variável 's'
        case string s:
            Console.WriteLine($"String: {s}");
            break;
    }
}