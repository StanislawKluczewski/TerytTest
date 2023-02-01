CREATE PROCEDURE DajPowiatyWWojewodztwie @WojewodztwoId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.PowiatId IS NOT NULL AND t.WojewodztwoId = @WojewodztwoId AND t.GminaId = 0 AND t.RodzGminaId = 0
ORDER BY t.Nazwa;
