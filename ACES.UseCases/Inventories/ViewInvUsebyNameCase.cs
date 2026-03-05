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
        private readonly IInvRepositories invRepositories;

        public ViewInvbyNameUseCase(IInvRepositories invRepositories)
        {
            this.invRepositories = invRepositories;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await invRepositories.GetInvbyNameAsync(name);
        }
    }
}
