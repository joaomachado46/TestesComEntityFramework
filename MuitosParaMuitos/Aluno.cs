using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosParaMuitos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<AlunoCurso> AlunoCursos { get; set; }
    }
}
