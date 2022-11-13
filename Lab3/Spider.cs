// class Spider inherits from Animal
// override Eat() method

namespace Lab3 {
    class Spider : Animal {
        public Spider() : base(8) {
        }
        public override void Eat() {
            Console.WriteLine("Spider is eating");
        }
    }
}