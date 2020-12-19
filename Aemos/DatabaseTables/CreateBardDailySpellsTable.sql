CREATE TABLE BardDailySpells
(
	Id			INT NOT NULL PRIMARY KEY IDENTITY,
	CharLevel	INT NOT NULL,
    Level0		INT NULL, 
    Level1		INT NULL, 
    Level2		INT NULL, 
    Level3		INT NULL, 
    Level4		INT NULL, 
    Level5		INT NULL, 
    Level6		INT NULL,
	Level7		INT NULL,
	Level8		INT NULL,
	Level9		INT NULL
)

INSERT INTO BardDailySpells (CharLevel, Level0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9) 
VALUES  (1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1),
		(2, 3, 0, -1, -1, -1, -1, -1, -1, -1, -1),
		(3, 3, 1, -1, -1, -1, -1, -1, -1, -1, -1),
		(4, 3, 2, 0, -1, -1, -1, -1, -1, -1, -1),
		(5, 3, 3, 1, -1, -1, -1, -1, -1, -1, -1),
		(6, 3, 3, 2, -1, -1, -1, -1, -1, -1, -1),
		(7, 3, 3, 2, 0, -1, -1, -1, -1, -1, -1),
		(8, 3, 3, 3, 1, -1, -1, -1, -1, -1, -1),
		(9, 3, 3, 3, 2, -1, -1, -1, -1, -1, -1),
		(10, 3, 3, 3, 2, 0, -1, -1, -1, -1, -1),
		(11, 3, 3, 3, 3, 1, -1, -1, -1, -1, -1),
		(12, 3, 3, 3, 3, 2, -1, -1, -1, -1, -1),
		(13, 3, 3, 3, 3, 2, 0, -1, -1, -1, -1),
		(14, 4, 3, 3, 3, 3, 1, -1, -1, -1, -1),
		(15, 4, 4, 3, 3, 3, 2, -1, -1, -1, -1),
		(16, 4, 4, 4, 3, 3, 2, 0, -1, -1, -1),
		(17, 4, 4, 4, 4, 3, 3, 1, -1, -1, -1),
		(18, 4, 4, 4, 4, 4, 3, 2, -1, -1, -1),
		(19, 4, 4, 4, 4, 4, 4, 3, -1, -1, -1),
		(20, 4, 4, 4, 4, 4, 4, 4, -1, -1, -1)