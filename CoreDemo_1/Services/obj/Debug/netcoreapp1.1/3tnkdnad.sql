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
    `BirthDate` datetime NOT NULL DEFAULT 2017/7/1 18:08:08,
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
    `EndDate` datetime NOT NULL DEFAULT 2017/7/1 18:08:08,
    `Name` nvarchar(120) NOT NULL,
    `RecordStatus` int NOT NULL,
    `StartDate` datetime NOT NULL DEFAULT 2017/7/1 18:08:08,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Contract_Employee_EmployeeId` FOREIGN KEY (`EmployeeId`) REFERENCES `Employee` (`Id`) ON DELETE RESTRICT
);

CREATE INDEX `IX_Contract_EmployeeId` ON Contract (`EmployeeId`);

CREATE INDEX `IX_Employee_DepartmentId` ON Employee (`DepartmentId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20170701100808_init', '1.1.2');

ALTER TABLE Employee MODIFY `JobPosition` int NOT NULL DEFAULT 1;

ALTER TABLE Employee MODIFY `BirthDate` datetime NOT NULL DEFAULT 2017/7/1 18:13:30;

ALTER TABLE Contract MODIFY `StartDate` datetime NOT NULL DEFAULT 2017/7/1 18:13:30;

ALTER TABLE Contract MODIFY `EndDate` datetime NOT NULL DEFAULT 2017/7/1 18:13:30;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20170701101330_init_1', '1.1.2');

ALTER TABLE Employee MODIFY `JobPosition` int NOT NULL DEFAULT 1;

ALTER TABLE Employee MODIFY `BirthDate` datetime NOT NULL DEFAULT 2017/7/1 18:37:44;

ALTER TABLE Contract MODIFY `StartDate` datetime NOT NULL DEFAULT 2017/7/1 18:37:44;

ALTER TABLE Contract MODIFY `EndDate` datetime NOT NULL DEFAULT 2017/7/1 18:37:44;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20170701103745_init_3', '1.1.2');

