# Secure an ASP.NET Core application using OIDC

This repo demonstrates how you can use OIDC with ASP.NET Core apps. This app is not for production use and serves as an example of integration.

## Develop

### Prerequisites

1. Create an OAuth2 client

1. Set the ID and secret of the created client in `appsettings.json`:
    ```json
    {
        "OpenIdConnect": {
            "ClientId": "",
            "ClientSecret": ""
        }
    }
    ```


## Sources
* https://www.linkedin.com/pulse/using-oauth2-authenticate-aspnet-mvc-core-22-web-app-canvas-smithers/
* https://nahidfa.com/posts/identityserver4-and-asp-.net-mvc/
* https://docs.openathens.net/providers/net-framework-4-5-mvc-openid-connect-example
* https://github.com/azure-ad-b2c/apps/tree/master/apps/web-dotnet-fw-owin-auth-code
* https://github.com/azure-ad-b2c/apps/tree/master/apps/web-dotnet-fw-owin-oidc
* https://github.com/Azure-Samples/active-directory-b2c-dotnet-webapp-and-webapi/blob/main/TaskWebApp/App_Start/Startup.Auth.cs