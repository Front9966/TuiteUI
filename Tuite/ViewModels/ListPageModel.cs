using System.ComponentModel;
namespace Tuite.ViewModels;
public class ListPageModel:INotifyPropertyChanged
{
    public List<PostInfo> _postInfo_List { get; set; }
    public List<UserListInfo> _userlistinfo_List { get; set; }
    private List<CommentInfo> _commentInfos { get; set; }
    //评论内容
    public List<CommentInfo> CommentInfo_List
    {
        get => _commentInfos;
        set
        {
            _commentInfos = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
        }
    }
    //帖子内容
    public List<PostInfo> postInfo_List
    {
        get => _postInfo_List;
        set
        {
            _postInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
        }
    }
    //用户列表
    public List<UserListInfo> UserListinfo_List
    {
        get => _userlistinfo_List;
        set
        {
            _userlistinfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserListinfo_List"));
        }
    }
    public ListPageModel(string value) 
    {
        if (value == "收藏")//帖子:我的收藏
        {
            PostInfo_List();
        }
        else if (value == "浏览") //帖子:历史浏览
        {
            PostInfo_List();
        }
        else if (value == "我的") //帖子:我的帖子
        {
            PostInfo_List();
        }
        else if (value == "关注")//用户:关注用户
        {
            UserListinfo();
        }
        else if (value == "粉丝")//用户:粉丝用户
        {
            UserListinfo();
        } 
        else if (value == "评论") //评论：我的评论
        {
            CommentInfo_Test();
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    #region
    public void PostInfo_List() 
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        for (int i = 0; i < 10; i++)
        {
            _temp.Add(new PostInfo() { Title = $"这是帖子的标题{i.ToString()}", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "关注", Content = "这是一个普通的帖子", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "酷酷的小贤", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
    }
    public void UserListinfo()
    {
        List<UserListInfo> _temp = new List<UserListInfo>();
        for (int i = 0; i < 20; i++)
        {
            _temp.Add(new UserListInfo() { UserID = 1001, Status = "关注", UserImge = "test2.jpg", UserName = "酷酷的小贤佬", UserSign = "这是一个个性的签名" });
        }
        UserListinfo_List = _temp;
    }
    public void CommentInfo_Test()
    {
        List<CommentInfo> _temp = new List<CommentInfo>();
        for (int i = 0; i < 10; i++)
        {
            _temp.Add(new CommentInfo() { ID = 1001, userName = "酷酷的小贤佬", Image = "test2.jpg", Title = "这是一个帖子的标题", Message = "我是回复内容", PostID = 1001, Time = new DateTime(), userID = 1001 });
        }
        CommentInfo_List = _temp;
    }
    #endregion
}
