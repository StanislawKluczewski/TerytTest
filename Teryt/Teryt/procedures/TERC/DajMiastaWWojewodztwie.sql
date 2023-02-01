CREATE PROCEDURE DajMiastaWWojewodztwie @WojewodztwoId INTEGER
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.RodzGminaId in(3, 4, 5) AND t.WojewodztwoId = @WojewodztwoId; 
