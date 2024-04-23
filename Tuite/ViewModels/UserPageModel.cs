using System.ComponentModel;
namespace Tuite.ViewModels;
public class UserPagedgdModel : INotifyPropertyChanged
{
    private List<TextClassInfo> _textLbael_List { get; set; }
    private UserInfo _userInfo { get; set; }
    private List<PostInfo> _postInfo_List { get; set; }
    private List<CommentInfo> _commentInfos { get; set; }
    //评论内容
    public List<CommentInfo> CommentInfo_List {
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
    //用户信息
    public UserInfo UserInfos {
        get => _userInfo;
        set 
        {
            _userInfo = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserInfos"));
        }
    }
    //文本标签分类
    public List<TextClassInfo> textLbael_List
    {
        get => _textLbael_List;
        set
        {
            _textLbael_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("textLbael_List"));
        }
    }

    //初始化
	public UserPagedgdModel(int userID)
    {
        Task.Run(() =>
        {
            TextLbael_List();
            PostInfo_List();
            CommentInfo_Test();
            InfoInit(userID);
        });
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    #region
    //测试文本分类标签
    private void TextLbael_List()
    {
        List<TextClassInfo> _temp = new List<TextClassInfo>();
        _temp.Add(new TextClassInfo { Title = "详细资料", IsChecked = true });
        _temp.Add(new TextClassInfo { Title = "发布帖子", IsChecked = false });
        _temp.Add(new TextClassInfo { Title = "回复内容", IsChecked = false });
        textLbael_List = _temp;
    }
    public void InfoInit(int userID) 
	{
        var _temp = new UserInfo()
        {
            UserName = "酷酷的小贤佬",
            UserEmail = "7603871@qq.com",
            UserSign = "这是一个非常个性的个性签名......",
            UserGender = "男",
            UserFenSi = 22,
            UserGuanZhu = 30,
            UserGrade = 2,
            UserImage = "test2.jpg",
            UserBack = "test.jpg",
            UserZhuCeTime = new DateTime(),
            UserAge = 18,
            UserID = userID
        };
        UserInfos = _temp;
    }
    public void PostInfo_List()
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        for (int i = 0; i < 5; i++)
        {
            _temp.Add(new PostInfo() { Title = $"这是帖子的标题{i.ToString()}", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "关注", Content = "这是一个普通的帖子", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "酷酷的小贤", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
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