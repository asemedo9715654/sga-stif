using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace sga_stif.Extensao
{
    public static class EnumExtensao
    {  
        public static string PegarDescricao(this Enum enumValue)
        {
            return enumValue.GetType()
                       .GetMember(enumValue.ToString())
                       .First()
                       .GetCustomAttribute<DescriptionAttribute>()?
                       .Description ?? string.Empty;
        }

        public static string PegarDescricao<T>(this T enumValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var descricao = enumValue.ToString();
            var informacaoDoCampo = enumValue.GetType().GetField(enumValue.ToString());

            if (informacaoDoCampo != null)
            {
                var atributos = informacaoDoCampo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (atributos != null && atributos.Length > 0) 
                    descricao = ((DescriptionAttribute)atributos[0]).Description;
            }

            return descricao;
        }

    }
}