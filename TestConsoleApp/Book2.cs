namespace TestConsoleApp{
// class book that accepts multiple authors
public class Book2 {
    public String Name { get; }
    public Author[] Authors { get; }
    public double Price { get; set; }
    public int QtyInStock { get; set; }

    public Book2(string name, Author[] authors, double price, int qtyInStock) {
        Name = name;
        Authors = authors;
        Price = price;
        QtyInStock = qtyInStock;
    }

    public Book2(string name, Author[] authors, double price) {
        Name = name;
        Authors = authors;
        Price = price;
        QtyInStock = 0;
    }

    // get author names
    public String GetAuthorNames() {
        String authorNames = "";
        foreach(Author author in Authors) {
            if(authorNames == "") {
                authorNames += author.Name;
            } else {
                authorNames += ", " + author.Name;
            }
        }
        return authorNames;
    }

    public override string ToString()
    {
        String result = "Book[Name= " + this.Name +
        ", Authors= ";
        foreach(Author author in Authors) {
            result += author + ", ";
        }
        result += "Price= " + this.Price +
        ", QtyInStock= " + this.QtyInStock + "]";
        return result;
    }
}}