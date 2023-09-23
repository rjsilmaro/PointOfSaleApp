using Dapper;

namespace PointOfSaleLibrary.Data
{
    public interface ISqlDataAccess
    {
        Task SaveDataAsync(string storedProcedure, DynamicParameters data, string connectionStringName = "Default");
    }
}