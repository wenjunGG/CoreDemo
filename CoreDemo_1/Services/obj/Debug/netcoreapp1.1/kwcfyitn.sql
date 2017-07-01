  IF EXISTS(SELECT 1 FROM information_schema.tables 
  WHERE table_name = '
__EFMigrationsHistory' AND table_schema = DATABASE()) 
BEGIN
CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` nvarchar(150) NOT NULL,
    `ProductVersion` nvarchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

END;

CREATE TABLE `Department` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Description` varchar(255) NOT NULL,
    `Name` nvarchar(200) NOT NULL,
    `RecordStatus` int NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Employee` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `DepartmentId` int NOT NULL,
    `FirstName` nvarchar(120) NOT NULL,
    `JobPosition` int NOT NULL DEFAULT 1,
    `LastName` nvarchar(120) NOT NULL,
    `RecordStatus` int NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Employee_Department_DepartmentId` FOREIGN KEY (`DepartmentId`) REFERENCES `Department` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Contract` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Amount` int NOT NULL,
    `EmployeeId` int NOT NULL,
    `Name` nvarchar(120) NOT NULL,
    `RecordStatus` int NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Contract_Employee_EmployeeId` FOREIGN KEY (`EmployeeId`) REFERENCES `Employee` (`Id`) ON DELETE RESTRICT
);

CREATE INDEX `IX_Contract_EmployeeId` ON Contract (`EmployeeId`);

CREATE INDEX `IX_Employee_DepartmentId` ON Employee (`DepartmentId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20170701142519_Init_6', '1.1.2');

