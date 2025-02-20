using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class UsersController : Controller
    {
        private IConfiguration configuration;

        public UsersController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UsersForm()
        {
            return View();
        }
        public IActionResult UsersList()
        {

            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_User_SelectAll";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        
        }
        public IActionResult UserDelete(int UserID)
        { 
            try
            {
                string connectionString = configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_User_DeleteByPk";
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;


                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "User deleted successfully.";
                return RedirectToAction("UsersList");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the User: " + ex.Message;
                return RedirectToAction("UsersList");
            }
        }
    }
}
