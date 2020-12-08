using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoEntreEntidades
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public Livro()
        {
        }

        public Livro(string titulo, int anoLancamento)
        {
            Titulo = titulo;
            AnoLancamento = anoLancamento;
        }
    }
}
