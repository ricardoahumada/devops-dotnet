# Download nuget
- https://www.nuget.org/downloads
- Add to path

# Pack project
## Using nuget example
nuget pack PrimeService\PrimeService.csproj -Build -Properties Configuration=Release -Version 1.0.0 -OutputDirectory package
## Using dotnet example
dotnet pack PrimeService\PrimeService.csproj -p:Build=true -p:PackageVersion=1.0.0 -p:NoDefaultExcludes=true -p:Configuration=Release -o package


# Publish package to Nexus
## Using dotnet
dotnet nuget push {nupkg-name} -k {nexus-api-key} -s {repository-source-uri}
## Using nuget
nuget push -Source {NuGet package source URL} -ApiKey key {your_package}.nupkg
## locate api-key in nexus: user icon -> menu -> Nuget API Key
### Example
dotnet nuget push --api-key 1dc2630e-3648-3be0-8130-9b000a56eed3 --source http://localhost:8081/repository/nuget-hosted/ {package_dir}\PrimeService.1.0.0.nupkg

# Add repo source to nuget w/credentials
## Without storing credentials
nuget sources add -name NuGetNexusHosted -source http://localhost:8081/repository/nuget-hosted/ -username {user_name} -password {password} 
## Storing credentials: must create nuget.config first
nuget sources add -name NuGetNexusHosted -source http://localhost:8081/repository/nuget-hosted/ -username {user_name} -password {password}  -StorePasswordInClearText -configfile ./nuget.config

# List pakckages in repo
nuget list -s NuGetNexusHosted -AllVersions

# User package to add to project example
dotnet add .\src\HelloWorld.Mvc\HelloWorld.Mvc.csproj package PrimeService -v 1.0.0

# Packaging DLL/LIB/.. projects
## Create nuspec
nuget spec {csproj-file}

## add in .nuspec the files (dll, lib, ) to add to package
```xml
&lt;package>
....
&lt;files>
&lt;file src="build\lib\main\release\*.*" target="lib\" />
&lt;/files>
&lt;/package> 
```
## Pack dll for previously compiled project using nspec
dotnet pack {csproj-file} -p:NoBuild=true -p:PackageVersion=1.0.0 -p:NoDefaultExcludes=true -o publish
