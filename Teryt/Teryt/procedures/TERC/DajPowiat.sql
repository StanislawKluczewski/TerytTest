CREATE PROCEDURE DajPowiat @WojewodztwoId INTEGER, @PowiatId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.WojewodztwoId = @WojewodztwoId AND t.PowiatId = @PowiatId 
AND t.GminaId = 0 AND t.RodzGminaId = 0;
