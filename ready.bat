dotnet restore DWARF.WebAPI
dotnet build DWARF.WebAPI
dotnet ef database update -p DWARF.Repository/DWARF.Repository.csproj -s DWARF.Repository/DWARF.Repository.csproj
