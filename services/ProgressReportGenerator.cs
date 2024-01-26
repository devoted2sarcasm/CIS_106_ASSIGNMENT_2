using CIS_106_ASSIGNMENT_2.models;

namespace CIS_106_ASSIGNMENT_2.services
{

    static class ProgressReportGenerator
    {

        public static void GenerateProgressReport(List<Character> characters, List<Level> levels)
        {
            public static void GenerateProgressReport(List<Character> characters, List<Level> levels)
        {
            foreach (Character character in characters) {
                Console.WriteLine($"Progress report for {character.Name}:");
                List<PowerUp> collectedPowerUps = character.PowerUps;
                foreach (Level level in levels) {
                    List<PowerUp> levelPowers = level.PowerUps;
                    Console.WriteLine($"--{level.Name} Power Ups Collected:");
                    foreach (PowerUp powerup in levelPowers) {
                        if (collectedPowerUps.Contains(powerup)) {
                            Console.WriteLine($"----{powerup.Name}: [X]");
                        } else {
                            Console.WriteLine($"----{powerup.Name}: [ ]");
                        }
                    }
                }
            }
        }
        }
    }

}
