using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HotelManagementSystem.Data
{
    public static class DbConnectionFactory
    {
        public static SqlConnection GetFrontendConnection() =>
            new SqlConnection(
                ConfigurationManager.ConnectionStrings["FrontendReservationConnection"]?.ConnectionString
                );
        public static SqlConnection GetLoginConnection() =>
            new SqlConnection(
                ConfigurationManager.ConnectionStrings["LoginManagerConnection"]?.ConnectionString
            );
    }
}
