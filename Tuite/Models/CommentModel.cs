namespace Tuite.Models;
public class CommentModel
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserImage { get; set; }
    public DateTime Time { get; set; }
    public int PostID { get; set; }
}