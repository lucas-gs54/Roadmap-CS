// Declara uma variável no escopo principal (Main)
Console.WriteLine("Escreva sua idade");
int age = int.Parse(Console.ReadLine()!);

if (age >= 10)
{
    // int age = 20; // Se tentarmos fazer isso, ocorrerá um erro,
    // pois a variável 'age' já foi declarada no escopo principal.

    age = 20; // Isso funciona, pois apenas alteramos o valor da variável,
              // sem declará-la novamente.

    int currentYear = DateTime.Now.Year;
    int birthYear = currentYear - age;

    Console.WriteLine($"Ano atual: {currentYear}");
    Console.Write($"Ano de nascimento: {birthYear}\n"); // Exibe 20 anos de idade (considerando o ano de 2026)
}

// currentYear = 20; // Gera um erro, pois 'currentYear' foi declarada
// dentro do escopo do if e não pode ser acessada no escopo principal.

// int currentYear = DateTime.Now.Year; // Isso funciona normalmente.
// A variável declarada dentro do if pertence a outro escopo, então
// ela não entra em conflito com esta declaração.

int actualYear = DateTime.Now.Year;
Console.WriteLine($"Ano atual: {actualYear}");

// Console.WriteLine($"Ano de nascimento: {birthYear}");
// Erro: não é possível acessar 'birthYear' fora do bloco if,
// pois ela existe apenas dentro daquele escopo.