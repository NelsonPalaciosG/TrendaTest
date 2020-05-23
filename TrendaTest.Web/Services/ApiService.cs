namespace TrendaTest.Web.Services
{
    public class ApiService : IApiService
    {
        //public async Task<Response> GetProductoByTiendaAsync(
        //    string urlBase,
        //    string servicePrefix,
        //    string controller,
        //    string IdTienda)
        //{
        //    try
        //    {
        //        TiendaRequestDto request = new TiendaRequestDto { Id = IdTienda };
        //        string requestString = JsonConvert.SerializeObject(request);
        //        StringContent content = new StringContent(requestString, Encoding.UTF8, "application/json");
        //        HttpClient client = new HttpClient
        //        {
        //            BaseAddress = new Uri(urlBase)
        //        };


        //        string url = $"{urlBase}{servicePrefix}{controller}";
        //        HttpResponseMessage response = await client.PostAsync(url, content);
        //        string result = await response.Content.ReadAsStringAsync();

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Response
        //            {
        //                IsSuccess = false,
        //                Message = result,
        //            };
        //        }

        //        ProductoResponseDto trip = JsonConvert.DeserializeObject<EmployeeResponse>(result);
        //        return new Response
        //        {
        //            IsSuccess = true,
        //            Result = trip
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Response
        //        {
        //            IsSuccess = false,
        //            Message = ex.Message
        //        };
        //    }
        //}

    }
}
