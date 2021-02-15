using Guideti.ObrasBibliograficas.Application.Interfaces;
using Guideti.ObrasBibliograficas.Domain.Entities;
using Guideti.ObrasBibliograficas.Infra.Context;

namespace Guideti.ObrasBibliograficas.Infra.Repository
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public AutorRepository(MeuDbContext context) : base(context)
        {
        }
    }
}


