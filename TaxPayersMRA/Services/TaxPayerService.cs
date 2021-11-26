using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TaxPayersMRA.Requests;
using TaxPayersMRA.Responses;
using TaxPayersMRA.ViewModels;

namespace TaxPayersMRA.Services
{
    public class TaxPayerService
    {
        private readonly HttpClient _httpClient;
        private readonly Urls _urls;
        private readonly HttpContentCreator _contentCreator;
        
        public TaxPayerService(HttpClient httpClient, Urls urls, HttpContentCreator contentCreator)
        {
            _httpClient = httpClient;
            _urls = urls;
            _contentCreator = contentCreator;
        }

        public async Task<LoginResponse> AuthenticateUserAsync(LoginInfo loginInfo)
        {
            var url = _urls.LoginUrl();
            var content = _contentCreator.createStringContent<LoginInfo>(loginInfo);

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<LoginResponse>(json);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> LogOutUser(LogoutInfo logoutInfo)
        {
            var url = _urls.LogoutUrl();
            var content = _contentCreator.createStringContent<LogoutInfo>(logoutInfo);

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<TaxPayer>> GetTaxPayersAsync()
        {
            var url = _urls.GetAllTaxPayersUrl();

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<List<TaxPayer>>(json);
            }
            else
            {
                return new List<TaxPayer>();
            }
        }


        public async Task<bool> AddTaxPayerAsync(TaxPayer taxPayer)
        {
            var url = _urls.AddTaxPayerUrl();

            var content = _contentCreator.createStringContent<TaxPayer>(taxPayer);

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> EditTaxPayerAsync(TaxPayer taxPayer)
        {
            var url = _urls.EditTaxPayerUrl();

            var content = _contentCreator.createStringContent<TaxPayer>(taxPayer);

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteTaxPayerAsync(TaxPayer taxPayer)
        {
            var url = _urls.DeleteTaxPayerUrl();

            var content = _contentCreator.createStringContent<DeleteTaxPayerRequest>(
                    new DeleteTaxPayerRequest
                    {
                        TPIN = taxPayer.TPIN
                    }
                );

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
