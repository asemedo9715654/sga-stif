﻿using sga_stif.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
    public class DadosUtilizadorViewModel : BaseViewModel
    {
        [Key]
        public int IdUtilizador { get; set; }
        [Display(Name = "Nome")]
        public string NomeCompleto { get; set; }
        [Display(Name = "Nome do Utilizador")]
        public string NomeUtilizador { get; set; }
        public string Apelido { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Fotografia")]
        public string Foto { get; set; }
        public string PalavraPasse { get; set; }
        [Display(Name = "Nome do Perfil")]
        public string NomePerfil { get; set; }
    }
}
