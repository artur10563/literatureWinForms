CREATE PROCEDURE DeleteCollection
	@Id int
AS
BEGIN	
	DELETE 
	FROM Collection
	WHERE id = @Id;
END;

