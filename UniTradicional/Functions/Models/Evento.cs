using System;
using System.Collections.Generic;



namespace Functions.Models
{
    public class Evento
    {
        private int _EventId;
        private string _Name;
        private DateTime _Date;
        private string _Description;
        private string _Pais;
        private List<Combo> _listcombos;

         public int EventId
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
