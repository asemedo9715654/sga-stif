﻿using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class EmailTodosViewModel
    {
        public string Assunto { get; set; }
        [Display(Name = "Texto do e-mail")]
        public string CorpoDoEmail { get; set; }
    }
}
