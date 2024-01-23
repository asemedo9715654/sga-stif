using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.Vlidacao
{
  public class ValidacaoRangeData : RangeAttribute
  {
    public ValidacaoRangeData()
      : base(typeof(DateTime),
              DateTime.Now.AddYears(-80).ToShortDateString(),
              DateTime.Now.AddYears(-18).ToShortDateString())
    { }
  }

}