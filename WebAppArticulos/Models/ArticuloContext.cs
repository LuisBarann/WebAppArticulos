﻿using Microsoft.EntityFrameworkCore;

namespace WebAppArticulos.Models
{
    public class ArticuloContext : DbContext
    {
        public ArticuloContext(DbContextOptions<ArticuloContext> options)
            : base(options)
        { 
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
