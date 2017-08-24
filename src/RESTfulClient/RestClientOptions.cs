﻿using RESTfulClient.Converters;

namespace RESTfulClient
{
    public class RestClientOptions
    {
        public RestClientOptions()
        {
            JsonConverter = new RestJsonConverter();
            QueryConverter = new RestQueryConverter();
        }

        public IJsonConverter JsonConverter { get; set; }

        public IQueryConverter QueryConverter { get; set; }
    }
}