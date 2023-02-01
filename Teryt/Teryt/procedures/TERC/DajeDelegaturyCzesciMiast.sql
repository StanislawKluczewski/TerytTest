CREATE PROCEDURE DajDelegaturyCzesciMiasta 
AS
SELECT t.Nazwa, t.NazwaTerytorialna, t.WojewodztwoId, t.StanNa FROM TERCs t
WHERE t.RodzGminaId IN (8,9)
ORDER BY t.Nazwa;
