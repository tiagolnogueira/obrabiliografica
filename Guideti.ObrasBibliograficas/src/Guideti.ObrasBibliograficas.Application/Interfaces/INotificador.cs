using Guideti.ObrasBibliograficas.Application.Notificacoes;
using System.Collections.Generic;

namespace Guideti.ObrasBibliograficas.Application.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}