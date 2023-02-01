CREATE PROCEDURE DajParkiWWojewodztwie @WojewodztwoId INTEGER
AS
SELECT u.WojewodztwoId, u.PowiatId, u.GminaId, u.Cecha, u.Nazwa1, u.Nazwa2, u.StanNa, s.StanNa FROM ULICs u
CROSS JOIN SIMCs s
WHERE u.SymNumer = s.SymNumer
AND u.WojewodztwoId = @WojewodztwoId AND s.WojewodztwoId = @WojewodztwoId AND (u.Cecha like '%park%' AND u.Nazwa1 LIKE '%ogród%');