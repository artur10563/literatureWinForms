CREATE PROCEDURE UpdatePublication
    @Id INT,
    @Name NVARCHAR(255),
    @CreatedYear INT,
    @Email NVARCHAR(255),
    @CountryId INT
AS
BEGIN
    UPDATE Publication
    SET
        name = @Name,
        created_year = @CreatedYear,
        email = @Email,
        country_id = @CountryId
    WHERE
        Id = @Id;
END;