// class Fish with Name, override Eat() and Walk method
// inherit from Animal and implement Pet

namespace Lab3 {
    class Fish : Animal, Pet {
        public string Name { get; set; }
        public Fish() : base(0) {
        }
        public Fish(string name) : base(0) {
            Name = name;
        }
        public override void Eat() {
            Console.WriteLine("Fish is eating");
        }
        public void Play() {
            Console.WriteLine("Fish is playing");
        }
        public override void Walk() {
            Console.WriteLine("Fish is swimming");
        }
        // toString() method
        public override string ToString() {
            return "Fish " + Name + " with " + Legs + " legs";
        }
    }
}