namespace HotChocolateDemo.Entities;

public record Book
{
  public string? Title { get; set; }

  public Author? Author { get; set; }
}
