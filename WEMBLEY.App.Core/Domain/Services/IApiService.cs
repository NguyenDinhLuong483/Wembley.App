using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Domain.Dtos;

namespace WEMBLEY.App.Core.Domain.Services
{
    public interface IApiService
    {
        Task<IEnumerable<DeviceDto>> GetAllDeviceTypeAsync();
        Task<IEnumerable<ProductDto>> GetProductByDeviceTypeAsync(string deviceType);
        Task<IEnumerable<ReferenceDto>> GetAllReferenceTypeAsync();
        Task<IEnumerable<ReferenceDto>> GetReferenceByProductTypeAsync(string deviceType);
        Task<IEnumerable<DeviceReferenceDto>> GetDeviceReferenceMFCAsync(int refId, string deviceId);

        Task<IEnumerable<LotDeviceReferenceDto>> GetAllLotDeviceReferenceAsync();
        Task<IEnumerable<LotDeviceReferenceDto>> GetLotDeviceReferenceByDeviceTypeAsync(string deviceType);
        Task<LotDeviceReferenceDto> GetLotDeviceReferenceAsync(int refId);

        Task<IEnumerable<ErrorStatusDto>> GetErrorStatusAsync(string deviceId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<MachineStatusDto>> GetMachineStatusHistoryAsync(string deviceId, DateTime startDate, DateTime endDate);

        Task<IEnumerable<ShiftReportDto>> GetShiftReportHistoryAsync(string deviceId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<ShiftReportWithShotDto>> GetShiftReportWithShotByShiftAsync(int shiftReportId);
        Task<IEnumerable<ShiftReportWithShotDto>> GetShiftReportWithShotByDateAsync(DateTime dateTime, int shiftNumber);

        Task FixMFCAsync(int refId, string deviceId, IEnumerable<MFCDto> fixDto);
        Task CreateLot(string refName, CreateLotDto createDto);
        Task<byte[]> DownloadShiftReportFileAsync(string deviceId, DateTime startDate, DateTime endDate);
    }
}
