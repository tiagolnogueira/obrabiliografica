using AutoMapper;
using Guideti.ObrasBibliograficas.Api.Controllers;
using Guideti.ObrasBibliograficas.Api.ViewModels;
using Guideti.ObrasBibliograficas.Application.Interfaces;
using Guideti.ObrasBibliograficas.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Guideti.ObrasBibliograficas.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/autores")]
    public class AutorController : MainController
    {
        private readonly IAutorService _autorService;
        private readonly IMapper _mapper;

        public AutorController(IAutorService autorService,
                               INotificador notificador,
                               IMapper mapper) : base(notificador)
        {
            _autorService = autorService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<List<Autor>>> Adicionar(ConsultaAutorViewModel autorViewModel)
        {
            var lstAutores = new List<Autor>();
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            if (autorViewModel.Quantidade != autorViewModel.Autores.Count)
                NotificarErro("A quantidade de autores inválida!");
            else
            {
                
                foreach (var autor in autorViewModel.Autores)
                {
                    var autorResult = await _autorService.Adicionar(_mapper.Map<Autor>(autor));
                    lstAutores.Add(autorResult);
                }    
            }
            return CustomResponse(lstAutores);
        }
    }
}