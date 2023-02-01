CREATE PROCEDURE DajMiastaWojewodztwie @WojewodztwoId INT
AS
SELECT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.WojewodztwoId = @WojewodztwoId AND 
(s.SymNumer = s.SymPod AND s.RmNumer = 96) AND s.RodzGminaId IN (1,4)
ORDER BY s.Nazwa;

