using DMS.CoreBusiness;
using DMS.UseCases.Interface;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace DMS.Views;

[QueryProperty(nameof(Ids), "Id")]
public partial class ItemEditPage : ContentPage
{
    private readonly IViewItemUseCase _repository;
    private tblItem currentItem;
    public ItemEditPage(IViewItemUseCase repository)
    {
        InitializeComponent();
        _repository = repository;
    }

    private void controlCtrl_onSave(object sender, EventArgs e)
    {
        _repository.UpdateAsync(currentItem.Id, new tblItem
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
            var currentItem = _repository.GetAsync(value).GetAwaiter().GetResult(); // Use await properly

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