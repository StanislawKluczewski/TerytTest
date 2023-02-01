CREATE PROCEDURE DajSchroniskaTurystyczneWWojewodztwie @WojewodztwoId INTEGER
AS
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.RmNumer = 7 AND s.WojewodztwoId = @WojewodztwoId;