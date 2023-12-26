CREATE PROCEDURE DeletePublication
	@Id INT
AS
BEGIN
	DELETE FROM Publication
	WHERE Id = @Id
END;