using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;




namespace Functions.Test
{
 
    public class CatalogoTests
    {
       
      
        private static readonly string conn_str = ObtainKeyFromConnectToDatabase();
        
        [Fact]
        public async void InsertCombo()
        {
            string Name = "mycomboTestxxxx";
            int Precio = 100;
            var Category = Models.CurrentCategory.hombre;
            int EventId = 1;
            var value = await Catalogo.InsertComboIntoDatabaseWorker(conn_str, Name, EventId, Precio, Category);
            Assert.True(value == 1);
        }

        [Fact]
        public async void InsertEvento()
        {
            string NameEvento = "Dia de los muertos";
            string DescriptionEvent = "Se celebra en Mexico una vez al ano";
            DateTime dateEvent = DateTime.Now;
            string PaisEvent = "Mexico";
            var value = await Catalogo.InsertEventoIntoDatabaseWorker(conn_str, NameEvento, DescriptionEvent, dateEvent, PaisEvent);
            Assert.True(value == 1);
        }

        [Fact]
        public async void CheckExistEvento()
        {
            int EventId = 1;
            bool value = await Catalogo.CheckEventoExistIntoDatabaseWorker(conn_str, EventId);
            Assert.True(value==true);
        }

        private static string ObtainKeyFromConnectToDatabase()
        {
              var data = System.IO.File.ReadAllText("../../../auth.json");
              var datades = (JObject)JsonConvert.DeserializeObject(data);
              string key = (string)datades["sqldb_connection"];
              return key;
        }
       
    }

}
