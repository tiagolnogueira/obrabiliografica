using Guideti.ObrasBibliograficas.Application.Interfaces;
using Guideti.ObrasBibliograficas.Domain.Entities;
using Guideti.ObrasBibliograficas.Domain.Entities.Validations;
using System.Linq;
using System.Threading.Tasks;

namespace Guideti.ObrasBibliograficas.Application.Services
{
    public class AutorService : BaseService, IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository,
                            INotificador notificador) : base(notificador)
        {
            _autorRepository = autorRepository;
        }

        public async Task<Autor> Adicionar(Autor autor)
        {
            if (!ExecutarValidacao(new AutorValidation(), autor)) return null;

            if (_autorRepository.Buscar(a => a.Nome == autor.Nome).Result.Any())
            {
                Notificar($"Já existe um autor com este Nome:{autor.Nome} informado.");
                return null;
            }

            return await _autorRepository.Adicionar(autor);
        }

        public void Dispose()
        {
            _autorRepository?.Dispose();
        }
    }
}
