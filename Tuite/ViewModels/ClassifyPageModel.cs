using System.ComponentModel;
using System.Windows.Input;
namespace Tuite.ViewModels;
public class ClassifyPageModel : INotifyPropertyChanged
{
    public List<ClassifyInfo> _classifyInfos_List;
    public List<AdminInfo> _adminInfo_List { get; set; }
    public List<Community_Notifications> _community_Notifications_List { get; set; }
    public List<TextClassInfo> _textLbael_List { get; set; }
    public List<PostInfo> _postInfo_List { get; set; }
    //绑定板块信息
    public List<ClassifyInfo> classifyInfos_List
    {
        get => _classifyInfos_List;
        set
        {
            _classifyInfos_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("classifyInfos_List"));
        }
    }
    //绑定版主信息
    public List<AdminInfo> adminInfo_List
    {
        get => _adminInfo_List;
        set
        {
            _adminInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("adminInfo_List"));
        }
    }
    //板块通知展示帖子
    public List<Community_Notifications> community_Notifications_List
    {
        get => _community_Notifications_List;
        set
        {
            _community_Notifications_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("community_Notifications_List"));
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
    //绑定刷新状态
    private bool _IsRefreshing;
    public bool IsRefreshing
    {
        get => _IsRefreshing;
        set
        {
            _IsRefreshing = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
        }
    }
    //绑定刷新事件
    public ICommand RefreshCommand => new Command(async () => await OnGetPostCommand());
    private async Task OnGetPostCommand()
    {
        IsRefreshing = true;
        await Task.Delay(3000);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            //主线程UI更新
            IsRefreshing = false;
        });
    }

    public ClassifyPageModel()
    {
        //对象初始化
        TextClassInfo_List();
        Community_Notifications_List();
        AdminInfo_List();
        PostInfo_List();
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    #region 测试数据模板
    public void AdminInfo_List() 
	{
        List<AdminInfo> _temp = new List<AdminInfo>();
        _temp.Add(new AdminInfo() { Image = "test.jpg", UserID = 11 });
        _temp.Add(new AdminInfo() { Image = "test.jpg", UserID = 11 });
        adminInfo_List = _temp;
    }
    public void Community_Notifications_List() 
	{
        List<Community_Notifications> _temp = new List<Community_Notifications>();
        _temp.Add(new Community_Notifications { PostID = 1, Title = "这是一个负责通知的帖子标题" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "这是一个负责通知的帖子标题" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "这是一个负责通知的帖子标题" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "这是一个负责通知的帖子标题" });
        community_Notifications_List = _temp;
    }
    public void TextClassInfo_List()
    {
        List<TextClassInfo> _temp = new List<TextClassInfo>();
        _temp.Add(new TextClassInfo { Title = "测试1", IsChecked = true});
        _temp.Add(new TextClassInfo { Title = "测试2", IsChecked = false});
        _temp.Add(new TextClassInfo { Title = "测试3", IsChecked = false});
        _temp.Add(new TextClassInfo { Title = "测试4", IsChecked = false});
        textLbael_List = _temp;
    }
    public void PostInfo_List()
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        for (int i = 0; i < 3; i++)
        {
            _temp.Add(new PostInfo() { Title = $"这是帖子的标题{i.ToString()}", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "关注", Content = "这是一个普通的帖子", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "酷酷的小贤", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
    }
#endregion

}