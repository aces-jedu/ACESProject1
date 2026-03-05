using ACES.CoreBusiness;
using ACES.UseCases.Inventories.Interfaces;
using ACES.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACES.UseCases.Inventories
{
    public class AddInvUseCase : IAddInvUseCase
    {
        private readonly IInvRepositories invRepositories;

        public AddInvUseCase(IInvRepositories invRepositories)
        {
            this.invRepositories = invRepositories;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            await this.invRepositories.AddInvAsync(inventory);
        }
    }
}
