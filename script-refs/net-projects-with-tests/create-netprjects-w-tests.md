# Create project dir
mkdir {root_project_name}

# Create VS project
dotnet new sln

# Create Main project: example Classlib
dotnet new classlib -o .\PrimeService
## Implement Main classes

# Add Main project to sln
dotnet sln add PrimeService/PrimeService.csproj

# Add Test project depending on test lib
## mstest
dotnet new mstest -o .\PrimeService.Tests
## xunit
dotnet new xunit -o .\PrimeService.Tests
## nunit
dotnet new nunit -o .\PrimeService.Tests

# Add reference Main project in Test project
- cd PrimeService.Tests
- dotnet add reference ../PrimeService/PrimeService.csproj
## Implement tests clases that test Main classes

# Add test project to sln
dotnet sln add .\PrimeService.Tests\PrimeService.Tests.csproj

# Launch test and build
- dotnet test
- dotnet build

