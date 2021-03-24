using MVCEF.Models;
using System.Data.Entity;

namespace MVCEF.Dal {
    public class LanchoneteContext : DbContext {

        public LanchoneteContext() : base("LanchoneteContext") {
        }

        public DbSet<Pizza> Pizzas{ get; set; }

    }
}