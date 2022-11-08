public class Book {
    public String Name { get; }
    public Author Author { get; }
    public double Price { get; set; }
    public int QtyInStock { get; set; }

    public Book(string name, Author author, double price, int qtyInStock) {
        Name = name;
        Author = author;
        Price = price;
        QtyInStock = qtyInStock;
    }

    public Book(string name, Author author, double price) {
        Name = name;
        Author = author;
        Price = price;
        QtyInStock = 0;
    }

    public override string ToString()
    {
        return "Book[Name= " + this.Name + 
        ", Author= " + this.Author + 
        ", Price= " + this.Price + 
        ", QtyInStock= " + this.QtyInStock + "]";
    }
}