using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gta.Application.ViewModel
{
    public class UserViewModel
    {
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
        /// Tradução variavel: Data de Criação
        /// </summary>
    }
}
