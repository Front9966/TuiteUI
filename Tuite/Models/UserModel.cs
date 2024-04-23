namespace Tuite.Models;
//用户信息
public class UserInfo
{
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string UserSign { get; set; }
    public string UserGender { get; set; }
    public int UserFenSi { get; set; }
    public int UserGuanZhu { get; set; }
    public int UserGrade { get; set; }
    public string UserImage { get; set; }
    public string UserBack { get; set; }
    public int UserID { get; set; }
    public int UserAge { get; set; }
    public DateTime UserZhuCeTime { get; set; }
}
//评论信息
public class CommentInfo
{
    public int ID { get; set; }
    public int userID { get; set; }
    public string userName { get; set; }
    public string Image { get; set; }
    public string Message { get; set; }
    public string Title { get; set; }
    public DateTime Time { get; set; }
    public int PostID { get; set; }
}