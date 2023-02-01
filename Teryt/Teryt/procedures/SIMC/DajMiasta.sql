CREATE PROCEDURE DajMiasta
AS
SELECT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.SymNumer = s.SymPod AND s.RmNumer = 96
