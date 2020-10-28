using System;


namespace Catalogo.Models
{
    public class Combo
    {
        private Guid ComboId { get; set; }
        private Guid EventId { get; set; }
        private enum  Category {niño, mujer, hombre}
        private string Name { get; set; }
        private int Precio { get; set; }
    }
}
