using System;


namespace Catalogo.Models
{
    public class Combo
    {
        private Guid _ComboId;
        private Guid _EventId;
        private string _Name; 
        private int _Precio;
        
        public Guid ComboId
     {
         get { return ComboId; }
         set { ComboId = value; }
     }
        public Guid EventId
     {
         get { return EventId; }
         set { EventId = value; }
     }
     
       public string Name
     {
         get { return Name; }
         set { Name = value; }
     }
       public int Precio
     {
         get { return Precio; }
         set { Precio = value; }
     }

    }
    public enum Category 
        {
            niño = 0, 
            mujer = 1, 
            hombre =2
        };
        
}
