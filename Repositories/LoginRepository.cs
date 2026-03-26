using Dapper;
using HotelManagementSystem.Data;
using HotelManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public bool Verify(string tableName, string username, string password)
        {
            string t = tableName.ToLower() == "kitchen" ? "kitchen" : "Frontends";
            using var conn = DbConnectionFactory.GetLoginConnection();
            int res = conn.ExecuteScalar<int>(
                $"""
                select count(1) from {t} where username=@username and password=@password
                """
                , new {username,password});
            return res > 0;
        }
    }
}
