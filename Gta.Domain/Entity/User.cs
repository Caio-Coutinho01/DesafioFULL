using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gta.Domain.Entity
{
    public class User:Entidades
    {
        /// <summary>
        /// Tradução variavel: Nome do Cliente
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// Tradução variavel: CPF do Cliente
        /// </summary>
        [MaxLength(14)]
        public string CPF { get; set; }
        /// <summary>
        /// Tradução variavel: Número do título
        /// </summary>
        public int TitleNumber { get; set; }
    }
}
