# keycloak-dotnet-client
OpenApi-generated dotnet client for keycloak. Regards for generator goes to https://github.com/swagger-api/swagger-codegen, OpenApi definitions from https://github.com/ccouzens/keycloak-openapi

# how to use
Package is not currently listed in nuget, as it needs further improvements to be used (auto-login of client on request etc).

To use it with last generated (23.0.7) keycloak api version you need to get special version of swagger-codegen-cli (supporting 3.0.0 and csharp-dotnet-core codegen) and then execute ```/build/generate-client.bat```. If other version of keycloak is required - call ```/build/generate-client.bat``` using version as argument, for example 
```
 /build/generate-client.bat 23.0.1
```