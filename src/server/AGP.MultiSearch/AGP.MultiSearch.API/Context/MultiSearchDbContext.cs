using AGP.MultiSearch.API.Models;
using Newtonsoft.Json;
using System.Text;

namespace AGP.MultiSearch.API.Context;

public class MultiSearchDbContext
{
    public List<Equipment> Equipments { get; set; }
    public List<Material> Materials { get; set; }
    public List<PurchaseOrder> PurchaseOrders { get; set; }
    public List<SaleOrder> SaleOrders { get; set; }
    public List<WorkForce> WorkForces { get; set; }

    public MultiSearchDbContext()
    {
        Equipments = EquipamentsInitializer();
        Materials = MaterialsInitializer();
        PurchaseOrders = PurchaseOrdersInitializer();
        SaleOrders = SaleOrdersInitializer();
        WorkForces = WorkForcesInitializer();
    }

    private List<Equipment> EquipamentsInitializer()
    {
        string path = @"../../../../giovanna-gamba/data";
        string jsonFile = Directory.GetFiles(path, "equipments.json").Single();

        string jsonString = File.ReadAllText(jsonFile, Encoding.GetEncoding("ISO-8859-1"));

        List<Equipment> equipaments = JsonConvert.DeserializeObject<List<Equipment>>(jsonString);
        return equipaments;
    }

    private List<Material> MaterialsInitializer()
    {
        string path = @"../../../../giovanna-gamba/data";
        string jsonFile = Directory.GetFiles(path, "materials.json").Single();

        string jsonString = File.ReadAllText(jsonFile, Encoding.GetEncoding("ISO-8859-1"));

        List<Material> materials = JsonConvert.DeserializeObject<List<Material>>(jsonString);

        return materials;
    }

    private List<PurchaseOrder> PurchaseOrdersInitializer()
    {
        string path = @"../../../../giovanna-gamba/data";
        string jsonFile = Directory.GetFiles(path, "purchase_orders.json").Single();

        string jsonString = File.ReadAllText(jsonFile, Encoding.GetEncoding("ISO-8859-1"));

        List<PurchaseOrder> purchaseOrder = JsonConvert.DeserializeObject<List<PurchaseOrder>>(jsonString);

        return purchaseOrder;
    }

    private List<SaleOrder> SaleOrdersInitializer()
    {
        string path = @"../../../../giovanna-gamba/data";
        string jsonFile = Directory.GetFiles(path, "sales_orders.json").Single();

        string jsonString = File.ReadAllText(jsonFile, Encoding.GetEncoding("ISO-8859-1"));

        List<SaleOrder> saleOrders = JsonConvert.DeserializeObject<List<SaleOrder>>(jsonString);

        return saleOrders;
    }

    private List<WorkForce> WorkForcesInitializer()
    {
        string path = @"../../../../giovanna-gamba/data";
        string jsonFile = Directory.GetFiles(path, "workforce.json").Single();

        string jsonString = File.ReadAllText(jsonFile, Encoding.GetEncoding("ISO-8859-1"));

        List<WorkForce> workForce = JsonConvert.DeserializeObject<List<WorkForce>>(jsonString);

        return workForce;
    }
}