using ACES.CoreBusiness;
using ACES.UseCases.PluginInterfaces;

namespace ACES.Plugins.InMemory
{
    public class InvRepositories : IInvReporsitories
    {
        private List<Inventory> _inventories;
        public InvRepositories()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InvId = 1, InvName = "Motherboard", Quantity = 20, Price = 5 },
                new Inventory { InvId = 1, InvName = "Ram", Quantity = 10, Price = 2 },
                new Inventory { InvId = 1, InvName = "CPU", Quantity = 30, Price = 10 },
            };
        }
        public async Task<IEnumerable<Inventory>> GetInvbyNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_inventories);
            return _inventories.Where(x => x.InvName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
