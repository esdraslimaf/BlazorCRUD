using BlazorEmpresasCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmpresasCrud.Database
{
    public class BlazorContext:DbContext
    {
        public BlazorContext(DbContextOptions<BlazorContext> options):base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
    }
}
