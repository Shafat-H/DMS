using System.Threading.Tasks;
using DMS.CoreBusiness;
using DMS.UseCases.Interface;

namespace DMS.Views;

public partial class ItemAddPage : ContentPage
{
    private readonly IViewItemUseCase _repository;

    private tblItem currentItem;
    public ItemAddPage(IViewItemUseCase repository)
    {
        InitializeComponent();
        _repository = repository;
    }

    private async void controlCtrl_onSave(object sender, EventArgs e)
    {
        await _repository.UpdateAsync(0, new tblItem
        {
            Name = controlCtrl.Name,
            Code = controlCtrl.ItemCode,
            Description = controlCtrl.Description,
            Price = decimal.Parse(controlCtrl.Price)
        });
        await Shell.Current.GoToAsync("..");
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