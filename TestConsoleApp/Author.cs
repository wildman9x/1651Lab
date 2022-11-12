public class Author {
    public String Name { get; }
    public String Email {get; set;}
    public char Gender {get; set;}

    // default constructor
    public Author() {
        Name = "unknown";
        Email = "unknown";
        Gender = 'o';
    }

    public Author(String name, String email, char gender) {
        // if gender not 'f' or 'm' or 'o' throw exception
        if(gender == 'm' || gender == 'f' || gender == 'o') {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        } else {
            Console.WriteLine("Invalid gender.");
        }
    }

    public override string ToString()
    {
        return "Author[Name= " + this.Name + 
        ", Email= " + this.Email + 
        ", Gender= " + this.Gender + "]";
    }
}