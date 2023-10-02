using SwaggerLookup.Helpers.CherwellConnector.Client;

namespace SwaggerLookup.Helpers.CherwellConnector.Interface;

public interface IApiAccessor
{
    Configuration Configuration { get; set; }

    ExceptionFactory ExceptionFactory { get; set; }
}