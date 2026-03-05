using ACES.CoreBusiness;

namespace ACES.UseCases.Inventories.Interfaces
{
    public interface IAddInvUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}