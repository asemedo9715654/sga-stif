using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace sga_stif.Filtros
{
    public class SessaoFiltro : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = (string)context.RouteData.Values["Controller"];
            var action = (string)context.RouteData.Values["Action"];

            if (action == "GetEmployeeList")
                return;


            if (controller == "Login" && context.HttpContext.Session.GetString("NomeUtilizador") == null)
            {

                return;
            }


            if (context.HttpContext.Session.GetString("NomeUtilizador") == null)
            {
                // if (context.HttpContext.Request.IsAjaxRequest())
                // {
                //     filterContext.HttpContext.Response.Clear();
                //     filterContext.Result = new JsonResult() { Data = new { success = true } };
                // }

                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Login" }, { "Action", "Logout" } });
                return;

            }


            if (context.HttpContext.Session.GetString("NomeUtilizador") != null && controller == "Login")
            {
                if (action == "Logout")
                {

                }
                else
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Socio" }, { "Action", "ListaSocio" } });
                    return;
                }

            }



            //throw new NotImplementedException();
        }
    }
}