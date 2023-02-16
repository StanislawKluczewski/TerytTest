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

# Used Technologies:

- ASP .NET CORE 6.0(Long Time Support)
- Microsoft SQL Server 2022
- Docker 20.10.21
- Angular 14.0.1


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

##### Get all cities in voivodeship by id

```http
  POST /api/TERC/DajMiastaWWojewodztwie
```

##### Get all counties in voivodeship by id

```http
  POST /api/TERC/DajPowiatyWWojewodztwie
```


##### Get county by id

```http
  POST /api/TERC/DajPowiat
```

##### Get all Districts

```http
  POST /api/TERC/DajGminy
```

##### Get all Delegancies And Quarters

```http
  POST /api/TERC/DajDelegaturyDzielnice
```

##### Get all Countrysides

```http
  POST /api/TERC/DajTerenyWiejskieWPowiecie
```

### SIMC

##### Get all cities

```http
  POST /api/SIMC/DajMiasta
```

##### Get city in voivodeship by id

```http
  POST /api/SIMC/DajMiastaWWojewodztwie
```

##### Get villages in county

```http
  POST /api/SIMC/DajWsieWPowiecie
```

##### Get delegancies in Cities

```http
  POST /api/SIMC/DajDelegaturyMiast
```

##### Get parts of localities by id

```http
  POST /api/SIMC/DajCzesciMiejscowosci
```

##### Get whole villages(with colonies and settlements) by id

```http
  POST /api/SIMC/DajCaleWsie
```

##### Get settlements in county by id

```http
  POST /api/SIMC/DajOsadyWPowiecie
```

##### Get parts of city by id

```http
  POST /api/SIMC/DajCzesciMiasta
```

##### Get touristic shelters in voivodeship by id

```http
  POST /api/SIMC/DajSchroniskaTurstyczne
```

### ULIC

##### Get street in county

```http
  POST /api/ULIC/DajUliceWPowiecie
```

##### Get market squares in voivodeship by id

```http
  POST /api/ULIC/DajRynki
```

##### Get streets in city

```http
  POST /api/ULIC/DajUliceWMiescie
```

##### Get the paths

```http
  POST /api/ULIC/DajDrogi
```

##### Get the bridges in voivodeship by id

```http
  POST /api/ULIC/DajDrogi
```

##### Get the parks in voivodeship by id

```http
  POST /api/ULIC/DajParkiWWojewodztwie
```

##### Get the parks in voivodeship by id

```http
  POST /api/ULIC/DajParkiWWojewodztwie
```

