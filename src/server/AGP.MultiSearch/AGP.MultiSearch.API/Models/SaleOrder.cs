using AGP.MultiSearch.API.Utils;

using Newtonsoft.Json;

namespace AGP.MultiSearch.API.Models;

public class SaleOrder
{
    public int SalesOrderID { get; set; }

    [JsonConverter(typeof(CustomDateFormatConverter))]
    public DateTime DeliveryDate { get; set; }
    public string Customer { get; set; }
    public string MaterialID { get; set; }
    public string MaterialName { get; set; }
    public int Quantity { get; set; }
    public decimal TotalValue { get; set; }
}
