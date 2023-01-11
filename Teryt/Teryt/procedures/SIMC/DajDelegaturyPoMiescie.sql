CREATE PROCEDURE DajDelegaturyMiasta @Nazwa nvarchar(50)
AS
SELECT DISTINCT  m.Nazwa, m.WojewodztwoId,m.PowiatId, m.GminaId, m.SymNumer, m.SymNumer, t.NazwaTerytorialna FROM SIMCs m
CROSS JOIN TERCs t
WHERE t.NazwaTerytorialna like 'delegatura' AND m.RmNumer = 98 
AND m.Nazwa like @Nazwa
AND t.WojewodztwoId = m.WojewodztwoId AND t.PowiatId = m.PowiatId;
GO
-- EXEC DajDelegaturyMiasta @Nazwa = 'krak%'

