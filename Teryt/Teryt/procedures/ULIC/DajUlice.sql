CREATE PROCEDURE DajUlice
AS
SELECT *
  FROM [Terryt].[dbo].[ULIC]
WHERE CECHA = 'ul.';
GO

-- EXEC DajUlice
