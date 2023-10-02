using System;
using SwaggerLookup.Helpers.CherwellConnector.Client;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public abstract class BaseApi
{
    protected readonly string[] LocalVarHttpContentTypes =
    {
        "application/json",
        "text/json",
        "application/xml",
        "text/xml",
        "application/x-www-form-urlencoded"
    };

    protected readonly string[] LocalVarHttpHeaderAccepts =
    {
        "application/json",
        "text/json",
        "application/xml",
        "text/xml"
    };

    private ExceptionFactory _exceptionFactory = (_, _) => null;

    public Configuration Configuration { get; set; }

    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                throw new InvalidOperationException("Multi-cast delegate for ExceptionFactory is unsupported.");
            return _exceptionFactory;
        }
        set => _exceptionFactory = value;
    }
}