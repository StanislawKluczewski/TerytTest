CREATE PROCEDURE DajMiastoPoNazwie @Nazwa nvarchar(50)
AS
SELECT *
FROM [Terryt].[dbo].[SIMC]

WHERE RM_NUMER = 96 AND  SYM_NUMER = SYMPOD AND NAZWA = @Nazwa;
GO
-- EXEC DajMiastoPoNazwie @Nazwa = '%Wa%'