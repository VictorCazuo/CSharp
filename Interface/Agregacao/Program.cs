using Agregacao;

//Exercício 1 - E-Commerce
Console.WriteLine("Exercício 1 - E-Commerce");

Cliente c1 = new Cliente(1, "Victor");
CarrinhoDeCompras carrinho1 = new CarrinhoDeCompras(c1);
carrinho1.AdicionarItem("Pão");
carrinho1.AdicionarItem("Queijo");
carrinho1.FecharPedido();

//Exercício 2 - Computador e Pendrive
Console.WriteLine("\nExercício 2 - Computador e Pendrive");

PenDrive p1 = new PenDrive(50);
Computador pc1 = new Computador();
pc1.ConectarUSB(p1);
pc1.AcessarDados();
pc1.DesconectarUSB();
pc1.AcessarDados();

//Exercício 3 - Sistema de matrícula
Console.WriteLine("\nExercício 3 - Sistema de matrícula");
Aluno aluno1 = new Aluno("2026104829", "Victor");
Aluno aluno2 = new Aluno("2025209134", "Pedro");
Turma turma1 = new Turma("Lógica de Programação");
turma1.Matricular(aluno1);
turma1.Matricular(aluno2);
turma1.ExibirDiarioDeClasse();



