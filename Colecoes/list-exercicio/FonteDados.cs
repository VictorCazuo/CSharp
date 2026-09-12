using System;
using System.Collections.Generic;
using System.Text;

namespace list_exercicio
{
    public class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno("Maria", 8.75),
                new Aluno("Manoel", 6.95),
                new Aluno("Amanda", 7.25),
                new Aluno("Carlos", 6.55),
                new Aluno("Jaime", 8.50),
                new Aluno("Debora", 5.95),
                new Aluno("Alicia", 9.25),
                new Aluno("Sandra", 5.55),
                new Aluno("Marta", 7.85),
                new Aluno("Sueli", 9.15),
            };

            return alunos;
        }
    }
}
