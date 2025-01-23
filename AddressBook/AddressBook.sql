----------select-----------------------
select * from Country
select * from State
select * from City


-- Creating the Country table
CREATE TABLE Country (
    CountryID INT PRIMARY KEY IDENTITY(1,1),      -- Primary Key, Auto Increment
    CountryName VARCHAR(100) UNIQUE NOT NULL,      -- Unique Key, Not Null
    CountryCode VARCHAR(50) NOT NULL,              -- Not Null
    CreationDate DATETIME NOT NULL DEFAULT GETDATE()  -- Default value set to current date/time
);

-- Creating the State table
CREATE TABLE State (
    StateID INT PRIMARY KEY IDENTITY(1,1),        -- Primary Key, Auto Increment
    CountryID INT NOT NULL,                        -- Foreign Key referencing Country table
    StateName VARCHAR(100) UNIQUE NOT NULL,        -- Unique Key, Not Null
    StateCode VARCHAR(50) NOT NULL,                -- Not Null
    CreationDate DATETIME NOT NULL DEFAULT GETDATE(), -- Default value set to current date/time
    FOREIGN KEY (CountryID) REFERENCES Country(CountryID)  -- Foreign Key Constraint
);

-- Creating the City table
CREATE TABLE City (
    CityID INT PRIMARY KEY IDENTITY(1,1),         -- Primary Key, Auto Increment
    StateID INT NOT NULL,                          -- Foreign Key referencing State table
    CityName VARCHAR(100) UNIQUE NOT NULL,         -- Unique Key, Not Null
    STDCode VARCHAR(50) NULL,                      -- Null allowed
    PinCode VARCHAR(6) NULL,                       -- Null allowed
    CreationDate DATETIME NOT NULL DEFAULT GETDATE(), -- Default value set to current date/time
    FOREIGN KEY (StateID) REFERENCES State(StateID)   -- Foreign Key Constraint
);

-----------------------Store Procedure--------------------------
-- Stored Procedure: Select All Countries
CREATE PROCEDURE Sp_MST_Country_SelectAll
AS
BEGIN
    SELECT CountryID, CountryName, CountryCode, CreationDate
    FROM Country;
END;

-- Stored Procedure: Select Country by ID
CREATE PROCEDURE Sp_MST_Country_SelectByID
    @CountryID INT
AS
BEGIN
    SELECT CountryID, CountryName, CountryCode, CreationDate
    FROM Country
    WHERE CountryID = @CountryID;
END;

-- Stored Procedure: Insert a New Country
CREATE PROCEDURE Sp_MST_Country_Insert
    @CountryName VARCHAR(100),
    @CountryCode VARCHAR(50)
AS
BEGIN
    INSERT INTO Country (CountryName, CountryCode, CreationDate)
    VALUES (@CountryName, @CountryCode, GETDATE());
END;

-- Stored Procedure: Update an Existing Country
CREATE PROCEDURE Sp_MST_Country_Update
    @CountryID INT,
    @CountryName VARCHAR(100),
    @CountryCode VARCHAR(50)
AS
BEGIN
    UPDATE Country
    SET CountryName = @CountryName,
        CountryCode = @CountryCode,
        CreationDate = GETDATE()
    WHERE CountryID = @CountryID;
END;

-- Stored Procedure: Delete a Country by ID
CREATE PROCEDURE Sp_MST_Country_DeleteByID
    @CountryID INT
AS
BEGIN
    DELETE FROM Country
    WHERE CountryID = @CountryID;
END;

---------------------------exicute------------------------
EXEC Sp_MST_Country_SelectAll;

EXEC Sp_MST_Country_SelectByID @CountryID = 1;
EXEC Sp_MST_Country_Insert @CountryName = 'India', @CountryCode = 'IN';
EXEC Sp_MST_Country_Insert @CountryName = 'United State', @CountryCode = 'US';

EXEC Sp_MST_Country_Update @CountryID = 1, @CountryName = 'United Kingdom', @CountryCode = 'GB';
EXEC Sp_MST_Country_DeleteByID @CountryID = 1;

------------------------------Store Procedure State----------------------------------------

-- Stored Procedure: Select All States
CREATE PROCEDURE Sp_MST_State_SelectAll
AS
BEGIN
    SELECT StateID, CountryID, StateName, StateCode, CreationDate
    FROM State;
END;

-- Stored Procedure: Select State by ID
CREATE PROCEDURE Sp_MST_State_SelectByID
    @StateID INT
AS
BEGIN
    SELECT StateID, CountryID, StateName, StateCode, CreationDate
    FROM State
    WHERE StateID = @StateID;
END;

-- Stored Procedure: Insert a New State
CREATE PROCEDURE Sp_MST_State_Insert
    @CountryID INT,
    @StateName VARCHAR(100),
    @StateCode VARCHAR(50)
AS
BEGIN
    INSERT INTO State (CountryID, StateName, StateCode, CreationDate)
    VALUES (@CountryID, @StateName, @StateCode, GETDATE());
END;

-- Stored Procedure: Update an Existing State
CREATE PROCEDURE Sp_MST_State_Update
    @StateID INT,
    @CountryID INT,
    @StateName VARCHAR(100),
    @StateCode VARCHAR(50)
AS
BEGIN
    UPDATE State
    SET CountryID = @CountryID,
        StateName = @StateName,
        StateCode = @StateCode,
        CreationDate = GETDATE()
    WHERE StateID = @StateID;
END;

-- Stored Procedure: Delete a State by ID
CREATE PROCEDURE Sp_MST_State_DeleteByID
    @StateID INT
AS
BEGIN
    DELETE FROM State
    WHERE StateID = @StateID;
END;

-------------------------Exicute-------------------------------

EXEC Sp_MST_State_SelectAll;
EXEC Sp_MST_State_SelectByID @StateID = 1;
EXEC Sp_MST_State_Insert @CountryID = 1, @StateName = 'California', @StateCode = 'CA';
EXEC Sp_MST_State_Insert @CountryID = 1, @StateName = 'United State', @StateCode = 'US';

EXEC Sp_MST_State_Update @StateID = 1, @CountryID = 1, @StateName = 'New York', @StateCode = 'NY';
EXEC Sp_MST_State_DeleteByID @StateID = 1;

---------------------------------- store procedure for City----------------------------
-- Stored Procedure: Select All Cities
CREATE PROCEDURE Sp_MST_City_SelectAll
AS
BEGIN
    SELECT CityID, StateID, CityName, STDCode, PinCode, CreationDate
    FROM City;
END;

-- Stored Procedure: Select City by ID
CREATE PROCEDURE Sp_MST_City_SelectByID
    @CityID INT
AS
BEGIN
    SELECT CityID, StateID, CityName, STDCode, PinCode, CreationDate
    FROM City
    WHERE CityID = @CityID;
END;

-- Stored Procedure: Insert a New City
CREATE PROCEDURE Sp_MST_City_Insert
    @StateID INT,
    @CityName VARCHAR(100),
    @STDCode VARCHAR(50) = NULL,
    @PinCode VARCHAR(6) = NULL
AS
BEGIN
    INSERT INTO City (StateID, CityName, STDCode, PinCode, CreationDate)
    VALUES (@StateID, @CityName, @STDCode, @PinCode, GETDATE());
END;

-- Stored Procedure: Update an Existing City
CREATE PROCEDURE Sp_MST_City_Update
    @CityID INT,
    @StateID INT,
    @CityName VARCHAR(100),
    @STDCode VARCHAR(50) = NULL,
    @PinCode VARCHAR(6) = NULL
AS
BEGIN
    UPDATE City
    SET StateID = @StateID,
        CityName = @CityName,
        STDCode = @STDCode,
        PinCode = @PinCode,
        CreationDate = GETDATE()
    WHERE CityID = @CityID;
END;

-- Stored Procedure: Delete a City by ID
CREATE PROCEDURE Sp_MST_City_DeleteByID
    @CityID INT
AS
BEGIN
    DELETE FROM City
    WHERE CityID = @CityID;
END;

--------------------------exicute-----------------------------

EXEC Sp_MST_City_SelectAll;
EXEC Sp_MST_City_SelectByID @CityID = 1;
EXEC Sp_MST_City_Insert @StateID = 1, @CityName = 'Los Angeles', @STDCode = '323', @PinCode = '90001';
EXEC Sp_MST_City_Insert @StateID = 1, @CityName = 'India', @STDCode = '111', @PinCode = '90002';
EXEC Sp_MST_City_Update @CityID = 1, @StateID = 1, @CityName = 'New York', @STDCode = '212', @PinCode = '10001';
EXEC Sp_MST_City_DeleteByID @CityID = 1;

