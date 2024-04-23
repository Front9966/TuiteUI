namespace Tuite.Models;
//广告类
public class AdClassInfo
{
    public string Image { get; set; }
    public string URL { get; set; }
}
//快捷模板类
public class Classify 
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string PageUrl { get; set; }
}
//首页标签分类
public class TextClassInfo 
{
    public string Title { get; set; }
    public bool IsChecked { get; set; }
}
//帖子类
public class PostInfo 
{
    //帖子标题
    public string Title { get; set; }
    //作者昵称
    public string Name { get; set; }
    //帖子内容
    public string Content { get; set; }
    //帖子图片
    public List<string> Image { get; set; }
    //作者头像
    public string HeadImage { get; set; }
    //作者id
    public int Byid { get; set; }
    //帖子ID
    public int PostID { get; set; }
    //最后更新时间
    public DateTime LastUpdated { get; set; }
    //点赞数量
    public int GoodNum { get; set; }
    //收藏数量
    public int ShouNum { get; set; }
    //关注状态
    public string Status { get; set; }
    //浏览量
    public int LookNum { get; set; }
}