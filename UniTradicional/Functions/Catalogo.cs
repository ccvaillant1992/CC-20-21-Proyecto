using Functions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Functions
{
    public static class Catalogo
    {


        [FunctionName("CatalogoFunction")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "todo1")] HttpRequest req,
            ILogger log)
        {

             string NameCombo = "mycomboTest";
             int PrecioCombo = 10;
             int EventId = 1;
             string NameEvento = "Carnavales de la Habana"; 
             string DescriptionEvent = "Carnavales de la Habana";
             DateTime dateEvent = DateTime.Today;
             string PaisEvent = "Cuba";

            log.LogInformation($"We will Insert into the Table Combo now");
            await InsertIntoDatabase( NameCombo,  EventId, PrecioCombo,  NameEvento,  DescriptionEvent,  dateEvent, PaisEvent,
             log);

            string var = "You are managing the catalog ";
            return new OkObjectResult(var);

        }    // Get the connection string from app settings and use it to create a connection.

        public static async Task<IActionResult> InsertIntoDatabase(
            string NameCombo, int EventId, int PrecioCombo, string NameEvento, string DescriptionEvent, DateTime dateEvent, string PaisEvent,
            ILogger log)
        {

            var str = Environment.GetEnvironmentVariable("sqldb_connection");
            log.LogInformation($"We will connect to the Database now");
            await InsertEventoIntoDatabaseWorker(str, NameEvento, DescriptionEvent, dateEvent, PaisEvent);
            bool result= await CheckEventoExistIntoDatabaseWorker(str, EventId);
            if (result)
            {
                await InsertComboIntoDatabaseWorker(str, NameCombo, EventId, PrecioCombo);
            }


            string var = "You recently added one combo";
            return new OkObjectResult(var);
        }

        public static async Task<int> InsertComboIntoDatabaseWorker(string conn_str,  string Name, int EventId, int Precio)
        {
            using (SqlConnection conn = new SqlConnection(conn_str))
            {

                conn.Open();
                
                var text = "INSERT INTO [dbo].[Combo] ([EventId],[NameCombo],[Precio],[Category])" + "VALUES ( @EventId, @Name, @Precio, @category)";

                using (SqlCommand cmd = new SqlCommand(text, conn))
                {
                    cmd.Parameters.AddWithValue("@EventId", EventId);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Precio", Precio);
                    cmd.Parameters.AddWithValue("@category", Combo.CurrentCategory.hombre);
                    // Execute the command and log the # rows affected.
                    var rows = await cmd.ExecuteNonQueryAsync();
                    conn.Close();
                    return rows;
                }

            }
        }

        public static async Task<int> InsertEventoIntoDatabaseWorker(string conn_str, string NameEvento, string DescriptionEvent, DateTime dateEvent, string PaisEvent)
        {
            using (SqlConnection conn = new SqlConnection(conn_str))
            {

                conn.Open();

                var text = "INSERT INTO [dbo].[Evento] ([NameEvento],[Descripcion],[DateEvento],[Pais])" + "VALUES ( @NameEvento, @DescriptionEvent, @dateEvent, @PaisEvent)";

                using (SqlCommand cmd = new SqlCommand(text, conn))
                {
                    cmd.Parameters.AddWithValue("@NameEvento", NameEvento);
                    cmd.Parameters.AddWithValue("@DescriptionEvent", DescriptionEvent);
                    cmd.Parameters.AddWithValue("@dateEvent", dateEvent);
                    cmd.Parameters.AddWithValue("@PaisEvent", PaisEvent);
                    // Execute the command and log the # rows affected.
                    var rows = await cmd.ExecuteNonQueryAsync();
                    conn.Close();
                    return rows;
                }

            }
        }

        public static async Task<bool> CheckEventoExistIntoDatabaseWorker(string conn_str, int EventId)
        {
            using (SqlConnection conn = new SqlConnection(conn_str))
            {

                conn.Open();

                var text = "SELECT * FROM [dbo].[Evento] where EventId = " + EventId ;

                using (SqlCommand cmd = new SqlCommand(text, conn))
                {

                    // Execute the command and log the # rows affected.
                    SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync();
                    await sqlDataReader.ReadAsync();
                   
                    if (sqlDataReader.HasRows)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }

            }
        }
    }
}
