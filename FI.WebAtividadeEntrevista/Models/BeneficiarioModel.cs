using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FI.WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long ID { get; set; }

        public string CPF { get; set; }

        [Display(Name = "Nome")]
        public string NOME { get; set; }

        public Cliente CLIENTE { get; set; }
    }
}