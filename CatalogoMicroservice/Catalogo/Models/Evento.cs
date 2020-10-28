using System;
using System.Collections.Generic;


namespace Catalogo.Models
{
    public class Evento
    {
        private Guid _EventId;
        private string _Name;
        private DateTime _Date;
        private string _Description;
        private string _Pais;
        private List<Combo> _listcombos;

         public Guid EventId
     {
         get { return EventId; }
         set { EventId= value; }
     }
        public string Name
     {
         get { return Name; }
         set { Name = value; }
     }
    
        public DateTime Date
     {
         get { return Date; }
         set { Date = value; }
     }
     
       public string Description
     {
         get { return Description; }
         set { Description = value; }
     }
       public string Pais
     {
         get { return Pais; }
         set { Pais = value; }
     }
       public List<Combo> listcombos
     {
         get { return listcombos; }
         set { listcombos = value; }
     }

    }
}
