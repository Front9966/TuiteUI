using System.ComponentModel;
using System.Windows.Input;
namespace Tuite.ViewModels;
public class FirstPageModel : INotifyPropertyChanged
{
    private List<AdClassInfo> _ad_List { get; set; }
    private List<Classify> _classify_List { get; set; }
    private List<TextClassInfo> _textLbael_List { get; set; }
    private List<PostInfo> _postInfo_List { get; set; }
    //广告轮播图绑定数据
    public List<AdClassInfo> ad_List {
        get => _ad_List;
        set { 
            _ad_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ad_List"));
        }
    }
    //分类快捷模块
    public List<Classify> classify_List
    {
        get => _classify_List;
        set
        {
            _classify_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("classify_List"));
        }
    }
    //热门板块分类
    public List<TextClassInfo> textLbael_List
    {
        get => _textLbael_List;
        set
        {
            _textLbael_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("textLbael_List"));
        }
    }
    //帖子信息绑定
    public List<PostInfo> postInfo_List
    {
        get => _postInfo_List;
        set
        {
            _postInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
        }
    }
    //绑定刷新事件
    private bool _IsRefreshing;
    public bool IsRefreshing 
    {
        get => _IsRefreshing;
        set {
            _IsRefreshing = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
        }
    }
    //绑定刷新事件
    public ICommand RefreshCommand => new Command(async () => await OnGetPostCommand());
    private async Task OnGetPostCommand()
    {
        IsRefreshing = true;
        await Task.Delay(2000);
        PostInfo_List();
        IsRefreshing = false;
    }

    //初始化
    public FirstPageModel()
    {
        Ad_List();
        Classify_List();
        TextLbael_List();
        PostInfo_List();
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    #region 测试函数
    //测试广告轮播图生成函数
    private void Ad_List()
    {
        List<AdClassInfo> _temp = new List<AdClassInfo>();
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        _temp.Add(new AdClassInfo() { Image = "test.jpg", URL = "http://www.baidu.com" });
        ad_List = _temp;
    }
    //测试分类快捷模块
    private void Classify_List()
    {
        List<Classify> _temp = new List<Classify>();
        for (int i = 0; i < 3; i++)
        {
            _temp.Add(new Classify() { Image = "test2.jpg", Title = "在线客服", PageUrl = "在线客服" });
        }
        classify_List = _temp;
    }
    //测试文本分类标签
    private void TextLbael_List()
    {
        List<TextClassInfo> _temp = new List<TextClassInfo>();
        _temp.Add(new TextClassInfo { Title = "测试1", IsChecked = true });
        _temp.Add(new TextClassInfo { Title = "测试2", IsChecked = false });
        _temp.Add(new TextClassInfo { Title = "测试3", IsChecked = false });
        _temp.Add(new TextClassInfo { Title = "测试4", IsChecked = false });
        textLbael_List = _temp;
    }
    public void PostInfo_List()
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test.jpg" };
        List<string> image = a.ToList();
        for(int i = 0; i<3; i++) 
        {
            _temp.Add(new PostInfo() { Title = $"这是帖子的标题{i.ToString()}", LookNum = 144 , GoodNum = 10, ShouNum = 22, Status = "关注" , Content = "这是一个普通的帖子", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "酷酷的小贤", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
    }
    #endregion
}
