// class Cat inherits from Animal and implements Pet
// override Eat() method
// Name

namespace Lab3 {
    class Cat : Animal, Pet {
        public string Name { get; set; }
        public Cat() : base(4) {
            Name = "Cat";
        }
        public Cat(string name) : base(4) {
            Name = name;
        }
        public override void Eat() {
            Console.WriteLine("Cat is eating");
        }
        public void Play() {
            Console.WriteLine("Cat is playing");
        }

        // toString() method
        public override string ToString() {
            return "Cat " + Name + " with " + Legs + " legs";
        }
    }
}