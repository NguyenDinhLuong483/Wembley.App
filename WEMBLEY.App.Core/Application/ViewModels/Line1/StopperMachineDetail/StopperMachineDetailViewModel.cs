using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;

namespace WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineDetail
{
    public class StopperMachineDetailViewModel : BaseViewModel
    {
        public StopperMachineFaultHistoryViewModel StopperMachineFaultHistory { get; set; }
        public StopperMachineMonitorViewModel StopperMachineMonitor { get; set; }

        public StopperMachineDetailViewModel(StopperMachineFaultHistoryViewModel stopperMachineFaultHistory, StopperMachineMonitorViewModel stopperMachineMonitor)
        {
            StopperMachineFaultHistory = stopperMachineFaultHistory;
            StopperMachineMonitor = stopperMachineMonitor;
        }
    }
}
