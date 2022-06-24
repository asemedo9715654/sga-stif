using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;

namespace sga_stif.Extensao
{
  public static class EnumExtensao
  {
    /// <summary>
    /// Get the Description from the DescriptionAttribute.
    /// </summary>
    /// <param name="enumValue"></param>
    /// <returns></returns>
    public static string PegarDescricao(this Enum enumValue)
    {
      return enumValue.GetType()
                 .GetMember(enumValue.ToString())
                 .First()
                 .GetCustomAttribute<DescriptionAttribute>()?
                 .Description ?? string.Empty;
    }



    public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
    {
      if (!typeof(T).IsEnum)
        return null;

      var description = enumValue.ToString();
      var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

      if (fieldInfo != null)
      {
        var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
        if (attrs != null && attrs.Length > 0)
        {
          description = ((DescriptionAttribute)attrs[0]).Description;
        }
      }

      return description;
    }




   





  }
}