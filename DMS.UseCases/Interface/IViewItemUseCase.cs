using DMS.CoreBusiness;

namespace DMS.UseCases.Interface
{
    public interface IViewItemUseCase
    {
        Task<List<tblItem>> ExecuteAsynac(string filterText);
    }
}