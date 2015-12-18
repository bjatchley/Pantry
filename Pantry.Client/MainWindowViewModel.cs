using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Client.PantryServices;
using Pantry.Data.DTOs;
using Pantry.Data.Models;
using Prism.Mvvm;

namespace Pantry.Client
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<Account> _Accounts;
        private ObservableCollection<Recipe> _Recipes;
        private ObservableCollection<AvailableIngredient> _AvailableIngredients;
        private AvailableIngredient _IngredientToAdd = new AvailableIngredient();

        public MainWindowViewModel()
        {
            LoadAccountsAndRecipes();
        }
        public ObservableCollection<Account> Accounts
        {
            get
            {
                return _Accounts;
            }
            set
            {
                SetProperty(ref _Accounts, value);
            }
        }
        public ObservableCollection<Recipe> Recipes
        {
            get
            {
                return _Recipes;
            }
            set
            {
                SetProperty(ref _Recipes, value);
            }
        }
        public ObservableCollection<AvailableIngredient> AvailableIngredients
        {
            get
            {
                return _AvailableIngredients;
            }
            set
            {
                SetProperty(ref _AvailableIngredients, value);
            }
        }

        public AvailableIngredient IngredientToAdd
        {
            get
            {
                return _IngredientToAdd;
            }
            set { SetProperty(ref _IngredientToAdd, value); }
        }

        private async void LoadAccountsAndRecipes()
        {
            PantryServiceClient proxy = new PantryServiceClient();
            Accounts = await proxy.GetAccountsAsync();
            Recipes = await proxy.GetRecipesAsync();

            proxy.Close();
        }
    }
}
