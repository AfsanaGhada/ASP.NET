using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using AddressBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AddressBook.Controllers
{
    public class CityController : Controller
    {
        private readonly IConfiguration _configuration;

        public CityController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult CityList()
        {
            using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
            connection.Open();

            SqlCommand command = new SqlCommand("PR_City_SelectAll", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        }

        public IActionResult CityForm(int? CityID)
        {
            CityModel model = new CityModel();

            if (CityID != null)
            {
                using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
                connection.Open();

                SqlCommand command = new SqlCommand("PR_City_SelectByPK", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@CityID", CityID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    model = new CityModel
                    {
                        CityID = Convert.ToInt32(reader["CityID"]),
                        CountryID = Convert.ToInt32(reader["CountryID"]),
                        StateID = Convert.ToInt32(reader["StateID"]),
                        CityName = reader["CityName"].ToString(),
                        STDCode = reader["STDCode"].ToString(),
                        PinCode = reader["PinCode"].ToString(),
                        UserID = (int)reader["UserID"]
                    };
                }
            }

            ViewBag.CountryList = GetCountryDropdown();

            // Use model.CountryID if available, else 0 (or null handled in your helper)
            ViewBag.StateList = GetStateDropdown(model.CountryID ?? 0);

            return View(model);
        }


        [HttpPost]
        public IActionResult CitySave(CityModel model)
        {
            if (!ModelState.IsValid)
                return View("CityForm", model);

            using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.StoredProcedure
            };

            if (model.CityID == 0)
            {
                command.CommandText = "PR_City_Insert";
            }
            else
            {
                command.CommandText = "PR_City_UpdateByPK";
                command.Parameters.AddWithValue("@CityID", model.CityID);
            }

            command.Parameters.AddWithValue("@CityName", model.CityName);
            command.Parameters.AddWithValue("@StateID", model.StateID);
            command.Parameters.AddWithValue("@CountryID", model.CountryID);
            command.Parameters.AddWithValue("@STDCode", model.STDCode ?? "");
            command.Parameters.AddWithValue("@PinCode", model.PinCode ?? "");
            command.Parameters.AddWithValue("@UserID", 1); // Replace with actual UserID if using session/login

            // ✅ Add this line to fix the exception
            command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

            command.ExecuteNonQuery();
            TempData["SuccessMessage"] = "City saved successfully.";
            return RedirectToAction("CityList");
        }


        public IActionResult CityDelete(int CityID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
                connection.Open();

                SqlCommand command = new SqlCommand("PR_City_DeleteByPK", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@CityID", CityID);
                command.ExecuteNonQuery();

                TempData["SuccessMessage"] = "City deleted successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error deleting city: " + ex.Message;
            }

            return RedirectToAction("CityList");
        }

        private List<SelectListItem> GetCountryDropdown()
        {
            List<SelectListItem> list = new();
            using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
            connection.Open();

            SqlCommand command = new SqlCommand("PR_Country_SelectForDropDown", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SelectListItem
                {
                    Value = reader["CountryID"].ToString(),
                    Text = reader["CountryName"].ToString()
                });
            }

            return list;
        }
        private List<SelectListItem> GetStateDropdown(int? countryId = null)
        {
            List<SelectListItem> list = new();

            using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));
            connection.Open();

            SqlCommand command = new SqlCommand("PR_State_SelectForDropDownByCountryID", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@CountryID", countryId ?? 0);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new SelectListItem
                {
                    Value = reader["StateID"].ToString(),
                    Text = reader["StateName"].ToString()
                });
            }

            return list;
        }


    }
}
