using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class Utilizador : EntidadeBase
    {
        [Key]
        public int IdUtilizador { get; set; }
        public string Nome { get; set; }
        public string NomeUtilizador { get; set; }
        public string Apelido { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public byte[]? Foto { get; set; }
        public string PalavraPasse { get; set; }

        //chaves estrangeiras

        [ForeignKey("Perfil")]
        public int? IdPerfil { get; set; }
        //propriedades de navegação
        public virtual Perfil? Perfil { get; set; }


        public string PegarNomeCompleto()
        {
            return Nome + " " + Apelido;
        }
        public string PegarLinkFoto()
        {
            if (Foto != null)
            {

                var aux = Convert.ToBase64String(Foto);
                string imageDataURL = string.Format("data:image/png;base64,{0}", aux);
                return imageDataURL;
            }
            else
            {
                return "../../dist/img/default-150x150.png";

            }
        }
    }
}