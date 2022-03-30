using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Product")]
    public class Produto : Notifies

    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        public int Nome { get; set; }

        [Column("PRD_VALO")]
        [Display(Name = "Valor")]
        public int Valor { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "Estado")]
        public int Estado { get; set; }
    }
}
