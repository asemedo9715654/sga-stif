using Microsoft.AspNetCore.Mvc;

using sga_stif.Models;

namespace sga_stif.Controllers
{
    // [BreadcrumbActionFilter]
    public class BaseController : Controller
    {
        private readonly ContextoBaseDados _contextrrr;
        public string PegarNomeUtilizador()
        {
            return HttpContext.Session.GetString("NomeUtilizador"); ;
        }

        public int PegarIdPerfil()
        {
            try
            {
                int idSessao = Convert.ToInt32(HttpContext.Session.GetString("IdPerfil"));
                return idSessao;

            }
            catch (Exception e)
            {
                return -1000;
            }

        }

        public List<int> ListaInstituicoesFinanceirasPermitidas(ContextoBaseDados _contextrrr)
        {
            var idPerfil = PegarIdPerfil();
            var ints = _contextrrr.PerfilInstituicaoFinanceira
                .Where(p => p.Permitido == true && p.IdPerfil == idPerfil)
                .Select(k => k.IdInstituicaoFinanceira);

            return ints.ToList();
        }


        public List<int> ListaAgenciasPermitidas(ContextoBaseDados _contextrrr)
        {

            var listaInstituicoesFinanceirasPermitidas = ListaInstituicoesFinanceirasPermitidas(_contextrrr);
            var idPerfil = PegarIdPerfil();
            var ints = _contextrrr.Agencia
                .Where(p => listaInstituicoesFinanceirasPermitidas.Contains(p.IdInstituicaoFinanceira))
                .Select(k => k.IdAgencia);

            return ints.ToList();
        }




    }
}