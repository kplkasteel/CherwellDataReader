using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Interface;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IServiceApi : IApiAccessor
{
    /// <summary>
    ///     get information about the REST Api and CSM
    /// </summary>
    /// <remarks>
    ///     Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM
    ///     version, and CSM system date and time.
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="lang">
    ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
    ///     locale\&quot; can be used to specify the culture. (optional)
    /// </param>
    /// <param name="locale">
    ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
    ///     locale\&quot; can be used to specify the culture. (optional)
    /// </param>
    /// <returns>ServiceInfoResponse</returns>
    ServiceInfoResponse ServiceGetServiceInfoV1(string lang = null, string locale = null);

    /// <summary>
    ///     Log out user by token
    /// </summary>
    /// <remarks>
    ///     Operation that logs out the user referenced in the authentication token.
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="lang">
    ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
    ///     locale\&quot; can be used to specify the culture. (optional)
    /// </param>
    /// <param name="locale">
    ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
    ///     locale\&quot; can be used to specify the culture. (optional)
    /// </param>
    /// <returns></returns>
    object ServiceLogoutUserV1(string lang = null, string locale = null);

    /// <summary>
    ///     get an access token
    /// </summary>
    /// <remarks>
    ///     Operation to request an access token for one of the following authentication modes. Or, you can request an access
    ///     token using a refresh token. An API client key is required in both cases, and the authentication mode you use must
    ///     be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other
    ///     mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to
    ///     find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings
    ///     configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use
    ///     domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials
    ///     and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
    /// <param name="clientId">The API client key for the client making the token request.</param>
    /// <param name="clientSecret">
    ///     The API client secret for the native client making the token request.  This is only required
    ///     for native clients. (optional)
    /// </param>
    /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
    /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
    /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
    /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
    /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
    /// <returns>TokenResponse</returns>
    TokenResponse ServiceToken(string grantType, string clientId, string clientSecret = null,
        string username = null, string password = null, string refreshToken = null, string authMode = null,
        string siteName = null);
}