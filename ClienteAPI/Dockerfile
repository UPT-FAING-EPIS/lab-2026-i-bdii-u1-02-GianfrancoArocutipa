FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copiar solo el csproj primero para cachear la restauración
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto y publicar
COPY . ./
RUN dotnet publish -c Release -o out

# Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out .

# Obligatorio: El nombre del DLL debe coincidir con tu proyecto
ENTRYPOINT ["dotnet", "ClienteAPI.dll"]