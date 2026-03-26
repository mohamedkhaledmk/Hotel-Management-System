using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories.Interfaces
{
     public interface ILoginRepository
    {
        bool Verify(string tableName, string username, string password);
    }
}
