using DMS.CoreBusiness;
using DMS.UseCases.Interface;
using DMS.UseCases.PluginsInterface;

namespace DMS.UseCases
{
    // All the code in this file is included in all platforms.
    public class ViewItemUseCase : IViewItemUseCase
    {
        public readonly IItemRepository _itemRepository;
        public ViewItemUseCase(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<List<tblItem>> ExecuteAsynac(string filterText)
        {
            return await _itemRepository.GetItemsAsync(filterText);
        }
    }
}
