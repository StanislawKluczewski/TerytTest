CREATE PROCEDURE DajDelegatury @WojewodztwoId INTEGER
AS
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
CROSS JOIN TERCs t
WHERE s.WojewodztwoId = t.WojewodztwoId AND 
t.WojewodztwoId = @WojewodztwoId AND 
t.NazwaTerytorialna LIKE 'delegatura' AND s.RmNumer = 98;