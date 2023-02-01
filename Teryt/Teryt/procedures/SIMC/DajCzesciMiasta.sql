CREATE PROCEDURE DajCzesciMiasta @WojewodztwoId INTEGER, @PowiatId INTEGER, @GminaId INTEGER 
AS
SELECT DISTINCT s.Nazwa, s.WojewodztwoId, s.PowiatId, s.GminaId, s.RodzGminaId, s.StanNa FROM SIMCs s
WHERE s.RmNumer = 99 AND s.RodzGminaId IN (1,4) AND
s.WojewodztwoId = @WojewodztwoId AND s.GminaId = @GminaId AND s.PowiatId = @PowiatId; 
