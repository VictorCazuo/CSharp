using Composicao;

//Exercicio 1 - RPG
Console.WriteLine("Exercício 1 - RPG");
Arma espada = new Arma("Espada de Madeira", 10);
Arma espada_fogo = new Arma("Espada de Fogo", 20);
Personagem link = new Personagem("Link", 100, espada_fogo);

link.Atacar();

//Exercicio 2 - E-commerce
Console.WriteLine("\nExercicio 2 - E-commerce");
Cliente cliente1 = new Cliente("Victor", "victor@gmail.com");

Pedido pedido1 = new Pedido(cliente1);
pedido1.AdicionarItem(new Item("Escova de dente", 22));
pedido1.AdicionarItem(new Item("Fio dental", 20 ));
pedido1.AdicionarItem(new Item("Pasta de dente", 7.90m));

Console.WriteLine($"Lista de pedidos do usuário {cliente1.Nome}");
pedido1.ExibirItens();
Console.WriteLine($"Valor final = {pedido1.CalcularTotal()}");

//Exercício 3 - Hub Inteligente
Console.WriteLine("\nExercício 3 - Hub Inteligente");
HubInteligente sala = new HubInteligente();
sala.AtivarModoCinema();
Lampada lampada = new Lampada();
lampada.MudarCor("vermelho");
sala.AtivarModoCinema();

//Exercício 4 - PC Gamer
Console.WriteLine("\nExercício 4 - PC Gamer");
Processador processador1 = new Processador("AMD", 4.4);
Computador p1 = new Computador(processador1);
p1.InstalarMemoria(new MemoriaRAM(8, TipoMemoria.DDR4));
p1.InstalarMemoria(new MemoriaRAM(16, TipoMemoria.DDR5));
p1.ExibirEspecificacoes();

//Exercicio 5 - Playlist
Console.WriteLine("\nExercicio 5 - Playlist");
Playlist playlistNova = new Playlist("Musicas Favoritas");
playlistNova.AdicionarMusica(new Musica("Seasons", "Wave to earth", 301));
playlistNova.AdicionarMusica(new Musica("Love", "Wave to earth", 308));
playlistNova.AdicionarMusica(new Musica("Let Go", "Ark Patrol", 249));
playlistNova.AdicionarMusica(new Musica("505", "Arctic Monkeys", 254));

var musicas_wave = playlistNova.ObterMusicasDoArtista("Wave to earth");

Console.WriteLine("\nMúsicas da banda Wave to earth:");
foreach(var musica in musicas_wave)
{
    Console.WriteLine($"{musica.Nome} - {musica.Artista} - {musica.DuracaoSegundos}segundos");
}

//Exercicio 6 - Drone de entrega
Console.WriteLine("\nExercício 6 - Drone de entrega");
MotorEletrico eletrico = new MotorEletrico();
MotorCombustao combustao = new MotorCombustao();

Drone drone_entrega = new Drone(combustao);
//Drone drone_entrega = new Drone(eletrico);
drone_entrega.Voar();




