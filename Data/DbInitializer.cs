using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC__CRUD_TESTE.Models;

namespace MVC__CRUD_TESTE.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProdutosContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Produtos.Any())
            {
                return;   // DB has been seeded
            }

            var Produtos = new Produtos[]
            {
            };

            foreach (Produtos s in Produtos)
            {
                context.Produtos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
