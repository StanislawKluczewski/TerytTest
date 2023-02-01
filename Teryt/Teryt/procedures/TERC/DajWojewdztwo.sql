CREATE PROCEDURE DajWojewodztwo @WojewodztwoId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.WojewodztwoId = @WojewodztwoId 
AND t.PowiatId IS NULL AND t.GminaId IS NULL AND t.RodzGminaId IS NULL;
