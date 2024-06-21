namespace Blogzor.Models;

public class Article
{
    public Guid Id { get; set; }
    
    public required string Title { get; set; } = null!;
    
    public required string Content { get; set; } = null!;

    public string Body { get; set; } = null!;
    
    public DateTime? PublishedAt { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}