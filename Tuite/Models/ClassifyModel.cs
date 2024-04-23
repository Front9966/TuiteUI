namespace Tuite.Models;
//板块信息
public class ClassifyInfo 
{
    public string Image { get; set; }
    public string Name { get; set; }
    //跳转页面内容
    public string ContentName { get; set; }
    //帖子回复数量
    public int ReplyNum { get; set; }
}
//管理员信息
public class AdminInfo 
{
    public string Image { get; set; }
    public int UserID { get; set; }
}
//社区通知
public class Community_Notifications 
{
    //帖子ID
    public int PostID { get; set; }
    //帖子标题
    public string Title { get; set; }
}