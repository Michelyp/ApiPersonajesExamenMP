using ApiPersonajesExamenMP.Data;
using ApiPersonajesExamenMP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPersonajesExamenMP.Repositories
{
    public class RepositoryPelicula
    {
        private PeliculasContext context;
        public RepositoryPelicula(PeliculasContext context)
        {
            this.context = context;
        }
        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await this.context.Peliculas.ToListAsync();
        }
        public async Task<List<Pelicula>> GetPeliculasActorAsync(string actor)
        {
            return await this.context.Peliculas.Where(x => x.Actores.Contains(actor)).ToListAsync();
            
        }
    }
}
