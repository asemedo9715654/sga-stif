using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using sga_stif.Models;

namespace sga_stif.Filtros
{
    public class LogFiltro :  IActionFilter
    {
         private readonly ContextoBaseDados context;


         public LogFiltro(ContextoBaseDados context)
         {
              this.context = context;
         }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string data = "";

            var routeData = context.RouteData;
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];

            var url = $"{controller}/{action}";

            if (!string.IsNullOrEmpty(context.HttpContext.Request.QueryString.Value))
            {
                data = context.HttpContext.Request.QueryString.Value;
            }
            else
            {
                var arguments = context.ActionArguments;
                
                var value = arguments.FirstOrDefault().Value;

                var convertedValue = JsonConvert.SerializeObject(value);
                data = convertedValue;
            }

            //var user=context.HttpContext.User.Identity.Name;



            var user="ok";


            if(context.HttpContext.Session.GetString("NomeUtilizador")==null){
                user="anonimo";

            }else{
                user=context.HttpContext.Session.GetString("NomeUtilizador");
            }

            //var ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
            var ipAddress  = context.HttpContext.Connection.RemoteIpAddress.ToString();

            SalvarNaBaseDeDados(data,url,user,ipAddress);
          
        }

        public void SalvarNaBaseDeDados(string dados, string url, string nomeUtilizador, string enderecoIp){
            var logAtividade = new LogAtividade{
                Dados = dados,
                Url = url,
                NomeUtilizador = nomeUtilizador,
                EnderecoIp = enderecoIp
            };

            context.LogAtividade.Add(logAtividade);
            context.SaveChanges();
        }
    }
}