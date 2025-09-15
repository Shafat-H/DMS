using System.Threading.Tasks;
using DMS.Models;

namespace DMS.Views;

public partial class ItemAddPage : ContentPage
{
    private ItemDto currentItem;
    public ItemAddPage()
    {
        InitializeComponent();
    }

    private void controlCtrl_onSave(object sender, EventArgs e)
    {
        ItemRepository.AddItem(new ItemDto
        {
            Name = controlCtrl.Name,
            Code = controlCtrl.ItemCode,
            Description = controlCtrl.Description,
            Price = decimal.Parse(controlCtrl.Price)
        });
        Shell.Current.GoToAsync("..");
    }

    private void controlCtrl_onCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ItemPage)}");
    }

    private void controlCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}