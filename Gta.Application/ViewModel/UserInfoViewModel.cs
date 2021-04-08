using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Application.ViewModel
{
   public class UserInfoViewModel
    {
        /// <summary>
        /// Tradução variavel: Título do Cliente
        /// </summary>
        public int TitleNumber { get; set; }
        /// <summary>
        /// Tradução variavel: Nome do Cliente
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tradução variavel: Quantidade de parcelas
        /// </summary>
        public int QntParcel { get; set; }
        /// <summary>
        /// Tradução variavel: Valor total das parcelas
        /// </summary>
        public float ValParcel{ get; set; }
        /// <summary>
        /// Tradução variavel: Dias em atraso
        /// </summary>
        public string DtDue { get; set; }
        /// <summary>
        /// Tradução variavel: Valor total com JUROS e MULTA incluso
        /// </summary>
        public float ValTotal { get; set; }


    }
}
