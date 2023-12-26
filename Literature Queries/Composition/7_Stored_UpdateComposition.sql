CREATE PROCEDURE UpdateComposition
	@Id INT,
	@name VARCHAR(255),
	@text TEXT,
	@author_id INT,
	@language_id INT,
	@publication_id INT
AS
BEGIN
	UPDATE Composition 
		SET 
		name = @name,
		text = @text,
		language_id = @language_id,
		author_id = @author_id
	WHERE Id = @Id;
END;