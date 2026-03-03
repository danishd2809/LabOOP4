using System;

public class Member
{
    private int memberId;
    private string name;

    public int MemberId
    {
        get { return memberId; }
        set { memberId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Member(int memberId, string name)
    {
        this.memberId = memberId;
        this.name = name;
    }
    public void DisplayMember()
    {
        Console.WriteLine($"Member ID: {memberId}, Name: {name}");
    }
}

public class Book
{
    private string title;
    private string author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Book: {title}, Author: {author}");
    }
}


public class Library
{
    private List<Member> members = new List<Member>();
    private List<Book> books = new List<Book>();

    public void AddMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' added successfully!");
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added successfully!");
    }

    public void ShowMembers()
    {
        Console.WriteLine("\n--- Library Members ---");
        foreach (Member m in members)
        {
            m.DisplayMember();
        }
    }

    public void ShowBooks()
    {
        Console.WriteLine("\n--- Library Books ---");
        foreach (Book b in books)
        {
            b.DisplayBook();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        
        Member m1 = new Member(101, "Danish");
        Member m2 = new Member(102, "Amier");

        
        Book b1 = new Book("C# Programming", "John Smith");
        Book b2 = new Book("Object-Oriented Design", "Jane Doe");

        
        library.AddMember(m1);
        library.AddMember(m2);

        library.AddBook(b1);
        library.AddBook(b2);

        
        library.ShowMembers();
        library.ShowBooks();

        Console.ReadLine();
    }
}
