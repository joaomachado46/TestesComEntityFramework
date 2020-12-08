using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosParaMuitos
{
    public class AlunoCurso
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
