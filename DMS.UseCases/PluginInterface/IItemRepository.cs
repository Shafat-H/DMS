using DMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.UseCases.PluginsInterface
{
    public interface IItemRepository
    {
        Task<List<tblItem>> GetItemsAsync(string filterText);
    }
}
