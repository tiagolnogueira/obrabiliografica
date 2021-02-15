using Guideti.ObrasBibliograficas.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Guideti.ObrasBibliograficas.Application.Interfaces
{
    public interface IAutorService : IDisposable
    {
        public Task<Autor> Adicionar(Autor autor);
    }
}
