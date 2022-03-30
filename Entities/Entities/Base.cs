using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Notifications;

namespace Entities.Entities
{
    public class Base : Notifies
    {
        /*A criação dessas duas colunas se dão peo motivo de que muitas vezes serão utilizadas durante o projeto.*/
        [Display(Name = "codigo")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
