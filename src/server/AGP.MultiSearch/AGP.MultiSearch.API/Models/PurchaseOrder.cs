﻿namespace AGP.MultiSearch.API.Models;

public class PurchaseOrder
{
    public int PurchaseOrderID { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Supplier { get; set; }
    public string MaterialID { get; set; }
    public string MaterialName { get; set; }
    public int Quantity { get; set; }
    public decimal TotalCost { get; set; }
}
