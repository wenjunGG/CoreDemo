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

ALTER TABLE Employee MODIFY `JobPosition` int NOT NULL DEFAULT 1;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20170701142255_Init_5', '1.1.2');

