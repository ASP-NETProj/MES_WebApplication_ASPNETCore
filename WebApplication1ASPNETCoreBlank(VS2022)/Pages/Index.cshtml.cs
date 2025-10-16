using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using WebApplication1ASPNETCoreBlank_VS2022_.Models;

namespace WebApplication1ASPNETCoreBlank_VS2022_.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public string? SerialNumber { get; set; }

        public string? ResultMessage { get; set; }

        public List<TestStation> TestData { get; set; } = new();

        public void OnGet()
        {
            LoadData(null);
        }

        public void OnPost()
        {
            ResultMessage = $"You entered Serial Number: {SerialNumber}";
            LoadData(SerialNumber);
            SerialNumber = string.Empty;
            ModelState.Clear();
        }

        private void LoadData(string? serialNumber)
        {
            //string connectionString = "Data Source=DESKTOP-MR2VJ1G;Initial Catalog=TestStandDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";
            //string connectionString = "Data Source=DESKTOP-MR2VJ1G;Initial Catalog=TestStandDB;Integrated Security=True;TrustServerCertificate=True";
            string connectionString = "Data Source=DESKTOP-MR2VJ1G;Initial Catalog=TestStandDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    ResultMessage = "✅ Connected to MS SQL Server successfully.  ";

                    string query = @"SELECT UUT_SerialNumber, Station, Operator_Name, Status,
                                            Test_Date, Test_Time, Shipment_Date, Shipment_Time
                                     FROM Test_Station_1";

                    if (!string.IsNullOrEmpty(serialNumber))
                    {
                        //case-insensitive or partial match
                        query += " WHERE UUT_SerialNumber LIKE '%' + @SerialNumber + '%'";
                        //WHERE UUT_SerialNumber = @SerialNumber

                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(serialNumber))
                        {
                            cmd.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestData.Add(new TestStation
                                {
                                    //ID = reader.GetInt32(0),
                                    UUT_SerialNumber = reader.GetString(0),
                                    Station = reader.GetString(1),
                                    Operator_Name = reader.GetString(2),
                                    Status = reader.GetString(3),
                                    Test_Date = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                                    Test_Time = reader.IsDBNull(5) ? (TimeSpan?)null : reader.GetTimeSpan(5),
                                    Shipment_Date = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                                    Shipment_Time = reader.IsDBNull(7) ? (TimeSpan?)null : reader.GetTimeSpan(7)
                                });
                            }
                        }
                    }

                    if (TestData.Count == 0)
                    {
                        ResultMessage += "  ⚠ No data found for the given Serial Number.";
                    }
                }
            }
            catch (Exception ex)
            {
                ResultMessage = $"  ❌ Failed to connect to SQL Server. Error: {ex.Message}";
            }
        }
    }
}
