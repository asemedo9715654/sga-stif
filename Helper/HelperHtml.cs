using Microsoft.AspNetCore.Razor.TagHelpers;
using sga_stif.Models;

namespace sga_stif.Helper
{



    // [HtmlTargetElement(Attributes = "IdMenu, IdAcao")]
    [HtmlTargetElement("Input", Attributes = "IdMenu, IdAcao")]
    public class DetermiCheckBoxMenuAcaoTH : TagHelper
    {
        public int IdMenu { get; set; }
        public int IdAcao { get; set; }

        private readonly ContextoBaseDados _context;

        public DetermiCheckBoxMenuAcaoTH(ContextoBaseDados context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Input";
            var menuAcao = _context.MenuAcao.FirstOrDefault(g => g.IdAcao == IdAcao && g.IdMenu == IdMenu);

            if (menuAcao != null)
                output.Content.SetHtmlContent("<input checked id=\"sfddsf\" type=\"checkbox\" onchange=\"EnviaDados(" +
                                              IdAcao + "," + IdMenu + ")\" />");
            else
                output.Content.SetHtmlContent("<input  id=\"sfddsf\" type=\"checkbox\" onchange=\"EnviaDados(" +
                                              IdAcao + "," + IdMenu + ")\" />");

        }
    }


}