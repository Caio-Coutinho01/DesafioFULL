using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gta.Application.ViewModel
{
    public class ParcelViewModel
    {
        public int Id { get; set; }
        /// <summary>
        ///Tradução variavel: Id do usuario para vincular com a parcela.
        /// </summary>
        
        public int IdUser { get; set; }
        /// <summary>
        /// Tradução variavel: Numero da parcela (Soma das parcelas)
        /// </summary>
        ///   
        public int NumParcel { get; set; }
        /// <summary>
        /// Tradução variavel: Valor da parcela
        /// </summary>
        
        public int VlrParcel { get; set; }
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
        /// <summary>
        /// Tradução variavel: Data de Criação
        /// </summary>
        public DateTime DateCreated { get; set; }

    }
}
