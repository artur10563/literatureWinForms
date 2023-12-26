
CREATE PROCEDURE CreateComposition
    @name VARCHAR(255),
    @text VARCHAR(255),
	@author_id INT,
    @language_id INT,
    @publication_id INT,
	@inserted_id INT OUTPUT
AS
BEGIN
    INSERT INTO Composition (name, text, author_id, language_id, publication_id)
    VALUES (@name, @text, @author_id, @language_id, @publication_id);

	SET @inserted_id = SCOPE_IDENTITY();
END;
