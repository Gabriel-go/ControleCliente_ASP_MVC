using Microsoft.EntityFrameworkCore;
using ControleCliente_ASP_MVC.Models;

namespace ControleCliente_ASP_MVC.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {}

        public DbSet<Contato> Contato { get; set; }
    }
}
