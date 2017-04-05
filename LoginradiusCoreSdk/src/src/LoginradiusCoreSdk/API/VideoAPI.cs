﻿using LoginradiusCoreSdk.Entity;
using LoginradiusCoreSdk.Utility.Http;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace LoginradiusCoreSdk.API
{
    public class VideoApi : ILoginRadiusApi
    {
        private string Nextcursor { get; set; }
        public VideoApi(string nextcursor)
        {
            Nextcursor = nextcursor;
        }

        public VideoApi()
        { }

        readonly HttpRequestClient _requestClient = new HttpRequestClient();
        const string Endpoint = "api/v2/video?access_token={0}";
        const string EndpointWithNextcursor = "api/v2/video?access_token={0}&nextcursor={1}";
        const string RawEndpoint = "api/v2/video/raw?access_token={0}";
        const string RawEndpointWithNextcursor = "api/v2/video/raw?access_token={0}&nextcursor={1}";
        /// <summary>
        /// The Video API is used to get video files data from the user’s social account. The data will be normalized into LoginRadius' standard data format.
        /// </summary>
        /// <param name="token">A valid session token,which is fetch from Access Token API.</param>
        /// <returns></returns>
        public string ExecuteApi(Guid token)
        {
            var url = string.IsNullOrEmpty(Nextcursor) ? string.Format(Constants.ApiRootDomain + Endpoint, token) : string.Format(Constants.ApiRootDomain + EndpointWithNextcursor, token, Nextcursor);
            return _requestClient.Request(url, null, HttpMethod.GET);
        }

        /// <summary>
        /// Get User Video files data as provided by the provider. The data will not be in a consistent response type and format across providers, so you will have to parse it yourself.
        /// </summary>
        /// <param name="token">A valid session token,which is fetch from Access Token API.</param>
        /// <returns></returns>
        public string ExecuteRawApi(Guid token)
        {
            var url = string.IsNullOrEmpty(Nextcursor) ? string.Format(Constants.ApiRootDomain + RawEndpoint, token) : string.Format(Constants.ApiRootDomain + RawEndpointWithNextcursor, token, Nextcursor);
            return _requestClient.Request(url, null, HttpMethod.GET);
        }
    }
}
