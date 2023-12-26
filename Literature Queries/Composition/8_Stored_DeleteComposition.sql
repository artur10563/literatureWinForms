CREATE PROCEDURE DeleteComposition
	@Id INT
AS
BEGIN
	DELETE 
	FROM Composition
	Where id = @Id;
End;