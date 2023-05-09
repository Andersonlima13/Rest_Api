using api_c_.Models;
using Microsoft.EntityFrameworkCore;

namespace api_c_.Data
{
    public class SistemaDeTarefasDB : DbContext
    {
        public SistemasDeTarefasDB(DbContextOptions<SistemaDeTarefasDB> options) : base(options)
        {

        }

        public DbSet<UserModel> users { get; set; } 
        public DbSet<TaskModel> tasks { get; set; }

        protected override void OnMOdelCreating()
        {

        }




    }
}
