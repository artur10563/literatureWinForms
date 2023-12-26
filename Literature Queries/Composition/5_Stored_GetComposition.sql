CREATE PROCEDURE GetCompositions
AS
BEGIN
	SELECT 
    C.*,
    L.*,
    P.*,
    CO.*
FROM Composition C
LEFT JOIN Language L ON C.language_id = L.id
LEFT JOIN Publication P ON C.publication_id = P.id 
LEFT JOIN Country CO ON P.country_id = CO.id;

END;