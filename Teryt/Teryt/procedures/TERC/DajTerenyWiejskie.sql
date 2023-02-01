CREATE PROCEDURE DajTerenyWiejskie @WojewodztwoId INTEGER, @PowiatId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.RodzGminaId = 5 AND t.WojewodztwoId = @WojewodztwoId AND t.PowiatId = @PowiatId
AND t.GminaId = 0 AND t.RodzGminaId = 0;
