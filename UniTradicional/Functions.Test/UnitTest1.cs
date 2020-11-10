using System;
using Xunit;



namespace Functions.Test
{
 
    public class CatalogoTests
    {
        [Fact]
        public async void InsertCombo()
        {
            string Name = "mycomboTestxxxx";
            int Precio = 100;
            int EventId = 1;
            string conn_str = "Server=tcp:catalogoserver.database.windows.net,1433;Initial Catalog=catalogoDatabase;Persist Security Info=False;User ID=adminuser;Password=Qwertyuiop.123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var value = await Catalogo.InsertComboIntoDatabaseWorker(conn_str, Name, EventId, Precio);
            Assert.True(value == 1);
        }

        [Fact]
        public async void InsertEvento()
        {
            string NameEvento = "Dia de los muertos";
            string DescriptionEvent = "Se celebra en Mexico una vez al a�o";
            DateTime dateEvent = DateTime.Now;
            string PaisEvent = "Mexico";
            string conn_str = "Server=tcp:catalogoserver.database.windows.net,1433;Initial Catalog=catalogoDatabase;Persist Security Info=False;User ID=adminuser;Password=Qwertyuiop.123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var value = await Catalogo.InsertEventoIntoDatabaseWorker(conn_str, NameEvento, DescriptionEvent, dateEvent, PaisEvent);
            Assert.True(value == 1);
        }

        [Fact]
        public async void CheckExistEvento()
        {
            int EventId = 1;
            string conn_str = "Server=tcp:catalogoserver.database.windows.net,1433;Initial Catalog=catalogoDatabase;Persist Security Info=False;User ID=adminuser;Password=Qwertyuiop.123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            bool value = await Catalogo.CheckEventoExistIntoDatabaseWorker(conn_str, EventId);
            Assert.True(value==true);
        }

    }

}
