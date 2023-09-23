using PointOfSaleLibrary.Models;

namespace PointOfSaleLibrary.Data;

public interface ICustomerData
{
    Task InsertPurchaseAsync(CustomerPurchaseModel data);
}