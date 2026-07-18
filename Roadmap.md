# Roadmap C# / .NET 

**Fases:** 0. Ambiente e lógica · 1. Fundamentos de C# · 2. POO · 3. Coleções, erros e arquivos · 4. LINQ, generics e memória · 5. SQL e modelagem · 6. C# intermediário e qualidade · 7. HTTP e ASP.NET Core Web API · 8. Entity Framework Core · 9. Segurança · 10. Arquitetura · 11. Docker, CI/CD e deploy · 12. C# avançado · 13. Preparação para o mercado 🆕

---

## Fase 0 — Ambiente e lógica

**Meta:** conseguir criar, executar, depurar e versionar um programa simples antes de estudar muita sintaxe.

### Aprenda

- [X] O que são .NET, SDK, runtime, CLR, compilação e execução
- [X] Diferença entre C#, .NET e ASP.NET Core
- [X] Instalar o SDK .NET LTS

> 🆕 Nota de atualidade: a LTS atual é o **.NET 10** (lançado em nov/2025, suportado até nov/2028), que já vem com **C# 14**. .NET 8 e 9 saem de suporte em novembro de 2026 — comece direto no .NET 10.

- [X] Visual Studio Community ou VS Code com extensão C#

### Terminal básico

- [X] `dotnet new console`
- [X] `dotnet run`
- [X] `dotnet build`
- [X] `dotnet restore`
- [x] `dotnet test`
- [x] `dotnet add package`

### Estrutura de um projeto

- [X] `.sln` 
- [X] `.csproj`
- [X] `Program.cs` 
- [X] `bin` e `obj`

### Git básico

- [x] `git init`
- [x] `git status`
- [x] `git add`
- [x] `git commit`
- [X] `git log`
- [X] 🆕 `git branch` (criar, listar, trocar de branch)
- [X] 🆕 `git merge` e como resolver um conflito simples
- [X] 🆕 `git clone`
- [X] 🆕 `git remote`, `git push`, `git pull`
- [X] `.gitignore`
- [X] repositório no GitHub

### Lógica de programação

- [x] algoritmo
- [x] entrada, processamento e saída
- [x] fluxograma e pseudocódigo, apenas para entender
- [x] rastrear código "na mão"

### Projeto

Faça um conversor de unidades no terminal: temperatura, peso, distância e moeda fictícia. Ele deve ter menu, validação e opção de repetir operações.

### Só avance quando

- [X] Você cria um projeto pelo terminal.
- [X] Sabe ler os erros mais comuns de compilação.
- [X] Consegue colocar um projeto organizado no GitHub, incluindo pelo menos um branch e um merge. 🆕
- [X] Consegue usar breakpoint, Step Over, Step Into e inspecionar variáveis.

---

## Fase 1 — Fundamentos de C#

**Meta:** criar programas de console sm depender de tutorial.

### Tipos e variáveis

- [X] Tipos numéricos: `byte`, `short`, `int`, `long`
- [X] `float`, `double`, `decimal`
- [X] Quando usar `decimal` para valores monetários
- [x] `bool`, `char`, `string`
- [X] `var` e inferência de tipo
- [X] `object` e boxing/unboxing, apenas noção inicial
- [x] Variáveis, constantes e `readonly`
- [X] Escopo de variáveis
- [X] Convenções de nomes: camelCase, PascalCase, nomes claros e sem abreviações confusas

### Conversões

- [X] Conversão implícita e explícita
- [X] Casting
- [X] `Convert`
- [X] `Parse`
- [X] `TryParse`
- [X] `ToString`
- [X] Cultura e formatação: data, moeda, números decimais
- [X] Por que nunca confiar diretamente em entrada do usuário

### Operadores

- [ ] Aritméticos
- [ ] Atribuição
- [ ] Comparação
- [ ] Lógicos: `&&`, `||`, `!`
- [ ] Incremento e decremento
- [ ] Operador ternário
- [ ] Precedência de operadores
- [ ] Curto-circuito lógico

### Controle de fluxo

- [ ] `if`, `else if`, `else`
- [ ] `switch`
- [ ] switch expression
- [ ] `for`
- [ ] `while`
- [ ] `do while`
- [ ] `foreach`
- [ ] `break`
- [ ] `continue`
- [ ] `return`

### Métodos

- [ ] Assinatura de método
- [ ] Parâmetros e retorno
- [ ] `void`
- [ ] Sobrecarga
- [ ] Parâmetros opcionais e nomeados
- [ ] `ref`, `out` e `in`, primeiro só entenda onde aparecem
- [ ] Separar responsabilidades em métodos pequenos

### Strings e arrays

- [ ] Arrays unidimensionais
- [ ] Matrizes, apenas o básico
- [ ] Índices
- [ ] `Length`
- [ ] Métodos comuns de string: `Contains`, `StartsWith`, `EndsWith`, `Replace`, `Split`, `Trim`, `ToLower`, `ToUpper`
- [ ] Interpolação: `$"Olá, {nome}"`
- [ ] Escape de caracteres
- [ ] Strings são imutáveis

### Enum e datas

- [ ] `enum`
- [ ] `DateTime`
- [ ] `DateOnly`
- [ ] `TimeOnly`
- [ ] `TimeSpan`
- [ ] `Guid`, para identificadores únicos

### Projetos

- Calculadora com histórico em memória
- Sistema de notas com alunos, médias e situação final
- Caixa eletrônico fictício com saldo, depósito, saque e validações

### Só avance quando

Você consegue fazer um CRUD em memória com menu:

- [ ] Criar registro
- [ ] Listar registros
- [ ] Buscar por ID ou nome
- [ ] Atualizar registro
- [ ] Excluir registro
- [ ] Validar entradas sem travar o programa

---

## Fase 2 — Programação orientada a objetos

**Meta:** modelar regras de negócio com objetos, e não escrever tudo dentro do `Program.cs`.

### Fundamentos de POO

- [ ] Classe e objeto
- [ ] Estado e comportamento
- [ ] Atributos/campos
- [ ] Métodos
- [ ] Propriedades: `get`, `set`, `init`, propriedades calculadas
- [ ] Construtores
- [ ] Construtor padrão e parametrizado
- [ ] Sobrecarga de construtores
- [ ] Palavra-chave `this`
- [ ] Modificadores de acesso: `public`, `private`, `protected`, `internal`, `protected internal`

### Encapsulamento

- [ ] Por que não expor campos publicamente
- [ ] Validar dados dentro da entidade
- [ ] Proteger invariantes de negócio
- [ ] Exemplo: saldo não pode ficar negativo; estoque não pode vender quantidade indisponível

### Herança e polimorfismo

- [ ] Classe base e classe derivada
- [ ] `base`
- [ ] `virtual`
- [ ] `override`
- [ ] `sealed`
- [ ] Quando não usar herança
- [ ] Polimorfismo por sobrescrita
- [ ] Polimorfismo por interface

### Abstração e interfaces

- [ ] Classes abstratas
- [ ] Métodos abstratos
- [ ] Interfaces
- [ ] Implementação de múltiplas interfaces
- [ ] Diferença entre interface e classe abstrata
- [ ] Princípio: programe para abstrações quando fizer sentido

### Composição

- [ ] Relação "tem um" versus "é um"
- [ ] Uma Venda possui ItensVenda
- [ ] Um Pedido possui Cliente
- [ ] Prefira composição a herança quando não houver uma relação clara de especialização

### Tipos modernos

- [ ] `record`
- [ ] `record class`
- [ ] `record struct`
- [ ] `struct`
- [ ] `class`
- [ ] Quando usar cada um, sem exagerar
- [ ] `required`
- [ ] `init`
- [ ] Desconstrução básica

### Projeto

Sistema de biblioteca: `Livro`, `Usuario`, `Emprestimo`, `Biblioteca`.

Regras:
- livro não pode ser emprestado se estiver indisponível
- usuário não pode ultrapassar limite de empréstimos
- devolução atualiza disponibilidade
- atraso gera multa calculada por dias

### Só avance quando

Você consegue explicar, com um exemplo próprio:

- [ ] Encapsulamento
- [ ] Herança
- [ ] Abstração
- [ ] Polimorfismo
- [ ] Interface
- [ ] Composição

E consegue aplicar isso sem criar uma hierarquia gigante e confusa.

---

## Fase 3 — Coleções, erros e persistência em arquivos

**Meta:** trabalhar com muitos dados e lidar corretamente com falhas.

### Coleções

- [ ] `Array`
- [ ] `List<T>`
- [ ] `Dictionary<TKey, TValue>`
- [ ] `HashSet<T>`
- [ ] `Queue<T>`
- [ ] `Stack<T>`
- [ ] Quando usar cada uma
- [ ] Diferença entre coleção ordenada, chave-valor e conjunto sem repetição
- [ ] Métodos principais: `Add`, `Remove`, `Contains`, `Find`, `FindAll`, `Exists`, `Sort`

### Exceções

- [ ] O que é uma exceção
- [ ] Diferença entre erro de compilação, erro lógico e exceção em execução
- [ ] `try`
- [ ] `catch`
- [ ] `finally`
- [ ] `throw`
- [ ] `throw new`
- [ ] Capturar exceções específicas
- [ ] Criar exceções próprias, com moderação
- [ ] Não usar exceção como fluxo normal de programa
- [ ] Mensagens úteis para usuário e detalhes úteis em log

> 🆕 A OWASP Top 10:2025 adicionou a categoria "Mishandling of Exceptional Conditions" (tratamento inadequado de exceções) — validação incompleta, "fail open", exceções que vazam detalhes internos. Vale já pensar nisso aqui, mesmo que a parte de segurança formal só venha na Fase 9.

### Arquivos

- [ ] Caminhos e diretórios
- [ ] `File`
- [ ] `Directory`
- [ ] `Path`
- [ ] `File.ReadAllText`
- [ ] `File.WriteAllText`
- [ ] `StreamReader`
- [ ] `StreamWriter`
- [ ] `using`
- [ ] `IDisposable`, introdução
- [ ] CSV básico
- [ ] Tratamento de arquivo inexistente ou corrompido

### JSON

- [ ] `System.Text.Json`
- [ ] Serialização
- [ ] Desserialização
- [ ] Objetos e listas
- [ ] Configurações de serialização
- [ ] Datas e enums em JSON
- [ ] Validação de dados após desserializar

### Projeto

Refaça a biblioteca com JSON:

- [ ] Salve livros, usuários e empréstimos.
- [ ] Carregue tudo ao iniciar.
- [ ] Não deixe o sistema quebrar se o arquivo não existir.
- [ ] Faça backup simples antes de sobrescrever o arquivo.

### Só avance quando

- [ ] Você consegue fechar e abrir o programa sem perder os dados.
- [ ] Consegue tratar um JSON inválido sem encerrar o aplicativo inesperadamente.

---

## Fase 4 — LINQ, generics e memória

**Meta:** manipular coleções de objetos de forma clara e entender os conceitos internos mais importantes.

### LINQ

Aprenda primeiro a sintaxe com métodos; ela é a mais usada no dia a dia:

- [ ] `Where`
- [ ] `Select`
- [ ] `OrderBy`
- [ ] `OrderByDescending`
- [ ] `ThenBy`
- [ ] `First`
- [ ] `FirstOrDefault`
- [ ] `Single`
- [ ] `SingleOrDefault`
- [ ] `Any`
- [ ] `All`
- [ ] `Count`
- [ ] `Sum`
- [ ] `Min`
- [ ] `Max`
- [ ] `Average`
- [ ] `Distinct`
- [ ] `Take`
- [ ] `Skip`
- [ ] `GroupBy`
- [ ] `Join`
- [ ] `SelectMany`
- [ ] `ToList`
- [ ] `ToDictionary`

Também entenda:

- [ ] Expressões lambda: `produto => produto.Ativo`
- [ ] Method syntax e query syntax
- [ ] Execução adiada (deferred execution)
- [ ] Quando uma consulta realmente é executada
- [ ] Perigos de chamar `ToList()` cedo demais ou várias vezes
- [ ] Diferença entre LINQ em memória e LINQ traduzido para SQL

### Generics

- [ ] Por que `List<T>` é melhor que listas sem tipo
- [ ] Criar métodos genéricos
- [ ] Criar classes genéricas
- [ ] Restrições: `where T : class`, `where T : struct`, `where T : new()`, `where T : BaseClass`, `where T : IInterface`

### Nullability

- [ ] `null`
- [ ] Nullable value types: `int?`
- [ ] Nullable reference types
- [ ] Operadores: `?.`, `??`, `??=`, `!` (com cuidado)
- [ ] Como evitar `NullReferenceException`
- [ ] Validação de argumentos

### Memória e desempenho básico

- [ ] Tipos por valor versus referência
- [ ] `struct` versus `class`
- [ ] Stack versus heap, de forma conceitual
- [ ] Garbage Collector
- [ ] Referências compartilhadas
- [ ] Cópia de valor
- [ ] Imutabilidade de string
- [ ] `StringBuilder`
- [ ] Evitar concatenação de strings dentro de loops grandes

> A documentação .NET inclui garbage collection, async, paralelismo e interoperabilidade como tópicos avançados, o que reforça a ideia de aprender primeiro esses fundamentos conceituais antes de otimizações profundas.

### Projeto

Sistema de estoque e relatórios:

- [ ] Cadastro de produtos e categorias
- [ ] Entrada e saída de estoque
- [ ] Filtros por categoria, preço e disponibilidade
- [ ] Ordenação por nome, quantidade e valor
- [ ] Relatório de estoque baixo
- [ ] Ranking de produtos mais movimentados
- [ ] Agrupamento por categoria
- [ ] Exportação de relatório para JSON ou CSV

---

## Fase 5 — SQL e modelagem de banco

**Meta:** persistir dados corretamente em banco relacional.

> Comece esta fase junto com LINQ. Você não precisa esperar dominar LINQ para aprender SQL.

### Modelagem

- [ ] Entidades
- [ ] Atributos
- [ ] Relacionamentos
- [ ] Cardinalidade: 1:1, 1:N, N:N
- [ ] Chave primária
- [ ] Chave estrangeira
- [ ] Chave natural versus chave substituta
- [ ] Diagrama entidade-relacionamento
- [ ] Normalização: primeira, segunda e terceira forma normal
- [ ] Quando desnormalização pode fazer sentido, só mais tarde

### SQL básico

- [ ] Criar banco e tabelas
- [ ] Tipos de dados
- [ ] `CREATE DATABASE`
- [ ] `CREATE TABLE`
- [ ] `ALTER TABLE`
- [ ] `DROP`
- [ ] `INSERT`
- [ ] `SELECT`
- [ ] `UPDATE`
- [ ] `DELETE`
- [ ] `WHERE`
- [ ] `IN`
- [ ] `BETWEEN`
- [ ] `LIKE`
- [ ] `IS NULL`
- [ ] `ORDER BY`
- [ ] Paginação: `OFFSET`, `FETCH`
- [ ] Alias

### Integridade e relacionamentos

- [ ] `PRIMARY KEY`
- [ ] `FOREIGN KEY`
- [ ] `NOT NULL`
- [ ] `UNIQUE`
- [ ] `DEFAULT`
- [ ] `CHECK`
- [ ] `IDENTITY` ou geração de ID conforme o banco
- [ ] `ON DELETE`
- [ ] Cascata e seus riscos

### Consultas intermediárias

- [ ] `INNER JOIN`
- [ ] `LEFT JOIN`
- [ ] `RIGHT JOIN`, saiba ler, mas raramente é necessário
- [ ] `GROUP BY`
- [ ] `HAVING`
- [ ] `COUNT`, `SUM`, `AVG`, `MIN`, `MAX`
- [ ] Subqueries
- [ ] Views, introdução

> Banco escolhido: comece com SQL Server se quiser o caminho mais alinhado às ferramentas Microsoft. PostgreSQL também é excelente e muito usado em produção; escolha um primeiro e aprenda o outro depois.

### Índices e transações

- [ ] O que é índice
- [ ] Quando um índice ajuda e quando pode prejudicar escrita
- [ ] Índice em chave primária
- [ ] Índices em colunas de busca frequente
- [ ] `BEGIN TRANSACTION`
- [ ] `COMMIT`
- [ ] `ROLLBACK`
- [ ] Atomicidade
- [ ] Concorrência, conceito inicial

### Projeto

Migre o estoque para o banco:

- [ ] Tabelas Produtos, Categorias e MovimentacoesEstoque
- [ ] Constraints que impeçam dados inválidos
- [ ] Consultas de relatórios com JOIN e GROUP BY
- [ ] Operação de saída que use transação e não permita estoque negativo

### Só avance quando

- [ ] Você consegue desenhar o modelo antes de criar as tabelas.
- [ ] Escreve consultas com JOIN, filtros, agrupamento e paginação sem depender do ORM.

---

## Fase 6 — C# intermediário e qualidade

**Meta:** escrever código mais robusto, testável e preparado para I/O antes de entrar forte em web.

### Assincronia

- [ ] O que é I/O
- [ ] Diferença entre código síncrono e assíncrono
- [ ] `Task`
- [ ] `Task<T>`
- [ ] `async`
- [ ] `await`
- [ ] `CancellationToken`
- [ ] Tratamento de erro em métodos assíncronos
- [ ] Quando usar `Task.WhenAll`
- [ ] Por que não usar `.Result` e `.Wait()` em código assíncrono comum
- [ ] Quando não usar `async` apenas por moda
- [ ] `ValueTask`, somente entendimento inicial

> No EF Core, operações assíncronas evitam bloquear uma thread durante I/O; o mesmo `DbContext` não deve executar operações paralelas simultâneas, então normalmente se deve aguardar cada operação com `await`.

### Delegates, eventos e callbacks

- [ ] Delegates
- [ ] `Action`
- [ ] `Func`
- [ ] `Predicate`
- [ ] Eventos
- [ ] `EventHandler`
- [ ] Event args
- [ ] Onde eventos fazem sentido
- [ ] Relação entre delegates, lambdas e LINQ

### Recursos e descarte

- [ ] `IDisposable`
- [ ] `using`
- [ ] `await using`
- [ ] Recursos gerenciados e não gerenciados
- [ ] Arquivos, conexões e streams
- [ ] Por que o Garbage Collector não substitui descarte determinístico de recursos externos

### Organização de código

- [ ] Namespaces
- [ ] Pastas por responsabilidade
- [ ] Separar domínio, serviços, repositórios e infraestrutura
- [ ] Evitar classes "Deus"
- [ ] Evitar métodos enormes
- [ ] Guard clauses
- [ ] Retornos antecipados
- [ ] Exceções versus resultados de negócio
- [ ] `Result<T>` como conceito, sem criar abstração exagerada cedo

### Qualidade de código automatizada 🆕

- [ ] `.editorconfig` para padronizar estilo entre editores
- [ ] Analisadores Roslyn nativos (avisos de nulidade, código morto, etc.)
- [ ] StyleCop.Analyzers, opcional
- [ ] `dotnet format`, pra formatar antes de commitar
- [ ] SonarQube ou SonarCloud, introdução — rodar uma análise em cima de um dos seus projetos e ver o que ele aponta

### Pacotes

- [ ] NuGet
- [ ] Dependências diretas e transitivas
- [ ] Versões de pacote
- [ ] Restaurar pacotes
- [ ] Atualizar com cuidado
- [ ] Ler README e documentação do pacote antes de instalar
- [ ] Evitar pacote para algo que a BCL já resolve

### Testes

- [ ] O que testar
- [ ] O que não testar
- [ ] Arrange, Act, Assert
- [ ] xUnit, NUnit ou MSTest — escolha um, sugiro xUnit
- [ ] Testes unitários
- [ ] Fakes, mocks e stubs
- [ ] Moq ou NSubstitute, depois do básico
- [ ] Testes parametrizados
- [ ] Cobertura de código como sinal, não objetivo
- [ ] Nome de teste claro: `Deve_LancarExcecao_Quando_EstoqueForInsuficiente`
- [ ] 🆕 Introdução a testes end-to-end (Playwright para .NET, ou uma coleção do Postman/Newman rodando em pipeline)
- [ ] 🆕 Introdução a teste de carga (k6 ou NBomber, que é nativo em .NET)
- [ ] 🆕 Mutation testing como conceito (Stryker.NET), opcional — serve pra medir se seus testes realmente pegam bugs, não só cobertura de linha

### Projeto

Adicione testes ao sistema de estoque:

- [ ] Não permitir quantidade negativa
- [ ] Não permitir saída acima do estoque
- [ ] Calcular valor de estoque corretamente
- [ ] Não aceitar nome de produto vazio
- [ ] Testar filtros e relatórios relevantes

---

## Fase 7 — HTTP e ASP.NET Core Web API

**Meta:** criar uma API HTTP bem estruturada que frontend, aplicativo mobile ou outro serviço possa consumir.

### Fundamentos web

- [ ] Cliente e servidor
- [ ] HTTP e HTTPS
- [ ] Request e response
- [ ] Headers
- [ ] Body
- [ ] JSON
- [ ] REST como estilo arquitetural
- [ ] Idempotência
- [ ] Stateless
- [ ] URL, rota, query string e path parameter
- [ ] Cookies, noção inicial
- [ ] Códigos HTTP mais importantes: 200, 201, 204, 400, 401, 403, 404, 409, 422, 500

### Criação da API

- [ ] Criar projeto Web API
- [ ] `Program.cs`
- [ ] Controllers
- [ ] Minimal APIs, saiba reconhecer e fazer um projeto pequeno; foque primeiro em controllers
- [ ] Rotas
- [ ] Route parameters
- [ ] Query parameters
- [ ] Body
- [ ] Model binding
- [ ] `IActionResult`
- [ ] `ActionResult<T>`
- [ ] `CreatedAtAction`
- [ ] DTOs de entrada e saída
- [ ] Por que nunca retornar diretamente entidades de banco em toda situação

### Versionamento de API 🆕

- [ ] Por que versionar uma API pública
- [ ] Versionamento por URL (`/api/v1/...`)
- [ ] Versionamento por header
- [ ] Pacote `Asp.Versioning`, introdução

### Injeção de dependência

- [ ] O que é DI
- [ ] Container nativo do ASP.NET Core
- [ ] Lifetimes: Transient, Scoped, Singleton
- [ ] Por que `DbContext` costuma ser Scoped
- [ ] Registrar serviços e interfaces
- [ ] Evitar Service Locator

### Configuração

- [ ] `appsettings.json`
- [ ] `appsettings.Development.json`
- [ ] Variáveis de ambiente
- [ ] Options pattern
- [ ] `IOptions<T>`
- [ ] Connection strings
- [ ] Nunca commitar senhas e tokens

### Pipeline e middleware

- [ ] Ordem do pipeline
- [ ] Middleware
- [ ] Middleware próprio
- [ ] Tratamento global de erros
- [ ] CORS
- [ ] Autenticação
- [ ] Autorização
- [ ] Exception handler
- [ ] Rate limiting — 🆕 conheça o middleware nativo (`Microsoft.AspNetCore.RateLimiting`, disponível desde .NET 7) antes de sair procurando pacote de terceiro
- [ ] Health checks, introdução

### Validação e documentação

- [ ] Data annotations
- [ ] FluentValidation, após entender validação nativa
- [ ] Mensagens de validação claras
- [ ] Swagger/OpenAPI
- [ ] Documentar endpoints, respostas e autenticação
- [ ] Testar a API pelo Swagger, Postman ou Bruno

### Observabilidade

- [ ] Logging com `ILogger`
- [ ] 🆕 Serilog como biblioteca de log estruturado (a mais usada no ecossistema .NET hoje)
- [ ] Níveis de log
- [ ] Log estruturado
- [ ] 🆕 Destino dos logs: Seq (mais simples pra começar) ou Grafana + Prometheus / stack ELK, introdução
- [ ] Correlation ID, introdução
- [ ] Não registrar senha, token ou dados sensíveis
- [ ] Tratar exceções globalmente sem vazar detalhes internos ao cliente

### Projeto

API de tarefas:

- [ ] Usuários
- [ ] Categorias
- [ ] Tarefas
- [ ] CRUD completo
- [ ] Filtros por status, categoria e período
- [ ] Paginação e ordenação
- [ ] Validações
- [ ] Logs
- [ ] Swagger organizado
- [ ] Tratamento global de erro com respostas padronizadas

---

## Fase 8 — Entity Framework Core

**Meta:** persistir sua API no banco sem misturar SQL, regras de negócio e código HTTP.

> O EF Core é um ORM para .NET que oferece consultas LINQ, rastreamento de alterações, atualizações e migrations, com suporte a vários bancos, como SQL Server, PostgreSQL, SQLite e MySQL.
> 🆕 Novidade de versão: o EF Core 10 (que acompanha o .NET 10) passou a ter suporte nativo a busca vetorial/embeddings, o que elimina a necessidade de um banco vetorial dedicado em vários cenários — só fica como curiosidade por agora, não é pré-requisito, mas relevante se um dia você for encostar em busca semântica/IA.

### Base do EF Core

- [ ] ORM: benefícios e limites
- [ ] Pacotes do provider escolhido
- [ ] `DbContext`
- [ ] `DbSet<T>`
- [ ] Entidades
- [ ] Connection strings
- [ ] Configuração no container de DI
- [ ] Migrations: criar, aplicar, remover com cuidado
- [ ] Diferença entre banco local, desenvolvimento, homologação e produção
- [ ] Seed de dados para desenvolvimento

### Mapeamento

- [ ] Convenções
- [ ] Fluent API
- [ ] Data annotations
- [ ] Chave primária
- [ ] Chaves compostas
- [ ] Campos obrigatórios
- [ ] Tamanho máximo
- [ ] Índices
- [ ] Valores padrão
- [ ] Precisão decimal
- [ ] Conversores de valor
- [ ] Enum no banco
- [ ] Colunas de auditoria: criação, atualização, usuário responsável (quando aplicável)

### Relacionamentos

- [ ] 1:1, 1:N, N:N
- [ ] Entidade de junção quando há atributos extras
- [ ] Navegações
- [ ] `Include`
- [ ] `ThenInclude`
- [ ] Carregamento eager, explícito e lazy
- [ ] Problema N+1
- [ ] `AsNoTracking`
- [ ] Projeção com `Select`

### Consultas eficientes

- [ ] `IQueryable` versus `IEnumerable`
- [ ] Não trazer tabela inteira sem necessidade
- [ ] Filtrar e projetar no banco
- [ ] Paginação correta
- [ ] Ordenação determinística
- [ ] Async: `ToListAsync`, `FirstOrDefaultAsync`, `SaveChangesAsync`
- [ ] Cancelamento com `CancellationToken`
- [ ] SQL gerado pelo EF Core
- [ ] Quando usar SQL puro
- [ ] Quando Dapper pode ser uma boa opção para consultas específicas

### Integridade e concorrência

- [ ] Transações
- [ ] Rollback
- [ ] Concorrência otimista
- [ ] rowversion/token de concorrência
- [ ] Soft delete, quando necessário
- [ ] Global query filters, com entendimento dos riscos

### Projeto

Evolua a API de tarefas:

- [ ] SQL Server ou PostgreSQL
- [ ] Migrations
- [ ] Relacionamentos reais
- [ ] Paginação
- [ ] Consultas otimizadas com DTOs
- [ ] Controle de concorrência em atualização de tarefa
- [ ] Seed de categorias e usuário administrador apenas no ambiente local

---

## Fase 9 — Segurança

**Meta:** permitir login, controlar permissões e reduzir vulnerabilidades comuns.

> A OWASP Top 10:2025 (versão final saiu em janeiro/2026) mantém falhas de controle de acesso em #1, e destaca também configuração insegura, problemas na cadeia de suprimentos de software, falhas criptográficas, injeção, falhas de autenticação, ausência de logging/alertas adequados e tratamento inadequado de exceções (categoria nova).

### Autenticação e autorização

- [ ] Diferença entre autenticação e autorização
- [ ] Cadastro de usuário
- [ ] Senhas: nunca salvar em texto puro; usar hash forte fornecido por biblioteca confiável; salt e custo de hash (entendimento conceitual)
- [ ] JWT: access token, claims, issuer, audience, expiração, assinatura
- [ ] Autorização por role, claim ou policy
- [ ] Regra de dono do recurso: usuário só altera a própria tarefa
- [ ] 401 versus 403
- [ ] Refresh token, apenas após JWT básico estar sólido
- [ ] Revogação e expiração de tokens, noções

### Segurança de API

- [ ] HTTPS
- [ ] CORS: o que ele protege e o que ele não protege
- [ ] Rate limiting
- [ ] Validação de entrada
- [ ] Limites de tamanho de requisição
- [ ] Upload de arquivos com segurança, se sua aplicação tiver isso
- [ ] Evitar mass assignment
- [ ] Nunca confiar no ID enviado pelo cliente sem verificar autorização
- [ ] 🆕 XSS (Cross-Site Scripting): o que é, e por que ainda importa mesmo em API — principalmente se algum dia usar Razor/MVC/Blazor Server
- [ ] 🆕 CSRF (Cross-Site Request Forgery): o que é e como tokens/SameSite cookies mitigam
- [ ] 🆕 Cabeçalhos de segurança: HSTS, Content-Security-Policy, X-Frame-Options, X-Content-Type-Options
- [ ] Erros sem detalhes internos em produção
- [ ] Segredos em variáveis de ambiente, User Secrets ou serviço de segredos
- [ ] Não deixar connection string e chave JWT no GitHub

### SQL e dados

- [ ] SQL Injection
- [ ] Por que parâmetros e EF Core ajudam, mas não anulam todos os riscos
- [ ] Não montar SQL com concatenação de entrada de usuário
- [ ] Princípio do menor privilégio para usuário do banco
- [ ] Backups
- [ ] Dados pessoais e LGPD: noções de minimização, finalidade e proteção

### Dependências e logs

- [ ] Revisar dependências do NuGet
- [ ] 🆕 Scanning automático de dependências (Dependabot ou GitHub security alerts) configurado no repositório
- [ ] 🆕 Secret scanning do GitHub, pra pegar token/senha commitado sem querer
- [ ] Atualizar pacotes vulneráveis
- [ ] Não logar token, senha, CPF, cartão ou dados sensíveis
- [ ] Auditoria de ações críticas
- [ ] Logging e alertas de falhas relevantes

### Projeto

Adicione segurança à API:

- [ ] Cadastro e login
- [ ] JWT
- [ ] Roles User e Admin
- [ ] Policy para administrador
- [ ] Regra de propriedade das tarefas
- [ ] Refresh token opcional
- [ ] Rate limiting
- [ ] Secrets fora do repositório
- [ ] Logs de tentativas de login e ações administrativas

---

## Fase 10 — Arquitetura e aplicações completas

**Meta:** organizar uma aplicação grande sem cair em abstrações inúteis.

### Arquitetura em camadas

Comece simples: Api, Application, Domain, Infrastructure, Tests.

> 🆕 O nome do padrão: essa separação em camadas com Domain no centro é a base da **Clean Architecture** (também chamada de Onion Architecture). Vale já saber o nome pra conseguir pesquisar referências e exemplos depois.

| Camada | Responsabilidade |
|---|---|
| Domain | Entidades, regras de negócio e contratos centrais |
| Application | Casos de uso, serviços e orquestração das regras |
| Infrastructure | Banco, EF Core, serviços externos, arquivos e implementações técnicas |
| API | HTTP, controllers, DTOs, autenticação e composição da aplicação |
| Tests | Testes unitários, integração e cenários ponta a ponta |

### Conceitos de DDD (Domain-Driven Design) 🆕

- [ ] Entidade versus Value Object
- [ ] Aggregate e Aggregate Root
- [ ] Bounded Context, noção inicial
- [ ] Ubiquitous Language — usar os mesmos termos do negócio no código
- [ ] Vertical Slice Architecture, como alternativa à Clean Architecture — só para saber que existe

### Princípios de design

- [ ] SOLID, entendendo o problema antes da sigla: responsabilidade única, aberto/fechado, substituição de Liskov, segregação de interfaces, inversão de dependência
- [ ] DRY, sem criar abstração prematura
- [ ] KISS
- [ ] YAGNI
- [ ] Separação de responsabilidades
- [ ] Coesão e acoplamento
- [ ] Código legível antes de código "inteligente"

### Padrões úteis

- [ ] Repository pattern: saiba implementar; não use automaticamente sobre EF Core se ele só duplicar DbSet
- [ ] Unit of Work: entenda que `DbContext` já cumpre parte desse papel
- [ ] Factory
- [ ] Strategy
- [ ] Specification, apenas se a complexidade de filtros justificar
- [ ] Mediator/CQRS: depois de dominar uma arquitetura simples; não usar só porque é popular
- [ ] Result pattern
- [ ] Domain events, apenas em sistemas mais complexos

### Testes profissionais

- [ ] Teste unitário de regras de domínio
- [ ] Teste de integração com banco real ou container de teste
- [ ] Teste de endpoint
- [ ] Teste de autenticação e autorização
- [ ] Testes de contrato, introdução
- [ ] Banco isolado para testes
- [ ] Não depender de ordem de execução
- [ ] Dados previsíveis e limpos

---

## Fase 11 — Docker, CI/CD e deploy

**Meta:** entregar a aplicação para alguém rodar e acessar fora da sua máquina.

> A documentação oficial de .NET reúne testes, GitHub Actions, publicação, Docker e deploy como parte da prática de DevOps para aplicações .NET.

### Docker

- [ ] Imagem versus container
- [ ] Dockerfile
- [ ] Multi-stage build
- [ ] `.dockerignore`
- [ ] Variáveis de ambiente
- [ ] Portas
- [ ] Volumes
- [ ] Docker Compose
- [ ] API + banco em containers
- [ ] Persistência de banco em volume
- [ ] Logs do container
- [ ] Não embutir segredos na imagem
- [ ] 🆕 .NET Aspire, como alternativa mais moderna ao Docker Compose puro pra orquestrar localmente API + banco + cache + mensageria (Microsoft vem empurrando bastante desde .NET 8)
- [ ] 🆕 Feature flags (`Microsoft.FeatureManagement`), introdução — útil pra fazer deploy de algo desligado e ligar depois

### CI/CD

- [ ] Integração contínua
- [ ] Pipeline para: restaurar pacotes, compilar, executar testes, publicar artefato ou imagem
- [ ] GitHub Actions
- [ ] Pull request com validação automática
- [ ] Badge de build no README
- [ ] Variáveis e secrets no GitHub
- [ ] Deploy manual primeiro; automatizado depois

> Workflows do GitHub Actions ficam em `.github/workflows`, e um pipeline .NET inicial deve ao menos validar build e testes antes de aceitar mudanças.

### Deploy

- [ ] Publicar com `dotnet publish`
- [ ] Configuração por ambiente
- [ ] Migrations no deploy, com cuidado
- [ ] Health checks
- [ ] Logs em produção
- [ ] Ambiente de homologação, se possível
- [ ] Domínio e HTTPS
- [ ] Serviços possíveis: Azure App Service, Azure Container Apps, Render, Railway, VPS com Docker
- [ ] Banco gerenciado em produção
- [ ] Backup e plano de rollback

### Documentação

Todo projeto de portfólio deve ter:

- [ ] Descrição do problema resolvido
- [ ] Tecnologias
- [ ] Requisitos
- [ ] Como executar localmente
- [ ] Variáveis de ambiente
- [ ] Como rodar migrations
- [ ] Como rodar testes
- [ ] Rotas principais
- [ ] Credenciais fictícias de desenvolvimento, se aplicável
- [ ] Link do deploy
- [ ] Capturas ou coleção do Postman/Bruno, se útil
- [ ] Decisões técnicas e limitações conhecidas

---

## Fase 12 — C# avançado

**Meta:** dominar recursos importantes da linguagem e saber quando eles são apropriados.

> Não tente estudar tudo isso de uma vez. Estude conforme seus projetos exigirem.

### Tipos e linguagem avançada

- [ ] Pattern matching: `is`, switch expression, property patterns, relational patterns, list patterns
- [ ] Tuplas: `(int Id, string Nome)`, desconstrução
- [ ] Records em profundidade: igualdade por valor, `with`, imutabilidade
- [ ] `struct`, `ref struct` e `readonly struct`
- [ ] `Span<T>` e `ReadOnlySpan<T>`, entendimento de performance
- [ ] `ref`, `in`, `out`, ref return
- [ ] `required`
- [ ] `init`
- [ ] `nameof`
- [ ] Caller info attributes
- [ ] Operadores customizados, apenas quando fizer sentido
- [ ] Conversões implícitas e explícitas customizadas, com extrema cautela

### Programação funcional aplicada

- [ ] Funções puras
- [ ] Imutabilidade
- [ ] Efeitos colaterais
- [ ] Composição de funções
- [ ] `Func<>`, `Action<>`
- [ ] Higher-order functions
- [ ] Option/Maybe como conceito
- [ ] Result pattern para falhas esperadas
- [ ] Evitar usar exceção para regra de negócio comum

### Reflection e metaprogramação

- [ ] Reflection
- [ ] `Type`
- [ ] `PropertyInfo`
- [ ] `MethodInfo`
- [ ] Attributes
- [ ] Criar attributes próprios
- [ ] Cenários válidos: serialização, mapeamento, validação, frameworks
- [ ] Custo e riscos de reflection
- [ ] Source generators, introdução
- [ ] Roslyn, visão geral

### Expression trees

- [ ] Diferença entre lambda normal e expression tree
- [ ] `Expression<Func<T, bool>>`
- [ ] Por que ORMs usam expression trees
- [ ] Compor filtros dinâmicos
- [ ] Limitações de tradução para SQL

### Concorrência e paralelismo

- [ ] Assincronia versus paralelismo
- [ ] Threads
- [ ] Thread pool
- [ ] `Task.Run`
- [ ] `Parallel.ForEachAsync`
- [ ] `Task.WhenAll`
- [ ] `SemaphoreSlim`
- [ ] `lock`
- [ ] Race conditions
- [ ] Deadlocks
- [ ] `ConcurrentDictionary`
- [ ] `Channel<T>`
- [ ] Producer-consumer
- [ ] `IAsyncEnumerable<T>`
- [ ] `await foreach`
- [ ] `CancellationToken` corretamente propagado

### Comunicação em tempo real e entre serviços 🆕

- [ ] SignalR — comunicação em tempo real/WebSockets, nativo do ASP.NET Core
- [ ] gRPC — comunicação serviço-a-serviço de alta performance
- [ ] GraphQL (via HotChocolate), apenas para saber que existe e quando faz sentido em vez de REST

### Performance e diagnóstico

- [ ] Medir antes de otimizar
- [ ] BenchmarkDotNet, introdução
- [ ] Alocações
- [ ] Boxing
- [ ] Strings
- [ ] LINQ em pontos críticos
- [ ] `Span<T>`
- [ ] `ArrayPool<T>`
- [ ] Cache: memória, distribuído (Redis é a opção mais comum), introdução
- [ ] Profiling
- [ ] Logs e tracing
- [ ] Métricas
- [ ] OpenTelemetry, introdução

### Interoperabilidade

- [ ] P/Invoke, apenas visão geral
- [ ] Bibliotecas nativas
- [ ] Serialização: `System.Text.Json`, noções de Newtonsoft.Json
- [ ] XML quando encontrar em sistemas legados
- [ ] HTTP com `HttpClient`
- [ ] `IHttpClientFactory`
- [ ] Resiliência: timeout, retry, circuit breaker (conceito)
- [ ] APIs externas e tratamento de falhas

---

## Extras do ecossistema .NET

Esses temas não são obrigatórios para sua primeira API completa, mas fazem parte de um desenvolvedor .NET mais completo.

### Aplicações web completas

- [ ] ASP.NET Core MVC
- [ ] Razor Pages
- [ ] Blazor Server
- [ ] Blazor WebAssembly
- [ ] Razor Components
- [ ] HTML, CSS e JavaScript suficientes para integrar frontend e backend
- [ ] Consumo de API no frontend
- [ ] Autenticação em aplicações web

### Aplicações desktop

- [ ] WPF
- [ ] WinUI
- [ ] Windows Forms, para manutenção de sistemas legados
- [ ] MVVM
- [ ] Data binding
- [ ] Commands

> Desktop só vale prioridade se você quiser vaga nessa área.

### Aplicações mobile

- [ ] .NET MAUI
- [ ] XAML
- [ ] MVVM
- [ ] Consumo de APIs
- [ ] Armazenamento local
- [ ] Notificações, conforme necessidade

### Background services

- [ ] `IHostedService`
- [ ] `BackgroundService`
- [ ] Worker Service
- [ ] Processamento agendado
- [ ] Filas
- [ ] Jobs recorrentes
- [ ] Hangfire ou Quartz.NET, depois de entender o básico

### Mensageria e sistemas distribuídos

- [ ] RabbitMQ ou Azure Service Bus
- [ ] 🆕 Kafka, como alternativa mais focada em streaming de eventos em alto volume
- [ ] Filas
- [ ] Pub/sub
- [ ] Eventos
- [ ] Idempotência
- [ ] Retry
- [ ] Dead-letter queue
- [ ] Outbox pattern, avançado
- [ ] 🆕 YARP como API Gateway/BFF, introdução — relevante quando existir mais de um serviço pra rotear
- [ ] Microserviços só depois de construir bem um monólito modular

### Cloud Azure

- [ ] Azure App Service
- [ ] Azure Container Apps
- [ ] Azure Functions
- [ ] Azure SQL
- [ ] Azure Blob Storage
- [ ] Azure Key Vault
- [ ] Application Insights
- [ ] Azure DevOps, opcional se a empresa usar

---

## Fase 13 — Preparação para o mercado 🆕

**Meta:** se preparar para o processo seletivo em si, não só para escrever código.

> Diferente das fases anteriores, esta não é estritamente sequencial. O ideal é começar a praticar um pouco desde a Fase 1 (principalmente algoritmos e inglês técnico) e tratar como pré-requisito real antes de sair caçando vaga — muitos processos seletivos de estágio/júnior no Brasil incluem teste de lógica/algoritmos, mesmo em vagas que no dia a dia são "só" CRUD web.

### Estruturas de dados e algoritmos

- [ ] Complexidade de tempo e espaço (Big O), noção prática
- [ ] Busca linear e busca binária
- [ ] Ordenação: bubble sort, insertion sort, merge sort, quick sort — entender a ideia, não decorar implementação
- [ ] Listas encadeadas
- [ ] Pilhas e filas na teoria, não só via `Queue<T>`/`Stack<T>`
- [ ] Árvores binárias e árvore de busca
- [ ] Hashing e tabelas hash — a base teórica por trás do `Dictionary<TKey, TValue>`
- [ ] Recursão
- [ ] Prática recorrente em Beecrowd, LeetCode ou HackerRank

### Colaboração e fluxo de trabalho em equipe

- [ ] Git flow ou trunk-based development, noção de cada um
- [ ] Como escrever uma Pull Request clara (descrição, contexto, como testar)
- [ ] Etiqueta de code review, tanto pedindo quanto revisando
- [ ] Conventional commits, opcional mas comum no mercado

### Inglês técnico

- [ ] Ler documentação oficial (Microsoft Learn) sem depender de tradução
- [ ] Entender mensagens de erro e stack traces em inglês
- [ ] Vocabulário básico de entrevista técnica em inglês, se a vaga pedir

### Portfólio e processo seletivo

- [ ] README de perfil no GitHub
- [ ] Perfil no LinkedIn com os projetos do roadmap
- [ ] Saber explicar as decisões técnicas de cada projeto em 2–3 minutos
- [ ] Preparo para perguntas comportamentais comuns (por que .NET, maior desafio técnico, como lida com prazo)
- [ ] Simulação de entrevista técnica, com outra pessoa ou gravando a si mesmo

---

## Ordem dos projetos

Construa estes projetos em sequência. Evite criar dez CRUDs iguais; cada projeto deve introduzir um desafio novo.

| Projeto | Fases | O que comprova |
|---|---|---|
| Calculadora ou notas no console | 0–1 | Lógica, entrada, validação e métodos |
| Biblioteca em memória | 2 | POO, regras de negócio e composição |
| Biblioteca em JSON | 3 | Arquivos, JSON e exceções |
| Estoque com relatórios | 4–6 | LINQ, coleções, testes e async |
| Estoque em SQL | 5–6 | Modelagem, SQL e transações |
| API de tarefas | 7–8 | HTTP, API, EF Core, DTOs e migrations |
| API de tarefas segura | 9 | JWT, roles, policies e segurança |
| Sistema de pedidos/financeiro | 10–12 | Arquitetura, Docker, CI/CD, deploy e integração |

> 🆕 A Fase 13 roda em paralelo com todas as outras — não tem um projeto próprio, mas deve estar em andamento (algoritmos + portfólio) desde bem cedo.

## Projeto final recomendado

Faça um sistema de pedidos ou sistema financeiro pessoal/empresarial. Ele precisa ter regras suficientes para provar que você entende mais que CRUD.

### Requisitos mínimos

- [ ] API ASP.NET Core
- [ ] SQL Server ou PostgreSQL
- [ ] EF Core com migrations
- [ ] Arquitetura em camadas
- [ ] Cadastro e login
- [ ] JWT
- [ ] Roles e policies
- [ ] DTOs
- [ ] Validação
- [ ] Paginação, filtros e ordenação
- [ ] Tratamento global de exceções
- [ ] Logs
- [ ] Testes unitários
- [ ] Testes de integração dos endpoints principais
- [ ] Docker e Docker Compose
- [ ] Pipeline GitHub Actions para build e testes
- [ ] Deploy público
- [ ] README completo
- [ ] Swagger documentado

### Exemplo: sistema de pedidos

Entidades possíveis: Usuario, Cliente, Produto, Categoria, Pedido, ItemPedido, Pagamento, MovimentacaoEstoque.

Regras que deixam o projeto forte:

- [ ] Não permitir pedido sem itens
- [ ] Não permitir quantidade acima do estoque
- [ ] Calcular subtotal, desconto, frete e total no servidor
- [ ] Impedir alteração de pedido já pago ou cancelado
- [ ] Atualizar estoque em transação
- [ ] Permitir que cliente veja apenas os próprios pedidos
- [ ] Permitir que administrador administre produtos e pedidos
- [ ] Registrar auditoria de alterações relevantes

## O que evitar

- [ ] Pular direto para Clean Architecture, CQRS, microserviços e mensageria.
- [ ] Criar repository e unit of work só porque viu em tutorial.
- [ ] Decorar SOLID sem reconhecer problemas reais de acoplamento.
- [ ] Usar async em tudo sem entender I/O e cancelamento.
- [ ] Retornar entidades do EF Core diretamente na API.
- [ ] Salvar senha em texto puro.
- [ ] Colocar connection string, token JWT ou segredo no GitHub.
- [ ] Fazer só CRUD sem regras de negócio.
- [ ] Copiar projeto de vídeo sem alterar escopo ou decisões.
- [ ] Estudar 20 tecnologias sem terminar e publicar um projeto completo.
- [ ] 🆕 Ignorar segurança básica (XSS, CSRF, cabeçalhos) achando que "não é prioridade agora".
- [ ] 🆕 Pular a prática de algoritmos achando que "não serve pra nada no dia a dia", e travar no primeiro teste técnico de processo seletivo.

## Critério de "pronto"

Você estará pronto para disputar estágio/júnior quando conseguir, sem tutorial completo:

- [ ] Criar uma API do zero.
- [ ] Modelar banco e relacionamentos.
- [ ] Usar EF Core e migrations.
- [ ] Escrever SQL com joins, agregações e transações.
- [ ] Criar autenticação JWT e autorização por roles/policies.
- [ ] Validar entrada e tratar erros corretamente.
- [ ] Escrever testes para regras importantes.
- [ ] Rodar API e banco em Docker.
- [ ] Configurar CI simples.
- [ ] Fazer deploy.
- [ ] Explicar as decisões do projeto no README e numa entrevista.
- [ ] 🆕 Resolver problemas básicos de estrutura de dados e algoritmos sem se perder.
- [ ] 🆕 Ter um portfólio (GitHub + LinkedIn) apresentável e saber falar sobre ele numa conversa, não só no README.