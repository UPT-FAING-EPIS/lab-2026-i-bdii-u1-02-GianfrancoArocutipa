# Imagen base de .NET 10
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copiar archivos y restaurar
COPY *.csproj ./
RUN dotnet restore

# Copiar todo y publicar
COPY . ./
RUN dotnet publish -c Release -o out

# Imagen de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "ClienteAPI.dll"]