using MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEF.Dal {
    public class LanchoneteInitializer : DropCreateDatabaseIfModelChanges<LanchoneteContext>{
        protected override void Seed(LanchoneteContext context) {
            var pizza = new List<Pizza> {
                new Pizza{Id = 1, Descricao = "Catupiry", Valor = 30},
                new Pizza{Id = 2, Descricao = "4 queijos", Valor = 35},
            };
            pizza.ForEach(d => context.Pizzas.Add(d));
            context.SaveChanges();
        }
    }
}