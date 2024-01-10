namespace CIS_106_ASSIGNMENT_2.models {

    class Level {

        public string? Id {get; set;}
        public string? Name {get; set;}
        public int TimeLimit {get; set;}
        public List<PowerUp> PowerUps {get; set;} = []; // default value is empty collection, not null.

    }

}