using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class ItemRepository
    {
        public static List<ItemDto> items = new List<ItemDto>()
        {
            new ItemDto { Id=1,Price=110, Name = "Mango", Description = "Sweet tropical stone fruit with fragrant orange flesh; great for fresh eating, smoothies, and desserts." },
            new ItemDto { Id=2,Price=130, Name = "Banana", Description = "Soft, naturally sweet, potassium-rich fruit; convenient snack and baking staple." },
            new ItemDto { Id=3,Price=120, Name = "Orange", Description = "Juicy, tangy citrus rich in vitamin C; ideal for fresh eating and fresh-squeezed juice." }
        };
        public static List<ItemDto> GetAllItems()
        {
            return items;
        }
        public static ItemDto getItemById(long id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            return new ItemDto { Id = item.Id, Name = item.Name, Code = item.Code, Description = item.Description, Price = item.Price };
        }

        public static void UpdateItem(long ItemId, ItemDto item)
        {
            if (ItemId != item.Id)
            {
                return;
            }
            var SingleItem = items.FirstOrDefault(i => i.Id == ItemId);
            if (SingleItem != null)
            {
                SingleItem.Name = item.Name;
                SingleItem.Code = item.Code;
                SingleItem.Description = item.Description;
                SingleItem.Price = item.Price;
            }
        }

        public static void AddItem(ItemDto item)
        {
            var maxId = items.Max(i => i.Id);
            item.Id = maxId + 1;
            item.Name = item.Name;
            item.Code = item.Code;
            item.Description = item.Description;
            item.Price = item.Price;
            items.Add(item);
        }

        public static void DeleteItem(long id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
        public static List<ItemDto> SearchItem(string Search)
        {
            var dt = items.Where(x => x.Name.ToLower().Contains(Search.ToLower())).ToList();
            return dt;

        }
    }
}
