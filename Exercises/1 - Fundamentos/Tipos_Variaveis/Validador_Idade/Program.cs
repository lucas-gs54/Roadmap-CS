Console.WriteLine("Qual seu ano de nascimento?");
int birthdayYear = int.Parse(Console.ReadLine()!);
int currentYear = DateTime.Today.Year;

// Calcula a idade do usuário (Comente a outra linha ao testar cada versão)

byte age = checked((byte)(currentYear - birthdayYear));
// byte ageNoChecked = (byte)(currentYear - birthdayYear);

// Exibe a idade do usuário (Sem checked)

// Se o usuário inserir um valor muito grande, como 1200.
// será exibido um valor incorreto porque o resultado ultrapassa o limite do tipo byte (255)
// e não há tratamento para esse estouro.
// Isso é conhecido como: Wraparound (retorno ao início da faixa) ou Silent Overflow (estouro silencioso).

// Console.WriteLine($"Idade: {ageNoChecked}"); // -- Exemplo sem checked

// Exibe a idade do usuário (Com checked)

// Se o usuário inserir um valor muito grande, como 1200
// será lançada uma exceção OverflowException, pois o resultado ultrapassa o limite do tipo byte (255).

Console.WriteLine($"Idade: {age}"); // -- Exemplo com checked