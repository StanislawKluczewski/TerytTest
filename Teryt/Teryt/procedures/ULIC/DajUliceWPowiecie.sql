CREATE PROCEDURE DajUliceWPowiecie @WojewodztwoId INTEGER, @PowiatId INTEGER
AS
SELECT DISTINCT u.WojewodztwoId, u.PowiatId, u.GminaId, u.Cecha, u.Nazwa1, u.Nazwa2, u.StanNa FROM ULICs u
WHERE u.WojewodztwoId = @WojewodztwoId
AND u.PowiatId = @PowiatId AND u.Cecha like '%ul.%';

