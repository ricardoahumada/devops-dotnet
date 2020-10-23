# Download nuget
- https://www.nuget.org/downloads
- Add to path


# Pack project
## Using nuget example
- nuget pack PrimeService\PrimeService.csproj -Build -Properties Configuration=Release -Version 1.0.0 -OutputDirectory package
- nuget spec <csproj_file> (to specify metadata)
## Using dotnet example
- dotnet pack PrimeService\PrimeService.csproj -p:Build=true -p:PackageVersion=1.0.0 -p:NoDefaultExcludes=true -p:Configuration=Release -o package


# Publish package to Nexus
## Using dotnet
- dotnet nuget push &lt;nupkg-name> -k &lt;nexus_api_key> -s &lt;repository_source_uri>
## Using nuget
- nuget push -Source &lt;NuGet_package_source_URL> -ApiKey key &lt;your_package>.nupkg
#### Locate api-key in nexus: 
- user icon -> menu -> Nuget API Key
- Ensure NuGet API-Key Realm is added to the user/role
#### Example
- dotnet nuget push --api-key &lt;API-key> --source http://localhost:8081/repository/nuget-hosted/ &lt;package_dir>\PrimeService.1.0.0.nupkg
#### Register Api key for a given repository with the following command:
- nuget setapikey &lt;API-key> -source http://localhost:8081/repository/{repository name}/
### To definie package specifications - metadata: .nuspec file
- nuget spec <csproj_file>


# Add repo source to nuget w/credentials
## Without storing credentials
- nuget sources add -name NuGetNexusHosted -source http://localhost:8081/repository/nuget-hosted/ -username &lt;user_name> -password &lt;password>
## Storing credentials: must create nuget.config first
- nuget sources add -name NuGetNexusHosted -source http://localhost:8081/repository/nuget-hosted/ -username &lt;user_name> -password &lt;password>  -StorePasswordInClearText -configfile ./nuget.config

# List pakckages in repo
- nuget list -s http://localhost:8081/repository/{repository name}/ -AllVersions
- nuget list -s &lt;repo_name> -AllVersions


# Adding dependencies to project
## Using nuget example
- nuget install log4net
- (don't alter csproj)
## Using dotnet example
- dotnet add &lt;.csproj_file> package &lt;package-name> -v &lt;version>

### Example
- dotnet add .\PrimeService\PrimeService.csproj package log4net
- dotnet add .\src\HelloWorld.Mvc\HelloWorld.Mvc.csproj package PrimeService -v 1.0.0

# Restoring dependencies to project
## Using nuget example
- nuget restore
## Using dotnet example
- dotnet restore


# Packaging DLL/LIB/.. projects
## Create lib project
- dotnet new classlib
## Create nuspec
- nuget spec &lt;csproj_file>

## add in .nuspec the files (dll, lib, ) to add to package
```xml
<package>
  ....
  <files>
    <file src="build\lib\main\release\*.*" target="lib\" />
  </files>
</package> 
```
## Pack dll for previously compiled project using nspec
- dotnet pack &lt;csproj_file> -p:NoBuild=true -p:PackageVersion=1.0.0 -p:NoDefaultExcludes=true -o publish
