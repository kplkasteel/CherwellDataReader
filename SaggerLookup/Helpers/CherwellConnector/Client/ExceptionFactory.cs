using System;
using RestSharp;

namespace SwaggerLookup.Helpers.CherwellConnector.Client;

public delegate Exception ExceptionFactory(string methodName, RestResponse response);