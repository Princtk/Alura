using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

                ExibirEntries(contexto.ChangeTracker.Entries());

                var novoProduto = new Produto()
                {
                    Nome = "Desinfetante",
                    Categoria = "Limpeza",
                    Preco = 2.99
                };

                contexto.Add(novoProduto);


                Console.WriteLine("=====================");
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.Entity.ToString() + " " + e.State);
                }

                ExibirEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();
                ExibirEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void ExibirEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("=====================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.State);
            }
        }
    }
}