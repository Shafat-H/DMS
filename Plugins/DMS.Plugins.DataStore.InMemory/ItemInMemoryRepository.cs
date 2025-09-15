using DMS.CoreBusiness;
using DMS.UseCases.PluginsInterface;

namespace DMS.Plugins.DataStore.InMemory
{
    // All the code in this file is included in all platforms.
    public class ItemInMemoryRepository : IItemRepository
    {
        public static List<tblItem> items;
        public ItemInMemoryRepository()
        {
            items = new List<tblItem>()
            {
                new tblItem { Id=1,Price=110, Name = "Mango", Description = "Sweet tropical stone fruit with fragrant orange flesh; great for fresh eating, smoothies, and desserts." },
                new tblItem { Id=2,Price=130, Name = "Banana", Description = "Soft, naturally sweet, potassium-rich fruit; convenient snack and baking staple." },
                new tblItem { Id=3,Price=120, Name = "Orange", Description = "Juicy, tangy citrus rich in vitamin C; ideal for fresh eating and fresh-squeezed juice." }
            };
        }
        public Task<List<tblItem>> GetItemsAsync(string filterText)
        {
            var dt = items.Where(x => string.IsNullOrEmpty(filterText) || x.Name.ToLower().Contains(filterText.ToLower())).ToList();
            return Task.FromResult(dt);
        }
    }
}
