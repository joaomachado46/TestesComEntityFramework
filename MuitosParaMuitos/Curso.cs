using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosParaMuitos
{
    public class Curso
    {
        public int Id { get; set; }
        public string CursoNome { get; set; }
        public string Descricao { get; set; }

        public ICollection<AlunoCurso> AlunoCursos { get; set; }
    }
}
