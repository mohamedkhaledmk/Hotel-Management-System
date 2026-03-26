using Dapper;
using HotelManagementSystem.UI;
using System.Data;

namespace HotelManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }

    public class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
    {
        public override void SetValue(IDbDataParameter parameter, DateOnly value)
            => parameter.Value = value.ToDateTime(TimeOnly.MinValue);

        public override DateOnly Parse(object value)
            => DateOnly.FromDateTime((DateTime)value);
    }

    #region Add Migration And Update Database Steps
    // 1. Delete the Migration Folder.

    // 2. Configure DB Connection Strings
        /// First Change the initial catalog inside "App.config" to the database you are using
        /// Change the Data Source= "" for each connection string to the server you are using
        /// if you are using sql server express don't change it

    // 3. Add Your Migrations
        /// Add-Migration InitFrontend -Context FrontendReservationContext -OutputDir Migrations/FrontendReservation
        /// Add-Migration InitLogin -Context LoginManagerContext -OutputDir Migrations/LoginManager

    // 4. Update Your DB Based On Your Migrations
        /// Update-Database -Context FrontendReservationContext
        /// Update-Database -Context LoginManagerContext 
    #endregion
}