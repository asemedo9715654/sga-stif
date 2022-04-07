using Microsoft.AspNetCore.Mvc.Filters;

namespace sga_stif.Filtros
{
    public class SessaoFiltro : ActionFilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // var nomeController = context.ActionDescriptor.;
            // var nomeAction = context.ActionDescriptor.ActionName;
            // //var nomeController = filterContext.ActionDescriptor.ControllerDescriptor.;

            // if (filterContext.HttpContext.Session.Contents["username"] == null && nomeController == "Home")
            // {
            //     return;
            // }

              throw new NotImplementedException();
        }
    }
}