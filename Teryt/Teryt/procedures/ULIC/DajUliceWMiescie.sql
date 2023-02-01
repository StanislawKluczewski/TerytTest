CREATE PROCEDURE DajUliceWMiescie @WojewodztwoId INTEGER, @PowiatId INTEGER, @GminaId INTEGER
AS
SELECT DISTINCT u.WojewodztwoId, u.PowiatId, u.GminaId, u.Cecha, u.Nazwa1, u.Nazwa2, u.StanNa, s.Nazwa FROM ULICs u
CROSS JOIN SIMCs s
WHERE u.WojewodztwoId = @WojewodztwoId
AND u.PowiatId = @PowiatId AND u.GminaId = @GminaId AND s.WojewodztwoId = u.WojewodztwoId AND s.PowiatId = u.PowiatId AND s.GminaId = u.GminaId AND u.RodzGminaId = 4
AND s.RodzGminaId = 4 AND s.RmNumer = 99 AND u.Cecha like '%ul.%';

--EXEC DajUliceWMiescie @WojewodztwoId = 12, @PowiatId = 12, @GminaId = 5;