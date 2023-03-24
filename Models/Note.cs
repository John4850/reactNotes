using Microsoft.AspNetCore.Identity;

namespace reactNotes.Models
{
  public class Note
  {
    public int Id { get; set; }
    public string Title { get; set; } = "New Note";
    public string Description { get; set; } = "content";
  }
}