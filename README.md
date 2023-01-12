# Teryt

 Teryt is national registry of territorial division of Poland. The line of action of this web application has plenty in common with official Teryt, which is governmental web application. For more information You can explore official Teryt:
  https://eteryt.stat.gov.pl/eTeryt/rejestr_teryt/udostepnianie_danych/baza_teryt/uzytkownicy_indywidualni/wyszukiwanie/wyszukiwanie.aspx?contrast=default
 
 This web application will give You a hand in case looking for records like voivodeships, counties, cities, villages or streets etc.
 You can reviewing units of territorial division of Poland or search for it.

You can develop and change the code in a very real sense.

## License

[MIT](https://choosealicense.com/licenses/mit/)


## Authors

- [@StanislawKluczewski](https://github.com/StanislawKluczewski)


## Technological description

#Used Technologies:

#ASP .NET CORE 6.0(Long Time Support)
#Microsoft SQL Server 2022
#Docker 20.10.21


## API Reference

### TERC 
##### Get all voivodeships

```http
  POST /api/TERC/DajWojewodztwa
```
##### Get voivodeship by id

```http
  POST /api/TERC/DajWojewodztwo
```

##### Get all cities

```http
  POST /api/TERC/DajMiasta
```

##### Get all counties

```http
  POST /api/TERC/DajPowiaty
```

### SIMC

##### Get all cities

```http
  POST /api/SIMC/Miasta
```

##### Get city by name

```http
  POST /api/SIMC/DajMiasto
```

### ULIC

```http
  POST /api/ULIC/DajUlice
```
