using AGP.MultiSearch.API.Context;
using AGP.MultiSearch.API.Dtos;
using AGP.MultiSearch.API.Models;

namespace AGP.MultiSearch.API.Services;

public class MainService : IMainService
{
    private readonly MultiSearchDbContext _context;

    public MainService(MultiSearchDbContext context)
    {
        _context = context;
    }

    public SearchObjectsDto Search(string textToSearch)
    {
        SearchObjectsDto searchObjectsDto = new SearchObjectsDto();

        if (string.IsNullOrWhiteSpace(textToSearch))
        {
            searchObjectsDto = SearchAll();
            return searchObjectsDto;
        }

        string textToSearchLower = textToSearch.ToLower();

        searchObjectsDto.Equipments = SearchEquipments(textToSearchLower);
        searchObjectsDto.Materials = SearchMaterials(textToSearchLower);
        searchObjectsDto.PurchaseOrders = SearchPurchaseOrders(textToSearchLower);
        searchObjectsDto.SaleOrders = SearchSalesOrders(textToSearchLower);
        searchObjectsDto.WorkForces = SearchWorkForces(textToSearchLower);

        return searchObjectsDto;
    }

    public SearchObjectsDto SearchAll()
    {
        return new SearchObjectsDto
        {
            Equipments = _context.Equipments,
            Materials = _context.Materials,
            PurchaseOrders = _context.PurchaseOrders,
            SaleOrders = _context.SaleOrders,
            WorkForces = _context.WorkForces,
        };
    }

    public List<Equipment> SearchEquipments(string textToSearchLower)
    {
        List<Equipment> equipments =
        [
            .. _context.Equipments.Where(x => x.EquipmentName.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.Equipments.Where(x => x.EquipmentID.ToLower().Contains(textToSearchLower)).ToList(),
        ];

        return equipments;
    }

    private List<Material> SearchMaterials(string textToSearchLower)
    {
        List<Material> materials =
        [
            .. _context.Materials.Where(x => x.MaterialID.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.Materials.Where(x => x.MaterialName.ToLower().Contains(textToSearchLower)).ToList(),
        ];

        return materials;
    }

    private List<PurchaseOrder> SearchPurchaseOrders(string textToSearchLower)
    {
        List<PurchaseOrder> purchaseOrders =
        [
            .. _context.PurchaseOrders.Where(x => x.PurchaseOrderID.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.DeliveryDate.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.Supplier.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.MaterialID.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.MaterialName.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.Quantity.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.PurchaseOrders.Where(x => x.TotalCost.ToString().Contains(textToSearchLower)).ToList(),
        ];

        return purchaseOrders;
    }

    private List<SaleOrder> SearchSalesOrders(string textToSearchLower)
    {
        List<SaleOrder> saleOrders =
        [
            .. _context.SaleOrders.Where(x => x.SalesOrderID.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.DeliveryDate.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.Customer.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.MaterialID.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.MaterialName.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.Quantity.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.SaleOrders.Where(x => x.TotalValue.ToString().Contains(textToSearchLower)).ToList(),
        ];

        return saleOrders;
    }

    private List<WorkForce> SearchWorkForces(string textToSearchLower)
    {
        List<WorkForce> workForces =
        [
            .. _context.WorkForces.Where(x => x.WorkforceID.ToString().Contains(textToSearchLower)).ToList(),
            .. _context.WorkForces.Where(x => x.Name.ToLower().Contains(textToSearchLower)).ToList(),
            .. _context.WorkForces.Where(x => x.Shift.ToLower().Contains(textToSearchLower)).ToList(),
        ];

        return workForces;

    }
}