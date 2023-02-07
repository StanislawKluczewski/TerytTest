FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY ./Teryt.WebApi/Teryt.WebApi.csproj .
RUN dotnet restore "Teryt.WebApi.csproj"
COPY . .
RUN dotnet publish "./Teryt.WebApi/Teryt.WebApi.csproj" -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 9292
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Teryt.WebApi.dll"]

docker run -p 9292:9292 -p 9293:9293 -e ASPNETCORE_HTTP_PORT=https://+:9293 -e ASPNETCORE_URLS=http://+:9292  teryt-webapi:1.0.0
docker build -t teryt-webapi:1.0.0 .
