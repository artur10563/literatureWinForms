CREATE PROCEDURE CreateCollection
	@name varchar(250),
	@description varchar(250),
	@inserted_id int OUTPUT
AS
BEGIN
	INSERT
	INTO Collection(name, description)
	VALUES(@name,@description);

	SET @inserted_id = SCOPE_IDENTITY();
END;