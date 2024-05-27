using ApiPersonajesExamenMP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPersonajesExamenMP.Data
{
    public class PeliculasContext:DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext>
            options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
