using System;
using SeusExercicios.POO;

// ==========================================
// 1. TESTES DE SISTEMAS DE GESTÃO
// ==========================================
Console.WriteLine("--- TESTE PESSOA ---");
Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "Victor";
pessoa1.idade = 21;
pessoa1.profissao = "Desenvolvedor";
pessoa1.Apresentar();

Console.WriteLine("\n--- TESTE ALUNO (MÉDIA) ---");
Aluno alunoJulia = new Aluno();
alunoJulia.nome = "Julia";
alunoJulia.nota1 = 10;
alunoJulia.nota2 = 5.5;
alunoJulia.CalcularMedia();

Console.WriteLine("\n--- TESTE FUNCIONÁRIO ---");
Funcionario funcionario1 = new Funcionario();
funcionario1.nome = "Victor";
funcionario1.cargo = "Desenvolvedor";
funcionario1.salarioBruto = 1500;
funcionario1.ExibirHolerite();

Console.WriteLine("\n--- TESTE CONTA BANCÁRIA ---");
ContaBancaria usuario = new ContaBancaria();
usuario.Depositar(100);
usuario.Sacar(200);

Console.WriteLine("\n--- TESTE EMPRESA E USUÁRIO ---");
Empresa empresa1 = new Empresa("Silva & Oliveira LTDA", "1637344200011");
Console.WriteLine($"Razao Social: {empresa1.RazaoSocial}\nCnpj: {empresa1.Cnpj}");

UsuarioLogin user1 = new UsuarioLogin("useradmin@gmail.com", "useradmin", "Administrador");
Console.WriteLine($"Usuario 1: Email = {user1.Email} | Nivel de Acesso = {user1.NivelAcesso}");


// ==========================================
// 2. TESTES DA SUPER CLASSE CARRO
// ==========================================
Console.WriteLine("\n--- TESTANDO A SUPER CLASSE CARRO ---");
Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar("Onix");
chevrolet.ExibirInfo(modelo: "Onix", montadora: "Chevrolet", marca: "Chevrolet", potencia: 110);

Carro.ObterValorIPVA();
Console.WriteLine($"O IPVA para todos os carros é de {Carro.ValorIpva}%");


// ==========================================
// 3. TESTES DE LÓGICA E GUARD CLAUSES
// ==========================================
Console.WriteLine("\n--- TESTANDO LUTADOR E CONDICIONAMENTO ---");
Lutador l1 = new Lutador("Victor", 40, false);
Console.WriteLine(l1.AvaliarCondicao());

Console.WriteLine("\n--- TESTANDO HARDWARE E GARGALO ---");
Computador c1 = new Computador();
Console.WriteLine(c1.CalcularGargalo(200, 22));

Console.WriteLine("\n--- TESTANDO CATRACA OCR ---");
Aluno alunoCatraca = new Aluno("Victor", 123);
CatracaOcr testeCatraca = new CatracaOcr();
bool liberado = testeCatraca.LiberarAcesso("BRA2E19", alunoCatraca);
Console.WriteLine($"Acesso autorizado? {liberado}");


// ==========================================
// 4. TESTES DE SOBRECARGAS AVANÇADAS
// ==========================================
Console.WriteLine("\n--- TESTANDO UPGRADE DE SETUP ---");
ComputadorSetup pc1 = new();
Console.WriteLine(pc1.FazerUpgrade("RTX 6060"));
Console.WriteLine(pc1.FazerUpgrade(120));

Console.WriteLine("\n--- TESTANDO CAIXA DE SUPERMERCADO ---");
Caixa compra1 = new();
compra1.ProcessarPagamento(10, 20);

Console.WriteLine("\n--- TESTANDO REPOSITÓRIO SQL ---");
RepositorioEmpresa e1 = new();
Console.WriteLine(e1.GerarQueryBusca(222));
Console.WriteLine(e1.GerarQueryBusca("1234567891012"));

Console.WriteLine("\n--- TESTANDO DANO EM RPG ---");
Personagem p1 = new Personagem("Victor", 100, 20);
p1.ReceberDano(21);
p1.ReceberDano(50, "Fogo Celestial");