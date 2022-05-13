using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Clone.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class CategoriaRepository
    {
        public List<Categoria> GetAll()
        {
            return new List<Categoria>()
            {
                new Categoria(){ Id = 1, Nome= "Bonés"},
                new Categoria(){ Id = 2, Nome= "Relógios"},
                new Categoria(){ Id = 3, Nome= "Perfumes"},
                new Categoria(){ Id = 4, Nome= "Joias"},
                new Categoria(){ Id = 5, Nome= "Calças"},
                new Categoria(){ Id = 6, Nome= "Sapatos"},
                new Categoria(){ Id = 7, Nome= "Camisas"},
                new Categoria(){ Id = 8, Nome= "Notebooks"},
                new Categoria(){ Id = 9, Nome= "Celulares"}
            };
        }

        public Categoria GetBy(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}