using GeradorSenhas.Models;
using Microsoft.EntityFrameworkCore;

namespace GeradorSenhas.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<SenhasGeradas> SenhasGeradas { get; set; }
}