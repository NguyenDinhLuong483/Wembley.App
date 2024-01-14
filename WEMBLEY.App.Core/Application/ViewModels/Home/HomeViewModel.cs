using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WEMBLEY.App.Core.Application.ViewModels.MachinesInLine;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Models;

namespace WEMBLEY.App.Core.Application.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
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
        public double HerapinCapEfficiency { get; set; } = 0;
        public long HerapinCapAllCount { get; set; } = 0;
        public long HerapinCapGoodCount { get; set; } = 0;
        public long HerapinCapBadCount { get; set; } = 0;
        public TimeSpan? HerapinCapDurationTime { get; set; }
        public string HerapinCapProductName { get; set; } = "";
        public string HerapinCapReferenceName { get; set; } = "";
        public string HerapinCapLotId { get; set; } = "";
        public int HerapinCapLotSize { get; set; } = 0;


        public ICommand LoadHomeViewCommand { get; set; }
        public MachinesInLine1ViewModel MachinesInLine1 {  get; set; }
        
        public HomeViewModel(MachinesInLine1ViewModel machinesInLine1) 
        {
            MachinesInLine1 = machinesInLine1;
            LoadHomeViewCommand = new RelayCommand(LoadHomeView);
            
        }
        private void LoadHomeView()
        {
            
        }
    }
}
