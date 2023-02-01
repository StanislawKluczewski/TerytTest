CREATE PROCEDURE DajWojewodztwa 
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.PowiatId IS NULL AND t.GminaId IS NULL AND t.RodzGminaId IS NULL;
