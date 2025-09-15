using DMS.Models;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace DMS.Views;

[QueryProperty(nameof(Ids), "Id")]
public partial class ItemEditPage : ContentPage
{
    private ItemDto currentItem;
    public ItemEditPage()
    {
        InitializeComponent();
    }

    private void controlCtrl_onSave(object sender, EventArgs e)
    {
        ItemRepository.UpdateItem(currentItem.Id, new ItemDto
        {
            Id = currentItem.Id,
            Name = controlCtrl.Name,
            Code = controlCtrl.ItemCode,
            Description = controlCtrl.Description,
            Price = decimal.Parse(controlCtrl.Price)
        });

        Shell.Current.GoToAsync("..");
    }

    private void controlCtrl_onCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void controlCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
    public long Ids
    {
        set
        {
            currentItem = ItemRepository.getItemById(value);
            if (currentItem != null)
            {
                controlCtrl.Name = currentItem.Name;
                controlCtrl.ItemCode = currentItem.Code;
                controlCtrl.Description = currentItem.Description;
                controlCtrl.Price = currentItem.Price.ToString();
            }
        }
    }
}