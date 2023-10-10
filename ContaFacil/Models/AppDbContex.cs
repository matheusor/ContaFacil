using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ContaFacil.Models
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { }
        public DbSet<Cadastro> Cadastros { get; set; }

    }
}
