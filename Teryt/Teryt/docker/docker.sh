# sql server container
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Studenci2022' -v sqlvolume:/var/opt/mssql -p 1433:1433 -d --name sqlserver --restart unless-stopped  mcr.microsoft.com/mssql/server:2022-latest

# -e przekazywanie argumentu
# ACCEPT_EULA=Y zgadzamy sie z umow� licencyjn�
# -d - odziedzielony(detached mode)
# --name sqlserverdocker 
# --restart unless-stopped
# -v sqlvolume:/var/opt/mssql

# web api container
 docker build -t teryt.webapi:1.0.0 . --network=host
 docker run -t -d -p 9296:80 -p 9297:443 -v /etc/nginx/ssl:/etc/nginx/ssl -e "ASPNETCORE_ENVIRONMENT=Development" --name="teryt.webapi" --restart unless-stopped teryt.webapi:1.0.0


# frontend container
docker build -t teryt-frontend:1.0.1 .
docker run -d -it -p 80:80/tcp --name teryt-frontend teryt-frontend:1.0.1