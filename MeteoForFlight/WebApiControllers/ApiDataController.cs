﻿using System.Web.Http;
using Common.Constants;

namespace MeteoForFlight.WebApiControllers
{
    public class ApiDataController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public string GetGoogleMapsUrl()
        {
            return ApiStrings.GoogleMapsApiUrl;
        }
    }
}