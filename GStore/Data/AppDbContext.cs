using GStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GStore.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppContext> options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> produtos { get; set; }
    public DbSet<ProdutoFoto>  { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    
    }