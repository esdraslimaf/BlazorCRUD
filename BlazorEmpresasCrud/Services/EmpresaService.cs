using BlazorEmpresasCrud.Database;
using BlazorEmpresasCrud.Models;
using BlazorEmpresasCrud.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmpresasCrud.Services
{
    public class EmpresaService:IEmpresaService
    {
        private readonly BlazorContext _db;

        public EmpresaService(BlazorContext db)
        {
            _db = db;
        }


        public async Task Add(Empresa emp)
        {
           await _db.Empresas.AddAsync(emp);
           await _db.SaveChangesAsync();
        }

        public async Task Remove(Empresa emp)
        {
            _db.Empresas.Remove(emp);
            await _db.SaveChangesAsync();
        }

        public async Task Update(Empresa emp)
        {
            _db.Empresas.Update(emp);
            await _db.SaveChangesAsync();
        }

        public async Task<Empresa> GetById(Guid id)
        {
            Empresa empresa = await _db.Empresas.FirstOrDefaultAsync(emp=>emp.Id==id);
            return empresa;
        }

        public async Task<List<Empresa>> GetAll()
        {
            List<Empresa> empresas = await _db.Empresas.ToListAsync();
            return empresas;
        }
    }
}
