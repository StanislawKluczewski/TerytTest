docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Studenci2022' -v sqlvolume:/var/opt/mssql -p 1433:1433 -d --name sqlserver --restart unless-stopped  mcr.microsoft.com/mssql/server:2022-latest

# -e przekazywanie argumentu
# ACCEPT_EULA=Y zgadzamy sie z umow� licencyjn�
# -d - odziedzielony(detached mode)
# --name sqlserverdocker 
# --restart unless-stopped
# -v sqlvolume:/var/opt/mssql