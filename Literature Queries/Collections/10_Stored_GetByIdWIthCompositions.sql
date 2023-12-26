CREATE PROCEDURE GetCollectionWithCompositions
	@Id int
AS
BEGIN
	SELECT 
	col.id,
	col.name,
	col.description,
	com.id,
	com.name
	FROM Collection col
	LEFT JOIN Composition_Collections cc
		ON cc.collection_id = col.id
	LEFT JOIN Composition com
		ON com.id = cc.composition_id
	WHERE col.id = @Id;
END;

