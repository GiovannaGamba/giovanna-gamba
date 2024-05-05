using AGP.MultiSearch.API.Models;

namespace AGP.MultiSearch.API.Dtos;

public class SearchObjectsDto
{
    public List<Equipment> Equipments { get; set; }
    public List<Material> Materials { get; set; }
    public List<PurchaseOrder> PurchaseOrders { get; set; }
    public List<SaleOrder> SaleOrders { get; set; }
    public List<WorkForce> WorkForces { get; set; }

    public SearchObjectsDto()
    {
        Equipments = new List<Equipment>();
        Materials = new List<Material>();
        PurchaseOrders = new List<PurchaseOrder>();
        SaleOrders = new List<SaleOrder>();
        WorkForces = new List<WorkForce>();
    }
}
