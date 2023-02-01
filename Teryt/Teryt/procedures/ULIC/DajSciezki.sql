CREATE PROCEDURE DajSciezki 
AS
SELECT u.WojewodztwoId, u.PowiatId, u.GminaId, u.Cecha, u.Nazwa1, u.Nazwa2, u.StanNa FROM ULICs u
WHERE u.Cecha LIKE '%droga%';