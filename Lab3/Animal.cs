// abstract class Animal with readonly int Legs
// method Walk()
// abstract method Eat()

namespace Lab3 {
    abstract class Animal {
        public readonly int Legs;
        public Animal(int legs) {
            Legs = legs;
        }
        public virtual void Walk() {
            Console.WriteLine("Animal is walking on " + Legs + " legs");
        }
        public abstract void Eat();
        // toString() method
        public override string ToString() {
            return "Animal with " + Legs + " legs";
        }
    }
}