using CIS_106_ASSIGNMENT_2.models;
using CIS_106_ASSIGNMENT_2.services;

// Defined available power ups.
PowerUp rocketBoots = new PowerUp{
    Id = "PU1",
    Name = "Rocket Boots"
};
PowerUp superMallet = new PowerUp{
    Id = "PU2",
    Name = "Super Mallet"
};
PowerUp dogFood = new PowerUp{
    Id = "PU3",
    Name = "Dog Food"
};
PowerUp speedyGranola = new PowerUp{
    Id = "PU4",
    Name = "Speedy Granola"
};
PowerUp magicConchShell = new PowerUp{
    Id = "PU5",
    Name = "Magic Conch Shell"
};
PowerUp superLooper = new PowerUp{
    Id = "PU6",
    Name = "Super Looper"
};

// Defined list of Characters available in the game with their power ups and all fields populated.
List <Character> characters = new List<Character>{
    new Character{
        Id = "C1",
        Name = "Anaïs",
        Health = 20,
        PowerUps = new List<PowerUp>{
            rocketBoots, dogFood, speedyGranola, superLooper
        }
    },
    new Character{
        Id = "C2",
        Name = "Robert",
        Health = 24,
        PowerUps = new List<PowerUp>{
            rocketBoots, speedyGranola, superLooper, superMallet, magicConchShell
        }
    },
    new Character{
        Id = "C3",
        Name = "Douglas",
        Health = 28,
        PowerUps = new List<PowerUp>{
            rocketBoots, dogFood, speedyGranola, superLooper, superMallet, magicConchShell
        }
    },
    new Character{
        Id = "C4",
        Name = "Kayle",
        Health = 15,
        PowerUps = new List<PowerUp>{
            superMallet, superLooper
        }
    }
};

// Defined levels available in the game.
List<Level> levels = new List<Level> {
    new Level{
        Id = "L1",
        Name = "Cloud World",
        TimeLimit = 120,
        PowerUps = new List<PowerUp>{
            rocketBoots, speedyGranola
        }
    },
    new Level{
        Id = "L2",
        Name = "Volcano Zone",
        TimeLimit = 180,
        PowerUps = new List<PowerUp>{
            dogFood, superMallet
        }
    },
    new Level{
        Id = "L3",
        Name = "L'Alpes du Ski",
        TimeLimit = 60,
        PowerUps = new List<PowerUp>{
            superLooper, magicConchShell
        }
    }
};

// This calls the method to generate the Progress Report. Go to the ProgressReportGenerator class to implement the GenerateProgressReport method!
ProgressReportGenerator.GenerateProgressReport(characters, levels);