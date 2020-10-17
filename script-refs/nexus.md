# Install nexus 
- https://help.sonatype.com/repomanager3/download
- Unzip

# Run
- cd bin directory
- nexus /run
- access port 8081
- Login: admin/(password in <path-to>\sonatype-work\nexus3\admin.password)

# Config
- Add new user: developer/password
- Add new repository: type nuget hosted

# Add using proxy
- Analyse nuget.org-proxy
- dotnet add .\PrimeService\PrimeService.csproj package log4net --source http://localhost:8081/repository/nuget.org-proxy/
