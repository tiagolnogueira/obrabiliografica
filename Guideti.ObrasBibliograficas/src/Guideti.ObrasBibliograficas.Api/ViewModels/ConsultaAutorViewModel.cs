using System.Collections.Generic;

namespace Guideti.ObrasBibliograficas.Api.ViewModels
{
    public class ConsultaAutorViewModel
    {
        public int Quantidade { get; set; }
        public List<AutorViewModel> Autores { get; set; }
    }
}
