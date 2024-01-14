using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;

namespace WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineReport
{
    public class ReportNavigationViewModel : BaseViewModel
    {
        public ReportForShiftViewModel ReportForShiftViewModel { get; set; }
        public ReportLongTimeViewModel ReportLongTimeViewModel { get; set; }

        public ReportNavigationViewModel(ReportForShiftViewModel reportForShiftViewModel, ReportLongTimeViewModel reportLongTimeViewModel)
        {
            ReportForShiftViewModel = reportForShiftViewModel;
            ReportLongTimeViewModel = reportLongTimeViewModel;
        }
    }
}
