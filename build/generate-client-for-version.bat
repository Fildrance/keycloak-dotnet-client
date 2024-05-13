%echo off
set inputArg=%1
if NOT [%1]==[] goto usage

set /p "%inputArg%=Enter keycloak version for which you need client: "
:usage

:: disable getting fresh codegen jar until release with new csharp codegen is released (https://github.com/Fildrance/swagger-codegen/tree/feature/issue-%2312366)
:: curl https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.55/swagger-codegen-cli-3.0.55.jar -o swagger-codegen-cli.jar
curl https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/%inputArg%.json -o contracts.json

java -jar swagger-codegen-cli.jar generate -i contracts.json -l csharp-dotnet-core -o .\..\src\Keycloak.Client\ --template-engine mustache --additional-properties packageName=PetShop clientPackage=PetShop

xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Api .\..\src\Keycloak.Client\Api
xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Client .\..\src\Keycloak.Client\Client
xcopy /s /y .\..\src\Keycloak.Client\src\main\CsharpDotNet2\IO\Swagger\Model .\..\src\Keycloak.Client\Model

rd  /q /s .\..\src\Keycloak.Client\src