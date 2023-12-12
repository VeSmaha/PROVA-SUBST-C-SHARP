using Microsoft.EntityFrameworkCore;
using Api.Models;
namespace  Api.Db;
public class Context:DbContext{
    public Context(DbContextOptions<Context>options):base(options){}

    public DbSet<Usuario> Usuarios {get; set;}

    public DbSet<Imc> Imcs {get;set;}
    
}

//http://localhost:5066