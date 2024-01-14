using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WEMBLEY.App.Core.Application.ViewModels.Home;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineDetail;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineMFC;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineReport;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineStatus;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.ViewModels.Line1
{
    public class StopperMachineViewModel : BaseViewModel
    {
        public StopperMachineDetailViewModel StopperMachineDetailViewModel { get; set; }
        public MFCNavigationViewModel MFCNavigationViewModel { get; set; }
        public ReportNavigationViewModel ReportNavigationViewModel { get; set; }
        public StopperMachineStatusViewModel StopperMachineStatusViewModel { get; set; }

        public INavigationService _navigationService;
        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }
        }
        public ICommand NavigateBackToHomeViewCommand {  get; set; }

        public StopperMachineViewModel(StopperMachineDetailViewModel stopperMachineDetailViewModel, MFCNavigationViewModel mFCNavigationViewModel, ReportNavigationViewModel reportNavigationViewModel, StopperMachineStatusViewModel stopperMachineStatusViewModel, INavigationService navigationService)
        {
            StopperMachineDetailViewModel = stopperMachineDetailViewModel;
            MFCNavigationViewModel = mFCNavigationViewModel;
            ReportNavigationViewModel = reportNavigationViewModel;
            StopperMachineStatusViewModel = stopperMachineStatusViewModel;
            NavigationService = navigationService;
            NavigateBackToHomeViewCommand = new RelayCommand(NavigationService.NavigateTo<HomeNavigationViewModel>);
        }
    }
}
