using System.Collections.Generic;
using System.IO;
using SwaggerLookup.Helpers.CherwellConnector.Api;

namespace SwaggerLookup.Helpers.CherwellConnector.Client;

public class Configuration
{
    #region Constants

    private const string Iso8601DatetimeFormat = "o";

    #endregion Constants

    #region Static Members

    private static readonly object GlobalConfigSync = new { };
    private static Configuration _globalConfiguration;

    public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
    {
        var status = (int)response.StatusCode;
        return status switch
        {
            >= 400 => new ApiException(status,
                $"Error calling {methodName}: {response.Content}", response.Content),
            0 => new ApiException(status,
                $"Error calling {methodName}: {response.ErrorMessage}", response.ErrorMessage),
            _ => null
        };
    };

    public static Configuration Default
    {
        get => _globalConfiguration;
        set
        {
            lock (GlobalConfigSync)
            {
                _globalConfiguration = value;
            }
        }
    }

    #endregion Static Members

    #region Private Members

    private string _dateTimeFormat = Iso8601DatetimeFormat;
    private string _tempFolderPath = Path.GetTempPath();

    #endregion Private Members


    #region Properties

    private ApiClient _apiClient;

    public ApiClient ApiClient => _apiClient ??= CreateApiClient();

    public string BasePath { get; set; }

    public static IDictionary<string, string> DefaultHeader => new Dictionary<string, string>();

    public static string AccessToken => ServiceApi.Instance.TokenResponse.AccessToken;

    public string TempFolderPath
    {
        get => _tempFolderPath;

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _tempFolderPath = Path.GetTempPath();
                return;
            }

            if (!Directory.Exists(value)) Directory.CreateDirectory(value);

            if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                _tempFolderPath = value;
            else
                _tempFolderPath = value + Path.DirectorySeparatorChar;
        }
    }

    public string DateTimeFormat
    {
        get => _dateTimeFormat;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _dateTimeFormat = Iso8601DatetimeFormat;
                return;
            }

            _dateTimeFormat = value;
        }
    }

    #endregion Properties

    #region Methods

    public static void AddDefaultHeader(string key, string value)
    {
        DefaultHeader[key] = value;
    }

    private ApiClient CreateApiClient()
    {
        return new ApiClient(BasePath) { Configuration = this };
    }

    #endregion Methods
}