using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gta.Application.ViewModel
{
   public class MainViewModel
    {
        /// <summary>
        /// Tradução variavel: Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Tradução variavel: Nome do Cliente
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tradução variavel: CPF do Cliente
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Tradução variavel: Título do Cliente
        /// </summary>
        public int TitleNumber { get; set; }
        /// <summary>
        /// Numero de parcelas
        /// </summary>
        public int NumParcel { get; set; }
        /// <summary>
        /// Tradução variavel: Valor da parcela
        /// </summary>
        public float VlrParcel { get; set; }
        /// <summary>
        /// Tradução variavel: Multa
        /// </summary>
        public float Fine { get; set; }
        /// <summary>
        /// Tradução variavel: Juros
        /// </summary>
        public float Fees { get; set; }
        /// <summary>
        /// Tradução variavel: Data de Vencimento
        /// </summary>
        public string DateDue { get; set; }

        /// <summary>
        /// Tradução variavel: Data de emissão
        /// </summary>
        public DateTime DateIssue { get; set; }
        /// <summary>
        /// Tradução variavel: Data de Criação
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Tradução variavel: Data em atraso
        /// </summary>
        public int dtLate { get; set; }
        /// <summary>
        /// Tradução variavel: Valor total com juros e multa
        /// </summary>
        public float ValTotal { get; set; }

    }
}
