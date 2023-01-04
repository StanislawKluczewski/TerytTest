CREATE PROCEDURE DajWojewodztwoPoNazwie @Nazwa nvarchar(30)
AS
SELECT WOJEWODZTWO_ID, NAZWA, NAZWA_TERYTORIALNA, STAN_NA
FROM [Terryt].[dbo].[TERC]
WHERE NAZWA_TERYTORIALNA like 'województwo' AND NAZWA like @Nazwa;
GO

--EXEC DajWojewodztwoPoNazwie @Nazwa ='%Lub%';