FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./Teryt.WebApi/Teryt.WebApi.csproj", "."]
RUN dotnet restore "./Teryt.WebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Teryt.WebApi/Teryt.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Teryt.WebApi/Teryt.WebApi.csproj" -c Release -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Teryt.WebApi.dll"]
