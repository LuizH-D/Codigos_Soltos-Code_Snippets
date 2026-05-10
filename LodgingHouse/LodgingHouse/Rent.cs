namespace LodgingHouse {
    internal class Rent {
        public string Name { get; private set; }
        public string Email { get; private set; }


        // Contructors
        public Rent(string name,string email) {
            Name = name;
            Email = email;
        }

        // Methods
        public override string ToString() {
            return $"{Name}, {Email}";
        }
    }
}
