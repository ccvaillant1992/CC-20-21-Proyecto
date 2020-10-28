using System;
using System.Collections.Generic;


namespace Catalogo.Models
{
    public class Evento
    {
        private Guid EventId { get; set; }
        private string Name { get; set; }
        private DateTime Date { get; set; }
        private string Description { get; set; }
        private string Pais { get; set; }
        private List<Combo> listcombos { get; set; }
    }
}
