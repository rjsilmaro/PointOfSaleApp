namespace PointOfSaleLibrary.Models;

public class CustomerPurchaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Item { get; set; }
    public decimal Cost { get; set; }
}
