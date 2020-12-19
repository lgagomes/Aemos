CREATE TABLE SorcererKnownSpells
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

INSERT INTO SorcererKnownSpells (CharLevel, Level0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9) 
VALUES (1, 4, 2, -1, -1, -1, -1, -1, -1, -1, -1)
	,(2, 5, 2, -1, -1, -1, -1, -1, -1, -1, -1)
	,(3, 5, 3, -1, -1, -1, -1, -1, -1, -1, -1)
	,(4, 6, 3, 1, -1, -1, -1, -1, -1, -1, -1)
	,(5, 6, 4, 2, -1, -1, -1, -1, -1, -1, -1)
	,(6, 7, 4, 2, 1, -1, -1, -1, -1, -1, -1)
	,(7, 7, 5, 3, 2, -1, -1, -1, -1, -1, -1)
	,(8, 8, 5, 3, 2, 1, -1, -1, -1, -1, -1)
	,(9, 8, 5, 4, 3, 2, -1, -1, -1, -1, -1)
	,(10, 9, 5, 4, 3, 2, 1, -1, -1, -1, -1)
	,(11, 9, 5, 5, 4, 3, 2, -1, -1, -1, -1)
	,(12, 9, 5, 5, 4, 3, 2, 1, -1, -1, -1)
	,(13, 9, 5, 5, 4, 4, 3, 2, -1, -1, -1)
	,(14, 9, 5, 5, 4, 4, 3, 2, 1, -1, -1)
	,(15, 9, 5, 5, 4, 4, 4, 3, 2, -1, -1)
	,(16, 9, 5, 5, 4, 4, 4, 3, 2, 1, -1)
	,(17, 9, 5, 5, 4, 4, 4, 3, 3, 2, -1)
	,(18, 9, 5, 5, 4, 4, 4, 3, 3, 2, 1)
	,(19, 9, 5, 5, 4, 4, 4, 3, 3, 3, 2)
	,(20, 9, 5, 5, 4, 4, 4, 3, 3, 3, 3)
