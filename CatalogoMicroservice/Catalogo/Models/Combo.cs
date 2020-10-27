using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.Models
{
    public class Combo
    {
        public Guid ComboId { get; set; }
        public Guid EventId { get; set; }
        public string  Category { get; set; }
        public string Name { get; set; }
        public int Precio { get; set; }

    }
}
