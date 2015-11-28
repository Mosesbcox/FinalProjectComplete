/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO ProjectHolder AS Target 
USING (VALUES 
        (1, 'Birdybird', 'Creating classes for the first time', '~img-slkd-sdf', 'www.github.com/sdlkfj/sdls', 'C#')
		
		
		

) 
AS Source (Id, Name, ProjectDescription, Screenshot, LinkToRepository, LanguagesUsed) 
ON Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Name, ProjectDescription, Screenshot, LinkToRepository, LanguagesUsed) 
VALUES (Name, ProjectDescription, Screenshot, LinkToRepository, LanguagesUsed);
