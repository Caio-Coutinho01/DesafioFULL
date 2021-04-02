using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Domain.Models
{
    public class Entidades
    {

        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }

    }
}
