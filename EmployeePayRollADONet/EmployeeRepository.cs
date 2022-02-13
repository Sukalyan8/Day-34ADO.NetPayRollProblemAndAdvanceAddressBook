using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRollADONet
{
    public class EmployeeRepository
    {
        // For Database Connection
        public static string connection = @"Server=.;Database=PayRoll_Service;Trusted_Connection=True;";
        SqlConnection sqlConnection = new SqlConnection(connection);
        
    }
}