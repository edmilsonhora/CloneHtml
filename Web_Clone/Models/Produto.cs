using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Clone.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
    }


    public class ProdutoRepository
    {
        public List<Produto> GetAll()
        {
            return new List<Produto>()
            {
                new Produto(){ Id= 1, Descricao="Produto 1", CategoriaId=1},
                new Produto(){ Id= 2, Descricao="Produto 2", CategoriaId=2},
                new Produto(){ Id= 3, Descricao="Produto 3", CategoriaId=3},
                new Produto(){ Id= 4, Descricao="Produto 4", CategoriaId=4},
                new Produto(){ Id= 5, Descricao="Produto 5", CategoriaId=5},
                new Produto(){ Id= 6, Descricao="Produto 6", CategoriaId=6},
                new Produto(){ Id= 7, Descricao="Produto 7", CategoriaId=7},
                new Produto(){ Id= 8, Descricao="Produto 8", CategoriaId=2},
                new Produto(){ Id= 9, Descricao="Produto 9", CategoriaId=3},
                new Produto(){ Id= 10, Descricao="Produto 10", CategoriaId=4},
                new Produto(){ Id= 11, Descricao="Produto 11", CategoriaId=5},
                new Produto(){ Id= 12, Descricao="Produto 12", CategoriaId=6},
                new Produto(){ Id= 13, Descricao="Produto 13", CategoriaId=7},
                new Produto(){ Id= 14, Descricao="Produto 14", CategoriaId=2},
                new Produto(){ Id= 15, Descricao="Produto 15", CategoriaId=3},
                new Produto(){ Id= 16, Descricao="Produto 16", CategoriaId=4},
                new Produto(){ Id= 17, Descricao="Produto 17", CategoriaId=5},
                new Produto(){ Id= 18, Descricao="Produto 18", CategoriaId=6},
                new Produto(){ Id= 19, Descricao="Produto 19", CategoriaId=7},
                new Produto(){ Id= 20, Descricao="Produto 20", CategoriaId=1},
            };
        }

        public List<Produto> GetBy(int categoriaId)
        {
            return GetAll().Where(p => p.CategoriaId.Equals(categoriaId)).ToList();
        }
    }
}