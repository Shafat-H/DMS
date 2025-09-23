using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DMS.CoreBusiness;
using DMS.UseCases;
using DMS.UseCases.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.View_MVVM
{
    public partial class ItemsViewModel : ObservableObject
    {
        private readonly IViewItemUseCase _repository;
        public ObservableCollection<tblItem> items { get; set; }
        public ItemsViewModel(IViewItemUseCase repository)
        {
            _repository = repository;
            items = new ObservableCollection<tblItem>();
        }

        public async Task LoadItem()
        {
            items.Clear();
            var itemsList = new ObservableCollection<tblItem>(await _repository.ExecuteAsynac(null));

            foreach (var item in itemsList)
            {
                items.Add(item);
            }
        }
        [RelayCommand]
        public async void DeleteItem(long ContactId)
        {
            await _repository.DeleteAsync(ContactId);
            await LoadItem();

        }
    }
}
