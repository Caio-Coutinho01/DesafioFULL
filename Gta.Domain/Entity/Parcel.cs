using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Domain.Entity
{
   public class Parcel:Entidades
    {
        /// <summary>
        ///Tradução variavel: Id do usuario para vincular com a parcela.
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        ///Tradução variavel: Numero da parcela.
        /// </summary>
        public int NumParcel { get; set; }
        /// <summary>
        /// Tradução variavel: Valor Total (Soma das parcelas)
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
        public DateTime DateDue { get; set; }
        /// <summary>
        /// Tradução variavel: Data de emissão
        /// </summary>
        public DateTime DateIssue { get; set; }
    }
}
