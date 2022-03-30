using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        { Notificacoes = new List<Notifies>(); }

        [NotMapped]//A criação dessa tabela não deixa os itens nela serem enviados ao banco de dados.
        public String NomePropriedade { get; set; }

        [NotMapped]
        public String mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notificacoes;

        public bool ValidaPriedadeString(string valor, String nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    mensagem = "Valor deve ser maior que 0.",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaPriedadeString(int valor, String nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    mensagem = "Valor deve ser maior que 0.", 
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaPriedadeString(decimal valor, String nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    mensagem = "Valor deve ser maior que 0.",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
