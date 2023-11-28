using HotChocolateDemo.Entities;

namespace HotChocolateDemo.Queries;

public class QueryBooks
{
  public Book GetBook() =>
      new Book
      {
        Title = "C# in depth.",
        Author = new Author
        {
          Name = "Jon Skeet"
        }
      };
}
