namespace CIS_106_ASSIGNMENT_2.models {

    class Character {

        public string? Id {get; set;}
        public string? Name {get; set;}
        public int Health {get; set;}
        public List<PowerUp> PowerUps {get; set;} = []; // default value is empty collection, not null.

    }

}