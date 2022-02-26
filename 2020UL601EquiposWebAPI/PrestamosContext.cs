using Microsoft.EntityFrameworkCore;
using _2020UL601EquiposWebAPI.Models;

namespace _2020UL601EquiposWebAPI
{
    public class PrestamosContext:DbContext
    {
        public PrestamosContext(DbContextOptions<PrestamosContext> options) : base(options)
        {

        }
        public DbSet<Equipos> equipos { get; set; }
    }
}
