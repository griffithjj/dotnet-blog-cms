using System.ComponentModel.DataAnnotations;

namespace BlogCms.Models;

public class Post(string title = "", string summary = "", string content = "")
{
    public int Id { get; set; }
    public string Title { get; set; } = title;
    public string Summary { get; set; } = summary;
    public string Content { get; set; } = content;
    [DataType(DataType.Date)]
    public DateTime Created { get; set; } = DateTime.Now;
    [DataType(DataType.Date)]
    public DateTime LastUpdated { get; set; } = DateTime.Now;
}
