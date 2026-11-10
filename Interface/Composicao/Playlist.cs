using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao
{
    public class Musica
    {
        public string Nome { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public int DuracaoSegundos { get; set; }

        public Musica(string nome, string artista, int duracaoSegundos)
        {
            Nome = nome;
            Artista = artista;
            DuracaoSegundos = duracaoSegundos;
        }
    }

    public class Playlist
    {
        public string NomePlaylist { get; set; } = string.Empty;
        private List<Musica> _musicas;

        public Playlist(string nomePlaylist)
        {
            NomePlaylist = nomePlaylist;
            _musicas = new List<Musica>();
        }

        public void AdicionarMusica(Musica m)
        {
            Console.WriteLine($"Adiconando a música {m.Nome} na playlist {NomePlaylist}");
            _musicas.Add(m);
        }

        public IEnumerable<Musica> ObterMusicasDoArtista(string artista)
        {
            List<Musica> musicaPorArtista = _musicas.FindAll(m => m.Artista == artista);

            return musicaPorArtista;
        }
    }
}
