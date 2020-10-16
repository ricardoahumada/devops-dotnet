# Create folder
- mkdir unit-testing-using-mstest-mvc
- cd unit-testing-using-mstest-mvc
- dotnet new sln

# Create Main and Test projects
- dotnet new mvc -o .\src\HelloWorld.Mvc
- dotnet new xunit -o .\tests\HelloWorld.FunctionalTests

# Add projects to solution
- dotnet sln add .\src\HelloWorld.Mvc\HelloWorld.Mvc.csproj
- dotnet sln add .\tests\HelloWorld.FunctionalTests\HelloWorld.FunctionalTests.csproj

# Reference the Main from Test
- dotnet add .\tests\HelloWorld.FunctionalTests\HelloWorld.FunctionalTests.csproj reference .\src\HelloWorld.Mvc\HelloWorld.Mvc.csproj

# Add test dependency in Test project
- dotnet add .\tests\HelloWorld.FunctionalTests\HelloWorld.FunctionalTests.csproj package Microsoft.AspNetCore.App -v 2.1.0

# Lauch Test
- dotnet test .\tests\HelloWorld.FunctionalTests\HelloWorld.FunctionalTests.csproj

# Run project
- cd .\src\HelloWorld.Mvc
- dotnet run 

# Publish
- dotnet publish -c Release -r win-x64 --output ./MyTargetFolder MySolution.sln
