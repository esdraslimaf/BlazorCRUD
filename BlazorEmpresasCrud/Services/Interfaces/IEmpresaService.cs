using BlazorEmpresasCrud.Models;

namespace BlazorEmpresasCrud.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task Add(Empresa emp);
        Task Remove(Empresa emp);
        Task Update(Empresa emp);
        Task<Empresa> GetById(Guid id);
        Task<List<Empresa>> GetAll();

    }
}
