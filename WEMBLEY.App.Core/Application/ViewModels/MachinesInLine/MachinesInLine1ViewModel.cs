using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WEMBLEY.App.Core.Application.Services;
using WEMBLEY.App.Core.Application.ViewModels.Line1;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineDetail;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Models;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.ViewModels.MachinesInLine
{
    public class MachinesInLine1ViewModel : BaseViewModel
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
        private EMachineStatus status;
        public EMachineStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                switch (value)
                {
                    case EMachineStatus.Run:
                        {
                            ColorBack = "#3EB17F";
                            break;
                        }
                    case EMachineStatus.Off:
                        {
                            ColorBack = "#BBBBBB";
                            break;
                        }
                    case EMachineStatus.Alarm:
                        {
                            ColorBack = "#ED5152";
                            break;
                        }
                    case EMachineStatus.Idle:
                        {
                            ColorBack = "#FAAF24";
                            break;
                        }
                    case EMachineStatus.Setup:
                        {
                            ColorBack = "#8B72C8";
                            break;
                        }
                    default:
                        {
                            ColorBack = "#394963";
                            break;
                        }
                }
            }
        }
        public string ColorBack { get; set; } = "#394963";
        public ICommand NavigateToStopperMachineViewCommand { get; set; }
        public ICommand LoadMachinesInLine1ViewCommand {  get; set; }
        public MachinesInLine1ViewModel(INavigationService navigationService) 
        {
            NavigationService = navigationService;
            NavigateToStopperMachineViewCommand = new RelayCommand(NavigationService.NavigateTo<StopperMachineViewModel>);
            LoadMachinesInLine1ViewCommand = new RelayCommand(LoadMachinesInLine1View);
            
        }
        private void LoadMachinesInLine1View()
        {

        }
    }
}
