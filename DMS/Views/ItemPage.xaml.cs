
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DMS.CoreBusiness;
using DMS.Models;
using DMS.UseCases.Interface;

namespace DMS.Views;

public partial class ItemPage : ContentPage
{
    private readonly IViewItemUseCase _repository;
    public ItemPage(IViewItemUseCase repository)
    {
        InitializeComponent();
        _repository = repository;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        ItemSearch.Text = "";
        LoadItem();

    }

    private async Task LoadItem()
    {
        var items = new ObservableCollection<tblItem>(await _repository.ExecuteAsynac(string.Empty));
        itemList.ItemsSource = items;
    }

    private void ItemAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ItemAddPage));
    }

    private void ItemDelete_Clicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync(nameof(ItemDeletePage));
    }

    private async void itemList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (itemList.SelectedItem != null)
        {
            //Shell.Current.GoToAsync(nameof(ItemAddPage));

            var selectedItem = ((ItemDto)itemList.SelectedItem).Id;
            await Shell.Current.GoToAsync($"{nameof(ItemEditPage)}?Id={selectedItem}");
        }
    }

    private void itemList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        itemList.SelectedItem = null;
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ItemAddPage));
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var item = menuItem?.BindingContext as ItemDto;

        if (item != null)
        {
            ItemRepository.DeleteItem(item.Id);
        }
        LoadItem();
    }

    private void ItemSearch_TextChanged(object sender, TextChangedEventArgs e)
    {
        var dt = new ObservableCollection<ItemDto>(ItemRepository.SearchItem(((SearchBar)sender).Text));
        itemList.ItemsSource = dt;
    }
}