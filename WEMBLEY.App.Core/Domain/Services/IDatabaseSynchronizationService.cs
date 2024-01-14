using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEMBLEY.App.Core.Domain.Services
{
    public interface IDatabaseSynchronizationService
    {
        Task SynchronizeReferencesData();
        Task SynchronizeDevicesData();
        Task SynchronizeHomeData();
    }
}
