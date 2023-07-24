using Azure;
using Azure.Core;
using Course.App.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using Course.App.DataModel.Dto;
using Castle.Core.Internal;
using System.Collections.Generic;
using Course.App.DataModel;

namespace Course.App.WebApi.Services
{
    public class UserService : IUserService
    {
        public Task<UsersDto> CreateUser(Training data)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsersDto>> GetAllUser()
        {
            var users = new List<UsersDto>();
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMinutes(180);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    using (var response = await client.GetAsync(@"https://gorest.co.in/public/v2/users"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();

                        if (apiResponse != null)
                        {
                            users = JsonConvert.DeserializeObject<List<UsersDto>>(apiResponse,
                                   new JsonSerializerSettings
                                   {
                                       NullValueHandling = NullValueHandling.Ignore
                                   });
                        }

                    }
                }
                catch(Exception ex)
                {

                }

            }


            return users;



        }

        public async Task<List<UsersDto>> GetUser(string userId)
        {
            var user = new List<UsersDto> ();

            using (var httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMinutes(180);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    using (var response = await httpClient.GetAsync(@"https://gorest.co.in/public/v2/users?id=" + userId))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();

                        if (apiResponse != null)
                        {
                            user = JsonConvert.DeserializeObject<List<UsersDto>>(apiResponse);
                        }

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return user;
        }


    }
}
