using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gta.Domain.Models
{
    public class Entidades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Tradução variavel: Data de criação do Cliente
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Tradução variavel: Data de edição/alteração do cliente
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Tradução variavel: Cliente Excluido/Inativado
        /// </summary>
        public bool IsDeleted { get; set; }
        
    }
}
