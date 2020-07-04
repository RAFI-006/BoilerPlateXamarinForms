using BoilerPlates.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlates.Global
{
   public class ApiService
    {

        public async static Task<T> GetRequest<T>(Uri uri)
        {


            var client = new HttpClient();
        
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await client.SendAsync(request).ConfigureAwait(false);

           

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);


                var baseissuerResponseModel = await Task.Run(() =>
                   JsonConvert.DeserializeObject<T>(json)
                ).ConfigureAwait(false);
                return baseissuerResponseModel;



            }
            else
            {
                return default(T);
            }



        }


        public async static Task<GenericResponse<TOut>> PostRequest<TOut, Tin>(Uri uri, Tin model)
        {

            var outResponse = new GenericResponse<TOut>();
            HttpResponseMessage response = null;

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            try
            {
                HttpClient httpClient = new HttpClient();
               
             
                response = await httpClient.PostAsync(uri, content).ConfigureAwait(false);



                if (response.IsSuccessStatusCode)
                {
                    var jsondata = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var responseModel = await Task.Run(() =>
                       JsonConvert.DeserializeObject<GenericResponse<TOut>>(jsondata)
                    ).ConfigureAwait(false);
                    outResponse = responseModel;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return outResponse;
        }



        public async static Task<GenericResponse<TOut>> PutRequest<TOut, Tin>(Uri uri, Tin model)
        {
            var outResponse = new GenericResponse<TOut>();
            HttpResponseMessage response = null;

            var json = JsonConvert.SerializeObject(model);

            try
            {
                HttpClient httpClient = new HttpClient();
               

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await httpClient.PutAsync(uri, content).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsondata = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var responseModel = await Task.Run(() =>
                       JsonConvert.DeserializeObject<GenericResponse<TOut>>(jsondata)
                    ).ConfigureAwait(false);
                    outResponse = responseModel;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return outResponse;
        }





    }
}
