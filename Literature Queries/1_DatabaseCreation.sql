CREATE DATABASE Literature
ON
(
    NAME = 'Literature_dat',
    FILENAME = 'C:\LiteratureDB\Literature_dat.mdf', 
    SIZE = 10MB,
    MAXSIZE = 500MB, 
    FILEGROWTH = 5MB 
)
LOG ON
(
    NAME = 'Literature_log',
    FILENAME = 'C:\LiteratureDB\Literature_log.ldf',
    SIZE = 5MB, 
    MAXSIZE = 50MB, 
    FILEGROWTH = 1MB 
);

