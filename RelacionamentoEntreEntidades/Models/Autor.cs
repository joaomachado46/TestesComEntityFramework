using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoEntreEntidades
{
     public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }

        public Autor()
        {
        }

        public Autor(string nome, string sobreNome)
        {
            
            Nome = nome;
            SobreNome = sobreNome;
            Livros = new List<Livro>();
        }
    }
}
