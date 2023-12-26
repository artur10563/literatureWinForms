USE Literature;
Go

CREATE TABLE Genre
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Country
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Language
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(50) NOT NULL UNIQUE
);
GO

--Видавництво
CREATE TABLE Publication
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(255) NOT NULL,
created_year INT NOT NULL CHECK (created_year >= 0),
email varchar(50) UNIQUE NOT NULL,
country_id INT,
	FOREIGN KEY (country_id) REFERENCES Country(id) ON DELETE SET NULL
);
GO

CREATE TABLE Collection
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(255) NOT NULL UNIQUE,
description varchar(250) NOT NULL
);
GO

CREATE TABLE Author
(
id int IDENTITY(1,1) PRIMARY KEY,
firstname varchar(50) NOT NULL,
lastname varchar(50),
country_id int,
	FOREIGN KEY (country_id) REFERENCES Country(id) ON DELETE SET NULL
);
GO

CREATE TABLE Composition
(
id int IDENTITY(1,1) PRIMARY KEY,
name varchar(250) NOT NULL,
text TEXT NOT NULL,
publication_id int,
	FOREIGN KEY (publication_id) REFERENCES Publication(id) ON DELETE SET NULL,
language_id int,
	FOREIGN KEY (language_id) REFERENCES Language(id) ON DELETE CASCADE,
author_id int,
	FOREIGN KEY (author_id) REFERENCES Author(id) ON DELETE CASCADE
);
GO

CREATE TABLE Composition_Collections
(
id int IDENTITY(1,1) PRIMARY KEY,
composition_id int,
	FOREIGN KEY (composition_id) REFERENCES Composition(id) ON DELETE CASCADE,
collection_id int,
	FOREIGN KEY (collection_id) REFERENCES Collection(id) ON DELETE CASCADE,
	 CONSTRAINT UC_Composition_Collections UNIQUE (composition_id, collection_id)
);
GO


CREATE TABLE Composition_Genres
(
    id int IDENTITY(1,1) PRIMARY KEY,
    composition_id int,
    FOREIGN KEY (composition_id) REFERENCES Composition(id) ON DELETE CASCADE,
    genre_id int,
    FOREIGN KEY (genre_id) REFERENCES Genre(id) ON DELETE CASCADE,
    CONSTRAINT UC_Composition_Genres UNIQUE (composition_id, genre_id)
);
GO





