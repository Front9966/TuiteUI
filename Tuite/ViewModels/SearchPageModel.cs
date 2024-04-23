using System.ComponentModel;
namespace Tuite.ViewModels;
public class SearchPageModel : INotifyPropertyChanged
{
    public List<TextClassInfo> _textLbael_List { get; set; }
    public List<PostInfo> _postInfo_List { get; set; }
    public List<UserListInfo> _userlistinfo_List { get; set; }
    public List<string> _Bw { get; set; }
    //浏览记录
    public List<string> Bw
    {
        get => _Bw;
        set
        {
            _Bw = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bw"));
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
    //帖子数据绑定
    public List<PostInfo> postInfo_List
    {
        get => _postInfo_List;
        set
        {
            _postInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
        }
    }
    public SearchPageModel()
    {
        Task.Run(() => {
            List<TextClassInfo> _temp = new List<TextClassInfo>();
            _temp.Add(new TextClassInfo(){ IsChecked = true, Title = "帖子" });
            _temp.Add(new TextClassInfo(){ IsChecked = false, Title = "用户" });
            textLbael_List = _temp;
            BwLit();
        });
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    #region
    public void PostInfo_List()
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        for (int i = 0; i < 20; i++)
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
    public void BwLit() 
    {
        List<string> _temp = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            _temp.Add($"记录{i.ToString()}");
        }
        Bw = _temp;
    }
    #endregion
}
