using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace fitProTrackerTecTest.Services
{
    public class DataService
    {
        SqlConnection cnn = new SqlConnection("Data Source = DESKTOP-ANH9455\\SQLEXPRESS; Catalog=DBFitProTrackerTecTest; Integrated Security = true; ");
        
    }
}
