using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class CityController : Controller
    {
        private IConfiguration configuration;

        public CityController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityForm()
        {
            return View();
        }

        public IActionResult CityList()
        {
           
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_City_SelectAll";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        
        }
        public IActionResult CityDelete(int CityID)
        {
            try
            {
                string connectionString = configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_City_DeleteByPK";
                    command.Parameters.Add("@CityID", SqlDbType.Int).Value = CityID;


                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "City deleted successfully.";
                return RedirectToAction("CityList");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the city: " + ex.Message;
                return RedirectToAction("CityList");
            }
        }
    }
}
