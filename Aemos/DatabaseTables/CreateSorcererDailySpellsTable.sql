CREATE TABLE SorcererDailySpells
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

INSERT INTO SorcererDailySpells (CharLevel, Level0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9) 
VALUES (1, 5, 3, -1, -1, -1, -1, -1, -1, -1, -1)
	,(2, 6, 4, -1, -1, -1, -1, -1, -1, -1, -1)
	,(3, 6, 5, -1, -1, -1, -1, -1, -1, -1, -1)
	,(4, 6, 6, 3, -1, -1, -1, -1, -1, -1, -1)
	,(5, 6, 6, 4, -1, -1, -1, -1, -1, -1, -1)
	,(6, 6, 6, 5, 3, -1, -1, -1, -1, -1, -1)
	,(7, 6, 6, 6, 4, -1, -1, -1, -1, -1, -1)
	,(8, 6, 6, 6, 5, 3, -1, -1, -1, -1, -1)
	,(9, 6, 6, 6, 6, 4, -1, -1, -1, -1, -1)
	,(10, 6, 6, 6, 6, 5, 3, -1, -1, -1, -1)
	,(11, 6, 6, 6, 6, 6, 4, -1, -1, -1, -1)
	,(12, 6, 6, 6, 6, 6, 5, 3, -1, -1, -1)
	,(13, 6, 6, 6, 6, 6, 6, 4, -1, -1, -1)
	,(14, 6, 6, 6, 6, 6, 6, 5, 3, -1, -1)
	,(15, 6, 6, 6, 6, 6, 6, 6, 4, -1, -1)
	,(16, 6, 6, 6, 6, 6, 6, 6, 5, 3, -1)
	,(17, 6, 6, 6, 6, 6, 6, 6, 6, 4, -1)
	,(18, 6, 6, 6, 6, 6, 6, 6, 6, 5, 3)
	,(19, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4)
	,(20, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6)
