# Install sonarscanner global
dotnet tool install --global dotnet-sonarscanner

# Scan project
dotnet sonarscanner begin /k:"<key>" /d:sonar.login="<token>"
dotnet build unit-testing-using-dotnet-test.sln
dotnet sonarscanner end /d:sonar.login="<token>"
## To generate In Sonarqube new token: user icon -> my account -> security

#Test Covarage in .net projects
## Add Libraries in Test project
dotnet add package coverlet.msbuild --version 2.0.1
dotnet add package FluentAssertions --version 5.0.0

# Scan with test coverage
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet build-server shutdown
dotnet sonarscanner begin /k:"<key>" /d:sonar.login="<token>" /d:sonar.cs.opencover.reportsPaths="<path_to_test_project>\coverage.opencover.xml" /d:sonar.coverage.exclusions="**Tests*.cs"
dotnet build
dotnet sonarscanner end /d:sonar.login="<token>"