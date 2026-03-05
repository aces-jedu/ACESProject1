using ACES.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACES.UseCases.PluginInterfaces
{
    public interface IInvReporsitories
    {
        Task AddInvAsync(Inventory inventory);
        Task <IEnumerable<Inventory>>GetInvbyNameAsync(string name);
    }
}
