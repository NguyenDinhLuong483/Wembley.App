using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Dtos;

namespace WEMBLEY.App.Core.Application.Store
{
    public class HomeDataStore : BaseViewModel
    {
        public string HomeRefName { get; private set; } = "";
        public int HomeRefId { get; private set; } = 0;

        public void SetHomeRef(IEnumerable<LotDeviceReferenceDto> dtos)
        {
            HomeRefName = dtos.Last().RefName;
        }

    }
}
