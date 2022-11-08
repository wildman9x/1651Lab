public class Person {
    public String Address { get; set; }
    public String Name {get;}
    public Person(String name, String address) {
        Name = name;
        Address = address;
    }
    public override string ToString()
    {
        return string.Format("Name: {0}, Address: {1}", Name, Address);
    }
}