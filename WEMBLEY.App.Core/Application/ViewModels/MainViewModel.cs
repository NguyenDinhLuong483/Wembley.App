﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WEMBLEY.App.Core.Application.ViewModels.Home;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private INavigationService? _navigationService;
        public INavigationService? NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoadMainWindowCommand {  get; set; }

        public MainViewModel(INavigationService? navigationService)
        {
            NavigationService = navigationService;

            LoadMainWindowCommand = new RelayCommand(NavigationService.NavigateTo<HomeNavigationViewModel>);
        }
        
    }
}
