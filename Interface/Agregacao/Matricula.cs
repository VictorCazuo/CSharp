using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Agregacao
{
    public class Aluno
    {
        public string Matricula { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;    
        }

    }

    public class Turma
    {
        public string NomeDisciplina { get; set; } = string.Empty;
        private List<Aluno> alunos { get; set; }

        public Turma(string nomeDisciplina)
        {
            NomeDisciplina = nomeDisciplina;
            alunos = new List<Aluno>();
        }

        public void Matricular(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void ExibirDiarioDeClasse()
        {
            Console.WriteLine($"Disciplina de {NomeDisciplina}");

            foreach(var a in alunos)
            {
                Console.WriteLine($"Aluno: {a.Nome} - Matrícula: {a.Matricula}");
            }
        }
    }
}
