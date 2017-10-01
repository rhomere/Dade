using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using System.Net;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Dade.Models;


namespace Dade
{
    public partial class GovController
    {
        public static MobileServiceClient client = new MobileServiceClient("http://localbackend.azurewebsites.net");

        //public IMobileServiceTable<TodoItem> todoTable = client.GetTable<TodoItem>();

        public IMobileServiceTable<Municipality> MuniTable = client.GetTable<Municipality>();

        public IMobileServiceTable<Official> OfficialTable = client.GetTable<Official>();

        public HttpClient _client = new HttpClient();

        public async Task<ObservableCollection<Municipality>> GetMunis()
        {
            var content = await _client.GetStringAsync(Constants.MuniUrl);

            return JsonConvert.DeserializeObject<ObservableCollection<Municipality>>(content);
        }

        public async Task<ObservableCollection<Official>> GetOfficials()
        {
            var content = await _client.GetStringAsync(Constants.OfficialUrl);

            return JsonConvert.DeserializeObject<ObservableCollection<Official>>(content);
        }
    }
}
