// Fatores para calcular Fahrenheit e Kelvin
const double offsetFahrenheit = 32;
const double offsetKelvin = 273.15;
const double fatorFahrenheit = 1.8;

// Receber valor para ser calculado
Console.WriteLine("Escreva uma temperatura em Celsius para ver suas respectivas temperaturas em F e K");
double num = double.Parse(Console.ReadLine()!);

// Formulas
double fahrenheit = num * fatorFahrenheit + offsetFahrenheit;
double kelvin = num + offsetKelvin;

// Exibir valores apos calculo
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
Console.WriteLine($"Kelvin: {kelvin:F2}");