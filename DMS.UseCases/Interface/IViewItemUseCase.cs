using DMS.CoreBusiness;

namespace DMS.UseCases.Interface
{
    public interface IViewItemUseCase
    {
        Task<List<tblItem>> ExecuteAsynac(string filterText);
        Task UpdateAsync(long ItemId, tblItem item);
        Task DeleteAsync(long id);
        Task<tblItem> GetAsync(long id);

    }
}