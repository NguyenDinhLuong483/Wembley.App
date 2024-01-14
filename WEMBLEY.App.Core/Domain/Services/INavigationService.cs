using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;

namespace WEMBLEY.App.Core.Domain.Services
{
    public interface INavigationService
    {
        public BaseViewModel CurrentViewModel { get; }

        void NavigateTo<T>() where T : BaseViewModel;
    }
}
