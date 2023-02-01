CREATE PROCEDURE DajCaleWsie @WojewodztwoId INTEGER, @PowiatId INTEGER, @GminaId INTEGER
AS
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.RmNumer in (1, 2, 3) AND s.WojewodztwoId = @WojewodztwoId AND s.PowiatId = @PowiatId;