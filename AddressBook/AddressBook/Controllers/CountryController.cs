using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AddressBook.Controllers
{
    public class CountryController : Controller
    {
        private readonly IConfiguration _configuration;

        public CountryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult CountryForm()
        {
            return View("CountryForm");
        }

        public IActionResult CountryList()
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString");

            // Using "using" statements to properly dispose of resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_Country_SelectAll";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        return View(table);
                    }
                }
            }

        }
        public IActionResult CountryDelete(int CountryID)
        {
            try
            {
                string connectionString = _configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_Country_DeleteByPk";
                    command.Parameters.Add("@CountryID", SqlDbType.Int).Value = CountryID;


                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "Country deleted successfully.";
                return RedirectToAction("CountryList");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the Country: " + ex.Message;
                return RedirectToAction("CountryList");
            }
        }
    }
}
