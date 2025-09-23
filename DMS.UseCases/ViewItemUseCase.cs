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
        public async Task UpdateAsync(long ItemId, tblItem item)
        {
            await _itemRepository.UpdateItem(ItemId, item);
        }
        public async Task DeleteAsync(long id)
        {
            await _itemRepository.DeleteItem(id);
        }
        public async Task<tblItem> GetAsync(long id)
        {
            return await _itemRepository.getItemById(id);
        }
    }
}
