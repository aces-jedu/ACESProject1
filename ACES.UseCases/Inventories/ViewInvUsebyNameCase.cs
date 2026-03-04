using ACES.CoreBusiness;
using ACES.UseCases.Inventories.Interfaces;
using ACES.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACES.UseCases.Inventories
{
    public class ViewInvbyNameUseCase : IViewInvbyNameUseCase
    {
        private readonly IInvReporsitories invReporsitories;

        public ViewInvbyNameUseCase(IInvReporsitories invReporsitories)
        {
            this.invReporsitories = invReporsitories;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await invReporsitories.GetInvbyNameAsync(name);
        }
    }
}
