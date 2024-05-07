#curl https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.55/swagger-codegen-cli-3.0.55.jar -o swagger-codegen-cli.jar
curl https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/23.0.7.json -o contracts.json

java -jar swagger-codegen-cli.jar generate -i contracts.json -l csharp-dotnet-core -o .\..\src\Keycloak.Client\ --template-engine mustache

xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Api .\..\src\Keycloak.Client\Api
xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Client .\..\src\Keycloak.Client\Client
xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Model .\..\src\Keycloak.Client\Model

rd  /q /s .\..\src\Keycloak.Client\src