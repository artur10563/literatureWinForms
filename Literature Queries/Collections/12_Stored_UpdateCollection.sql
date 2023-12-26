CREATE PROCEDURE UpdateCollection
	@Id int,
	@name varchar(250),
	@description varchar(250)
AS
BEGIN
	UPDATE Collection
	SET 
	name = @name,
	description = @description
	WHERE id = @Id;
END;

