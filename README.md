mkdir CursoNetCore
cd CursoNetCore
dotnet new webapi -o CursoNetCore -f netcoreapp3.1
cd ..
dotnet new sln
dotnet sln add .\CursoNetCore\CursoNetCore.csproj
dotnet new classlib -o Models -f netcoreapp3.1
cd Models
dotnet add package Microsoft.EntityFrameworkCore -v 3.1.7
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.7
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.7
cd ..
dotnet sln add .\Models\Models.csproj
dotnet add CursoNetCore/CursoNetCore.csproj reference Models/Models.csproj






