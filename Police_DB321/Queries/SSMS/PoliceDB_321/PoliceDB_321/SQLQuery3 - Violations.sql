USE PoliceDB_321
GO

DROP TABLE Violations;
GO
CREATE TABLE Violations
(
   violation_id SMALLINT NOT NULL PRIMARY KEY,
   violation_descriprion NVARCHAR (1024) NOT NULL,
   [start_date] DATE,
   --[penalty] SMALLMONEY 
)
GO

--DECLARE @violationsPK NVARCHAR(1024) = 
--(
--SELECT [name]
--FROM sys.key_constraints
--WHERE type = 'PK'
--AND OBJECT_NAME(parent_object_id) = N'Violations'
--)

--PRINT (@violationsPK)

--ALTER TABLE Violations DROP CONSTRAINT PK__Violatio__8A9893631C145F65
--ALTER TABLE Violations ALTER COLUMN [violation_id] SMALLINT NOT NULL 
--ALTER TABLE Violations ADD CONSTRAINT PK_ViolationID PRIMARY KEY CLUSTERED (violation_id)
--ALTER TABLE Violations ALTER COLUMN [violation_description] NVARCHAR (1024) NOT NULL
--ALTER TABLE Violations ADD  penalty SMALLMONEY NULL
--ALTER TABLE Violations ADD [start_date] DATE