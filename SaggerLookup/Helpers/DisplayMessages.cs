using System.Windows.Forms;
using Newtonsoft.Json;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Models;

namespace SwaggerLookup.Helpers
{
    public static class Display    
    {
        public static void ErrorMessage(ApiException apiException)
        {
            
             MessageBox.Show(apiException.Message, "Cherwell Error", MessageBoxButtons.OK);
        }

        public static void NewUSerSetupMessage(ApiException apiException)
        {
            MessageBox.Show(apiException.Message, "New User Error", MessageBoxButtons.OK);
        }

       

      

        public static void DisplayMessage(ApiException apiException)
        {
            try
            {
                if (apiException != null)
                {
                    var message = JsonConvert.DeserializeObject<LoginErrors>(apiException.ErrorContent) as LoginErrors;

                    if (!string.IsNullOrEmpty(message?.Error))
                    {
                        MessageBox.Show(message?.Description, message?.Error, MessageBoxButtons.OK);
                        return;
                    }
                }

                if (apiException != null)
                {
                    var general = JsonConvert.DeserializeObject<GeneralError>(apiException.ErrorContent) as GeneralError;
                    if (general?.HasError != null && general.HasError)
                    {
                        MessageBox.Show(general?.ErrorMessage, general?.ErrorCode, MessageBoxButtons.OK);
                        return;
                    }
                }

                if (apiException == null) return;
                var singleMessage = JsonConvert.DeserializeObject<SingleMessage>(apiException.ErrorContent) as SingleMessage;
                if (!string.IsNullOrEmpty(singleMessage?.Message))
                {
                    MessageBox.Show(singleMessage?.Message, "Unknown error..", MessageBoxButtons.OK);
                    return;
                }
               
            }
            catch (JsonException)
            {
                if (apiException != null)
                    DisplayMessage("HTTP Error", apiException.ErrorContent);
            }



        }

        public static void DisplayMessage(string header, string body)
        {
            MessageBox.Show(body, header, MessageBoxButtons.OK);
           
        }
        

        public static void LoginErrorMessage(ApiException apiException)
        {
   
            try
            {
                var message = JsonConvert.DeserializeObject<LoginErrors>(apiException?.ErrorContent) as LoginErrors;
                switch (message?.Error)
                {
                    case "invalid_grant":
                        DisplayMessage("Login Error", "Username and/or password is incorrect.");
                        break;
                        
                    case "invalid_client_id":
                        DisplayMessage("Client ID error", message.Description);
                        break;
                    default:
                        DisplayMessage("Unknown Login Error", message?.Description);
                        break;
                }
            }
            catch (JsonException)
            {
                if (apiException != null)
                    DisplayMessage("HTTP Error", apiException.ErrorContent);
            }

        }




    }

    public static class HttpErrors
    {
        public static string GetErrorCode(int errorCode)
        {
            switch (errorCode)
            {
                case 400:
                    return "Bad Request\n\nThe request could not be understood by the server due to malformed syntax.";
                case 401:
                    return "Unauthorized\n\nThe request requires user authentication.";
                case 403:
                    return "Forbidden\n\nThe server understood the request, but is refusing to fulfill it.";
                case 404:
                    return "Not Found\n\nThe server has not found anything matching the Request-URI.";
                case 405:
                    return "Method Not Allowed\n\nThe method specified in the Request-Line is not allowed for the resource identified by the Request-URI.";
                case 406:
                    return "Not Acceptable\n\nThe resource identified by the request is only capable of generating response entities which have content characteristics not acceptable according to the accept headers sent in the request.";
                case 407:
                    return "Proxy Authentication Required\n\nThis code is similar to 401 (Unauthorized), but indicates that the client must first authenticate itself with the proxy.";
                case 408:
                    return "Request Timeout\n\nThe client did not produce a request within the time that the server was prepared to wait. ";
                case 409:
                    return "Conflict\n\nhe request could not be completed due to a conflict with the current state of the resource.";
                case 410:
                    return "Proxy Authentication Required\n\nThe requested resource is no longer available at the server and no forwarding address is known.";
                case 411:
                    return "Length Required\n\nThe server refuses to accept the request without a defined Content- Length.";
                case 412:
                    return "Precondition Failed\n\nThe precondition given in one or more of the request-header fields evaluated to false when it was tested on the server. ";
                case 413:
                    return "Request Entity Too Large\n\nThe server is refusing to process a request because the request entity is larger than the server is willing or able to process. ";
                case 414:
                    return "Request-URI Too Long\n\nThe server is refusing to service the request because the Request-URI is longer than the server is willing to interpret.";
                case 415:
                    return "Unsupported Media Type\n\nhe server is refusing to service the request because the entity of the request is in a format not supported by the requested resource for the requested method.";
                case 416:
                    return "Requested Range Not Satisfiable\n\nA server SHOULD return a response with this status code if a request included a Range request-header field.";
                case 417:
                    return "Expectation Failed\n\nThe expectation given in an Expect request-header field could not be met by this server.";
                case 500:
                    return "Internal Server Error\n\nhe server encountered an unexpected condition which prevented it from fulfilling the request.";
                case 501:
                    return "Not Implemented\n\nThe server does not support the functionality required to fulfill the request.";
                case 502:
                    return "Bad Gateway\n\nThe server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request.";
                case 503:
                    return "Service Unavailable\n\nThe server is currently unable to handle the request due to a temporary overloading or maintenance of the server.";
                case 504:
                    return "Gateway Timeout\n\nThe server, while acting as a gateway or proxy, did not receive a timely response from the upstream server specified by the URI (e.g. HTTP, FTP, LDAP) or some other auxiliary server (e.g. DNS) it needed to access in attempting to complete the request.";
                case 505:
                    return "HTTP Version Not Supported\n\nThe server does not support, or refuses to support, the HTTP protocol version that was used in the request message.";
                default:
                    return "Unknown Error";
            }
        }
    }


   
}