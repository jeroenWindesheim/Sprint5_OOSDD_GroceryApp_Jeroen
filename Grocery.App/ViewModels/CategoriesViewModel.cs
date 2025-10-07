using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public partial class CategoriesViewModel : BaseViewModel
{
    public ObservableCollection<Category> CategoryLists { get; set; }
    private readonly ICategoryService _categoryService;
    
    

    public CategoriesViewModel(ICategoryService categoryService)
    {
        Title = "Categories";
        _categoryService = categoryService;
        CategoryLists = new(_categoryService.GetAll());
        
    }
    
    public override void OnAppearing()
    {
        base.OnAppearing();
        CategoryLists = new(_categoryService.GetAll());
    }

    public override void OnDisappearing()
    {
        base.OnDisappearing();
        CategoryLists.Clear();
    }
}