using System;



namespace Functions.Models
{
    public enum CurrentCategory
    {
        niño = 1,
        mujer = 2,
        hombre = 3
    };
    public class Combo
    {
        private int _ComboId;
        private int _EventId;
        private string _Name; 
        private int _Precio;
        private CurrentCategory category;


        public Combo(string _Name, int _Event_Id, int _Precio, CurrentCategory _Category) { }

        public int ComboId
     {
         get { return ComboId; }
         set { ComboId = value; }
     }
        public int EventId
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

     public CurrentCategory Category
     {
         get { return Category; }
         set { Category = value; }
     }

    }
  
        
}
