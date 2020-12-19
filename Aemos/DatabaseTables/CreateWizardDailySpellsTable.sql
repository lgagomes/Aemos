CREATE TABLE WizardDailySpells
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

INSERT INTO WizardDailySpells (CharLevel, Level0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9) 
VALUES (1, 3, 1, -1, -1, -1, -1, -1, -1, -1, -1)
	,(2, 4, 2, -1, -1, -1, -1, -1, -1, -1, -1)
	,(3, 4, 2, 1, -1, -1, -1, -1, -1, -1, -1)
	,(4, 4, 3, 2, -1, -1, -1, -1, -1, -1, -1)
	,(5, 4, 3, 2, 1, -1, -1, -1, -1, -1, -1)
	,(6, 4, 3, 3, 2, -1, -1, -1, -1, -1, -1)
	,(7, 4, 4, 3, 2, 1, -1, -1, -1, -1, -1)
	,(8, 4, 4, 3, 3, 2, -1, -1, -1, -1, -1)
	,(9, 4, 4, 4, 3, 2, 1, -1, -1, -1, -1)
	,(10, 4, 4, 4, 3, 3, 2, -1, -1, -1, -1)
	,(11, 4, 4, 4, 4, 3, 2, 1, -1, -1, -1)
	,(12, 4, 4, 4, 4, 3, 3, 2, -1, -1, -1)
	,(13, 4, 4, 4, 4, 4, 3, 2, 1, -1, -1)
	,(14, 4, 4, 4, 4, 4, 3, 3, 2, -1, -1)
	,(15, 4, 4, 4, 4, 4, 4, 3, 2, 1, -1)
	,(16, 4, 4, 4, 4, 4, 4, 3, 3, 2, -1)
	,(17, 4, 4, 4, 4, 4, 4, 4, 3, 2, 1)
	,(18, 4, 4, 4, 4, 4, 4, 4, 3, 3, 2)
	,(19, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3)
	,(20, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4)
