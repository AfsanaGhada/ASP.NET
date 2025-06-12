using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class StateController : Controller
    {
        private IConfiguration configuration;

        public StateController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult StateForm()
        {
            return View();
        }
        public IActionResult StateList()
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_State_SelectAll";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        }
        public IActionResult StateDelete(int StateID)
        {
            try
            {
                string connectionString = configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_State_DeleteByPk";
                    command.Parameters.Add("@StateID", SqlDbType.Int).Value = StateID;


                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "City deleted successfully.";
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the city: " + ex.Message;
                return RedirectToAction("StateList");
            }
        }
    }
}
