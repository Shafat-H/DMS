using DMS.UseCases;
using DMS.View_MVVM;
using System.Threading.Tasks;

namespace DMS.View_MVVM;

public partial class Item_MVVM_Page : ContentPage
{
    public ItemsViewModel _repositoty { get; }
    public Item_MVVM_Page(ItemsViewModel repositoty)
    {
        InitializeComponent();
        _repositoty = repositoty;

        this.BindingContext = _repositoty;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _repositoty.LoadItem();
    }

}