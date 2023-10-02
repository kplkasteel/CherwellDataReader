using System.Collections.Generic;

namespace SwaggerLookup.Helpers.CherwellConnector.Client;

public class ApiResponse<T>
{
    public ApiResponse(int statusCode, IDictionary<string, string> headers, T data)
    {
        StatusCode = statusCode;
        Headers = headers;
        Data = data;
    }

    private int StatusCode { get; }

    private IDictionary<string, string> Headers { get; }

    public T Data { get; }
}