FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ./Teryt.WebApi/Teryt.WebApi.csproj .
RUN dotnet restore "Teryt.WebApi.csproj"
COPY . .
RUN dotnet publish "./Teryt.WebApi/Teryt.WebApi.csproj" -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Teryt.WebApi.dll"]
 