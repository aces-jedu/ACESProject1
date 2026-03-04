using ACES.CoreBusiness;

namespace ACES.UseCases.Inventories.Interfaces
{
    public interface IViewInvbyNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}