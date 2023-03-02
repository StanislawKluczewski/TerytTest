FROM  mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /app

EXPOSE 80
EXPOSE 443

# Copy csproj and restore as distinct layers
COPY Teryt.WebApi/Teryt.WebApi.csproj ./Teryt.WebApi/


RUN dotnet restore ./Teryt.WebApi/Teryt.WebApi.csproj -s https://api.nuget.org/v3/index.json 

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM  mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app
COPY --from=build-env /app/out .


ENTRYPOINT ["dotnet", "Teryt.WebApi.dll", "--urls", "http://0.0.0.0:80", "https://0.0.0.443"]

ENV ASPNETCORE_ENVIRONMENT="Development"