using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Domain.Dtos;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.Core.Application.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        private const string serverUrl = "https://wembleyscadaapi.azurewebsites.net/";
        public ApiService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<IEnumerable<DeviceDto>> GetAllDeviceTypeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/Devices");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<DeviceDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<LotDeviceReferenceDto>> GetAllLotDeviceReferenceAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/References/Parameters");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<LotDeviceReferenceDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<ReferenceDto>> GetAllReferenceTypeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/References");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ReferenceDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<DeviceReferenceDto>> GetDeviceReferenceMFCAsync(int refId, string deviceId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/DeviceReferences?ReferenceId={refId}&DeviceId={deviceId}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<DeviceReferenceDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<ErrorStatusDto>> GetErrorStatusAsync(string deviceId, DateTime startDate, DateTime endDate)
        {
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/ErrorInformations?DeviceId={deviceId}&StartTime={startDateString}&EndTime={endDateString}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ErrorStatusDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<LotDeviceReferenceDto> GetLotDeviceReferenceAsync(int refId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/References/Parameters?ReferenceId={refId}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<LotDeviceReferenceDto>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<LotDeviceReferenceDto>> GetLotDeviceReferenceByDeviceTypeAsync(string deviceType)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/References/Parameters?DeviceType={deviceType}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<LotDeviceReferenceDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<MachineStatusDto>> GetMachineStatusHistoryAsync(string deviceId, DateTime startDate, DateTime endDate)
        {
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/MachineStatus?DeviceId={deviceId}&StartTime={startDateString}&EndTime={endDateString}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<MachineStatusDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<IEnumerable<ProductDto>> GetProductByDeviceTypeAsync(string deviceType)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/Products?DeviceType={deviceType}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<ReferenceDto>> GetReferenceByProductTypeAsync(string productType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShiftReportDto>> GetShiftReportHistoryAsync(string deviceId, DateTime startDate, DateTime endDate)
        {
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/ShiftReports?DeviceId={deviceId}&StartTime={startDateString}&EndTime={endDateString}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ShiftReportDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<IEnumerable<ShiftReportWithShotDto>> GetShiftReportWithShotByDateAsync(DateTime dateTime, int shiftNumber)
        {
            string date = dateTime.ToString("yyyy-MM-dd");
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/ShiftReports/Details?Date={date}&ShiftNumber={shiftNumber}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ShiftReportWithShotDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<IEnumerable<ShiftReportWithShotDto>> GetShiftReportWithShotByShiftAsync(int shiftReportId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/ShiftReports/Details?ShiftReportId={shiftReportId}");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ShiftReportWithShotDto>>(responseBody);

            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task CreateLot(string refName, CreateLotDto createDto)
        {
            var json = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync($"{serverUrl}/api/References/{refName}", content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var error = JsonConvert.DeserializeObject<ServerSideError>(responseBody);
                    if (error is not null)
                    {
                        throw ex;
                    }
                    else
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw ex;
                }
            }
        }
        public async Task<byte[]> DownloadShiftReportFileAsync(string deviceId, DateTime startDate, DateTime endDate)
        {
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            HttpResponseMessage response = await _httpClient.GetAsync($"{serverUrl}/api/ShiftReports/downloadReport?DeviceId={deviceId}&StartTime={startDateString}&EndTime={endDateString}");

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsByteArrayAsync();
            return responseBody;
        }

        public async Task FixMFCAsync(int refId, string deviceId, IEnumerable<MFCDto> fixDto)
        {
            var json = JsonConvert.SerializeObject(fixDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync($"{serverUrl}/api/DeviceReferences/{deviceId}/{refId}", content);
            response.EnsureSuccessStatusCode();

        }

    }
}
