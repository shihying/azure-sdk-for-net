// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configuration settings for the Azure App Service Authentication /
    /// Authorization feature.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SiteAuthSettings : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        public SiteAuthSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="enabled">&lt;code&gt;true&lt;/code&gt; if the
        /// Authentication / Authorization feature is enabled for the current
        /// app; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="runtimeVersion">The RuntimeVersion of the
        /// Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain
        /// features in the Authentication / Authorization module.</param>
        /// <param name="unauthenticatedClientAction">The action to take when
        /// an unauthenticated client attempts to access the app. Possible
        /// values include: 'RedirectToLoginPage', 'AllowAnonymous'</param>
        /// <param name="tokenStoreEnabled">&lt;code&gt;true&lt;/code&gt; to
        /// durably store platform-specific security tokens that are obtained
        /// during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// The default is &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="allowedExternalRedirectUrls">External URLs that can be
        /// redirected to as part of logging in or logging out of the app. Note
        /// that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store
        /// application backends.
        /// Note that URLs within the current domain are always implicitly
        /// allowed.</param>
        /// <param name="defaultProvider">The default authentication provider
        /// to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured
        /// and the unauthenticated client
        /// action is set to "RedirectToLoginPage". Possible values include:
        /// 'AzureActiveDirectory', 'Facebook', 'Google', 'MicrosoftAccount',
        /// 'Twitter'</param>
        /// <param name="tokenRefreshExtensionHours">The number of hours after
        /// session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.</param>
        /// <param name="clientId">The Client ID of this relying party
        /// application, known as the client_id.
        /// This setting is required for enabling OpenID Connection
        /// authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html</param>
        /// <param name="clientSecret">The Client Secret of this relying party
        /// application (in Azure Active Directory, this is also referred to as
        /// the Key).
        /// This setting is optional. If no client secret is configured, the
        /// OpenID Connect implicit auth flow is used to authenticate end
        /// users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to
        /// authenticate end users.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html</param>
        /// <param name="issuer">The OpenID Connect Issuer URI that represents
        /// the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the
        /// directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery:
        /// http://openid.net/specs/openid-connect-discovery-1_0.html</param>
        /// <param name="allowedAudiences">Allowed audience values to consider
        /// when validating JWTs issued by
        /// Azure Active Directory. Note that the
        /// &lt;code&gt;ClientID&lt;/code&gt; value is always considered an
        /// allowed audience, regardless of this setting.</param>
        /// <param name="additionalLoginParams">Login parameters to send to the
        /// OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form
        /// "key=value".</param>
        /// <param name="googleClientId">The OpenID Connect Client ID for the
        /// Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/</param>
        /// <param name="googleClientSecret">The client secret associated with
        /// the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/</param>
        /// <param name="googleOAuthScopes">The OAuth 2.0 scopes that will be
        /// requested as part of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile",
        /// and "email" are used as default scopes.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/</param>
        /// <param name="facebookAppId">The App ID of the Facebook app used for
        /// login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login</param>
        /// <param name="facebookAppSecret">The App Secret of the Facebook app
        /// used for Facebook Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login</param>
        /// <param name="facebookOAuthScopes">The OAuth 2.0 scopes that will be
        /// requested as part of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login</param>
        /// <param name="twitterConsumerKey">The OAuth 1.0a consumer key of the
        /// Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation:
        /// https://dev.twitter.com/web/sign-in</param>
        /// <param name="twitterConsumerSecret">The OAuth 1.0a consumer secret
        /// of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation:
        /// https://dev.twitter.com/web/sign-in</param>
        /// <param name="microsoftAccountClientId">The OAuth 2.0 client ID that
        /// was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account
        /// authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm</param>
        /// <param name="microsoftAccountClientSecret">The OAuth 2.0 client
        /// secret that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account
        /// authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm</param>
        /// <param name="microsoftAccountOAuthScopes">The OAuth 2.0 scopes that
        /// will be requested as part of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as
        /// the default scope.
        /// Microsoft Account Scopes and permissions documentation:
        /// https://msdn.microsoft.com/en-us/library/dn631845.aspx</param>
        public SiteAuthSettings(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? enabled = default(bool?), string runtimeVersion = default(string), UnauthenticatedClientAction? unauthenticatedClientAction = default(UnauthenticatedClientAction?), bool? tokenStoreEnabled = default(bool?), IList<string> allowedExternalRedirectUrls = default(IList<string>), BuiltInAuthenticationProvider? defaultProvider = default(BuiltInAuthenticationProvider?), double? tokenRefreshExtensionHours = default(double?), string clientId = default(string), string clientSecret = default(string), string issuer = default(string), IList<string> allowedAudiences = default(IList<string>), IList<string> additionalLoginParams = default(IList<string>), string googleClientId = default(string), string googleClientSecret = default(string), IList<string> googleOAuthScopes = default(IList<string>), string facebookAppId = default(string), string facebookAppSecret = default(string), IList<string> facebookOAuthScopes = default(IList<string>), string twitterConsumerKey = default(string), string twitterConsumerSecret = default(string), string microsoftAccountClientId = default(string), string microsoftAccountClientSecret = default(string), IList<string> microsoftAccountOAuthScopes = default(IList<string>))
            : base(id, name, kind, type)
        {
            Enabled = enabled;
            RuntimeVersion = runtimeVersion;
            UnauthenticatedClientAction = unauthenticatedClientAction;
            TokenStoreEnabled = tokenStoreEnabled;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            DefaultProvider = defaultProvider;
            TokenRefreshExtensionHours = tokenRefreshExtensionHours;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Issuer = issuer;
            AllowedAudiences = allowedAudiences;
            AdditionalLoginParams = additionalLoginParams;
            GoogleClientId = googleClientId;
            GoogleClientSecret = googleClientSecret;
            GoogleOAuthScopes = googleOAuthScopes;
            FacebookAppId = facebookAppId;
            FacebookAppSecret = facebookAppSecret;
            FacebookOAuthScopes = facebookOAuthScopes;
            TwitterConsumerKey = twitterConsumerKey;
            TwitterConsumerSecret = twitterConsumerSecret;
            MicrosoftAccountClientId = microsoftAccountClientId;
            MicrosoftAccountClientSecret = microsoftAccountClientSecret;
            MicrosoftAccountOAuthScopes = microsoftAccountOAuthScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the
        /// Authentication / Authorization feature is enabled for the current
        /// app; otherwise, &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the RuntimeVersion of the Authentication /
        /// Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain
        /// features in the Authentication / Authorization module.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets the action to take when an unauthenticated client
        /// attempts to access the app. Possible values include:
        /// 'RedirectToLoginPage', 'AllowAnonymous'
        /// </summary>
        [JsonProperty(PropertyName = "properties.unauthenticatedClientAction")]
        public UnauthenticatedClientAction? UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// durably store platform-specific security tokens that are obtained
        /// during login flows; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// The default is &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenStoreEnabled")]
        public bool? TokenStoreEnabled { get; set; }

        /// <summary>
        /// Gets or sets external URLs that can be redirected to as part of
        /// logging in or logging out of the app. Note that the query string
        /// part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store
        /// application backends.
        /// Note that URLs within the current domain are always implicitly
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedExternalRedirectUrls")]
        public IList<string> AllowedExternalRedirectUrls { get; set; }

        /// <summary>
        /// Gets or sets the default authentication provider to use when
        /// multiple providers are configured.
        /// This setting is only needed if multiple providers are configured
        /// and the unauthenticated client
        /// action is set to "RedirectToLoginPage". Possible values include:
        /// 'AzureActiveDirectory', 'Facebook', 'Google', 'MicrosoftAccount',
        /// 'Twitter'
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultProvider")]
        public BuiltInAuthenticationProvider? DefaultProvider { get; set; }

        /// <summary>
        /// Gets or sets the number of hours after session token expiration
        /// that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenRefreshExtensionHours")]
        public double? TokenRefreshExtensionHours { get; set; }

        /// <summary>
        /// Gets or sets the Client ID of this relying party application, known
        /// as the client_id.
        /// This setting is required for enabling OpenID Connection
        /// authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Client Secret of this relying party application
        /// (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is configured, the
        /// OpenID Connect implicit auth flow is used to authenticate end
        /// users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to
        /// authenticate end users.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OpenID Connect Issuer URI that represents the
        /// entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the
        /// directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery:
        /// http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets allowed audience values to consider when validating
        /// JWTs issued by
        /// Azure Active Directory. Note that the
        /// &amp;lt;code&amp;gt;ClientID&amp;lt;/code&amp;gt; value is always
        /// considered an
        /// allowed audience, regardless of this setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// Gets or sets login parameters to send to the OpenID Connect
        /// authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalLoginParams")]
        public IList<string> AdditionalLoginParams { get; set; }

        /// <summary>
        /// Gets or sets the OpenID Connect Client ID for the Google web
        /// application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "properties.googleClientId")]
        public string GoogleClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret associated with the Google web
        /// application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "properties.googleClientSecret")]
        public string GoogleClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part of
        /// Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile",
        /// and "email" are used as default scopes.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "properties.googleOAuthScopes")]
        public IList<string> GoogleOAuthScopes { get; set; }

        /// <summary>
        /// Gets or sets the App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "properties.facebookAppId")]
        public string FacebookAppId { get; set; }

        /// <summary>
        /// Gets or sets the App Secret of the Facebook app used for Facebook
        /// Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "properties.facebookAppSecret")]
        public string FacebookAppSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part of
        /// Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "properties.facebookOAuthScopes")]
        public IList<string> FacebookOAuthScopes { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 1.0a consumer key of the Twitter application
        /// used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [JsonProperty(PropertyName = "properties.twitterConsumerKey")]
        public string TwitterConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [JsonProperty(PropertyName = "properties.twitterConsumerSecret")]
        public string TwitterConsumerSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 client ID that was created for the app
        /// used for authentication.
        /// This setting is required for enabling Microsoft Account
        /// authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [JsonProperty(PropertyName = "properties.microsoftAccountClientId")]
        public string MicrosoftAccountClientId { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 client secret that was created for the
        /// app used for authentication.
        /// This setting is required for enabling Microsoft Account
        /// authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [JsonProperty(PropertyName = "properties.microsoftAccountClientSecret")]
        public string MicrosoftAccountClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part of
        /// Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as
        /// the default scope.
        /// Microsoft Account Scopes and permissions documentation:
        /// https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </summary>
        [JsonProperty(PropertyName = "properties.microsoftAccountOAuthScopes")]
        public IList<string> MicrosoftAccountOAuthScopes { get; set; }

    }
}
