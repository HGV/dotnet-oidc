# Secure an ASP.NET application using OIDC

This repo demonstrates how you can use OIDC with ASP.NET apps. This app is not for production use and serves as an example of integration.

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
