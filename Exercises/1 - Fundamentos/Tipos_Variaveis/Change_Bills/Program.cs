// Obtém o valor da compra
Console.WriteLine("Qual o valor da compra?");
decimal value = decimal.Parse(Console.ReadLine()!);

// Obtém o valor pago
Console.WriteLine("Qual foi o valor pago?");
decimal paidValue = decimal.Parse(Console.ReadLine()!);

// Calcula o valor do troco
decimal change = paidValue - value;

// Calcula a quantidade de cada cédula necessária
int bill50 = (int)(change / 50); decimal leftOver50 = change % 50;
int bill20 = (int)(leftOver50 / 20); decimal leftOver20 = leftOver50 % 20;
int bill10 = (int)(leftOver20 / 10); decimal leftOver10 = leftOver20 % 10;
int bill5 = (int)(leftOver10 / 5); decimal leftOver5 = leftOver10 % 5;
int bill2 = (int)(leftOver5 / 2); decimal leftOver2 = leftOver5 % 2;
int bill1 = (int)leftOver2;

// Exibe a quantidade de cédulas necessárias
Console.WriteLine("Cédulas Necessárias:");
Console.Write($"50: {bill50} | "); Console.WriteLine($"20: {bill20}");
Console.Write($"10: {bill10} | "); Console.WriteLine($"5 : {bill5}");
Console.Write($"2 : {bill2} | "); Console.WriteLine($"1 : {bill1}");
Console.WriteLine($"Valor do Troco: {change:C}");