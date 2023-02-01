CREATE PROCEDURE DajDzielnice @WojewodztwoId INTEGER, @PowiatId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.WojewodztwoId = @WojewodztwoId AND t.PowiatId = @PowiatId 
AND t.RodzGminaId IN (1,2,3) ;
