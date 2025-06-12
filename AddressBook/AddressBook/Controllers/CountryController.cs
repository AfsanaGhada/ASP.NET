using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AddressBook.Models;

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
        public IActionResult CountryAddEdit(CountryModel model)
        {
            if (ModelState.IsValid)
            {
                string connectionString = this._configuration.GetConnectionString("ConnectionString");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;

                if (model.CountryID == 0)
                {
                    command.CommandText = "PR_Country_Insert";
                }
                else
                {
                    command.CommandText = "PR_Country_UpdateByPK";
                    command.Parameters.Add("@CountryID", SqlDbType.Int).Value = model.CountryID;
                }
                command.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = model.CountryName;
                command.Parameters.Add("@CountryCode", SqlDbType.VarChar).Value = model.CountryCode;
                //command.Parameters.Add("@CountryCapital", SqlDbType.VarChar).Value = model.CountryCapital;
                //command.Parameters.Add("@UserID", SqlDbType.Int).Value = CommonVariable.UserID();
                command.ExecuteNonQuery();
                return RedirectToAction("CountryList");
            }

            return View("CountryForm", model);
        }
        public IActionResult CountrySearch(string CountryName, string CountryCode)
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString");
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_Country_Search";

                    command.Parameters.AddWithValue("@CountryName", (object)CountryName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@CountryCode", (object)CountryCode ?? DBNull.Value);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            ViewBag.CountryName = CountryName;
            ViewBag.CountryCode = CountryCode;
            return View("CountryList", table); // Reuse the existing view
        }


    }
}
