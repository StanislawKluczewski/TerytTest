CREATE PROCEDURE DajOsady @WojewodztwoId INTEGER, @PowiatId INTEGER
AS
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.RmNumer in (4,5) AND s.WojewodztwoId = @WojewodztwoId AND s.PowiatId = @PowiatId;