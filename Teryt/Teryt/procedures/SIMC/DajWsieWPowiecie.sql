CREATE PROCEDURE DajWsieWPowiecie @Nazwa nvarchar(50) 
AS 
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId FROM SIMCs s
CROSS JOIN TERCs t
WHERE t.NAZWA like 'Olkus%' 
AND t.WojewodztwoId = s.WojewodztwoId AND t.PowiatId = s.PowiatId AND s.RmNumer = 1
ORDER BY s.Nazwa;
GO
--EXEC DajWsieWPowiecie @Nazwa = 'olkus%'