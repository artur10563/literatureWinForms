CREATE PROCEDURE GetCompositionWithGenres
	@id INT
AS
BEGIN
	SELECT 
		C.*,
		A.*,
		L.*,
		P.*,
		CO.*,
		G.*
	FROM Composition C
	LEFT JOIN Language L ON C.language_id = L.id
	LEFT JOIN Author A ON C.author_id = A.id
	LEFT JOIN Publication P ON C.publication_id = P.id 
	LEFT JOIN Country CO ON P.country_id = CO.id
	LEFT JOIN Composition_Genres CG ON C.id = CG.composition_id
	LEFT JOIN Genre G ON CG.genre_id = G.id
	WHERE C.id = @id;
END;

