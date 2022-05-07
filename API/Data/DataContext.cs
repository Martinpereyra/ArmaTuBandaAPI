using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Musico> Musicos { get; set; }
    
    public DbSet<Tipo> Tipos { get; set; }

    public DbSet<Genero> Generos { get; set; }

    public DbSet<Instrumento> Instrumentos { get; set; }

}