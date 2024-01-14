using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.Services
{
    public class NavigationService : BaseViewModel, INavigationService
    {
        private BaseViewModel? _currentViewModel;
        private readonly Func<Type, BaseViewModel> _viewModelFactory;

        public BaseViewModel? CurrentViewModel
        {
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
            get => _currentViewModel;
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, BaseViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : BaseViewModel
        {
            BaseViewModel viewModel =  _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentViewModel = viewModel;
        }
    }
}
