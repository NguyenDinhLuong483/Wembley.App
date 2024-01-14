using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.Store;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.Services
{
    public class DatabaseSynchronizationService : IDatabaseSynchronizationService
    {
        private readonly IApiService _apiService;
        private readonly ReferenceStore _referenceStore;
        private readonly DeviceStore _deviceStore;
        private readonly HomeDataStore _homeDataStore;

        public DatabaseSynchronizationService(IApiService apiService, ReferenceStore referenceStore, DeviceStore deviceStore, HomeDataStore homeDataStore)
        {
            _apiService = apiService;
            _referenceStore = referenceStore;
            _deviceStore = deviceStore;
            _homeDataStore = homeDataStore;
        }

        public async Task SynchronizeDevicesData()
        {
            var referenceDto = await _apiService.GetAllReferenceTypeAsync();
            _referenceStore.SetReference(referenceDto);
        }

        public async Task SynchronizeHomeData()
        {
            var deviceDtos = await _apiService.GetAllDeviceTypeAsync();
            _deviceStore.SetDevice(deviceDtos);
        }

        public async Task SynchronizeReferencesData()
        {
            var homeRefDtos = await _apiService.GetAllLotDeviceReferenceAsync();
            _homeDataStore.SetHomeRef(homeRefDtos);
        }
    }
}
