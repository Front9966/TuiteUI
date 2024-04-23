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
    //�󶨰����Ϣ
    public List<ClassifyInfo> classifyInfos_List
    {
        get => _classifyInfos_List;
        set
        {
            _classifyInfos_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("classifyInfos_List"));
        }
    }
    //�󶨰�����Ϣ
    public List<AdminInfo> adminInfo_List
    {
        get => _adminInfo_List;
        set
        {
            _adminInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("adminInfo_List"));
        }
    }
    //���֪ͨչʾ����
    public List<Community_Notifications> community_Notifications_List
    {
        get => _community_Notifications_List;
        set
        {
            _community_Notifications_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("community_Notifications_List"));
        }
    }
    //�ı���ǩ����
    public List<TextClassInfo> textLbael_List
    {
        get => _textLbael_List;
        set
        {
            _textLbael_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("textLbael_List"));
        }
    }
    //��������
    public List<PostInfo> postInfo_List
    {
        get => _postInfo_List;
        set
        {
            _postInfo_List = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
        }
    }
    //��ˢ��״̬
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
    //��ˢ���¼�
    public ICommand RefreshCommand => new Command(async () => await OnGetPostCommand());
    private async Task OnGetPostCommand()
    {
        IsRefreshing = true;
        await Task.Delay(3000);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            //���߳�UI����
            IsRefreshing = false;
        });
    }

    public ClassifyPageModel()
    {
        //�����ʼ��
        TextClassInfo_List();
        Community_Notifications_List();
        AdminInfo_List();
        PostInfo_List();
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    #region ��������ģ��
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
        _temp.Add(new Community_Notifications { PostID = 1, Title = "����һ������֪ͨ�����ӱ���" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "����һ������֪ͨ�����ӱ���" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "����һ������֪ͨ�����ӱ���" });
        _temp.Add(new Community_Notifications { PostID = 1, Title = "����һ������֪ͨ�����ӱ���" });
        community_Notifications_List = _temp;
    }
    public void TextClassInfo_List()
    {
        List<TextClassInfo> _temp = new List<TextClassInfo>();
        _temp.Add(new TextClassInfo { Title = "����1", IsChecked = true});
        _temp.Add(new TextClassInfo { Title = "����2", IsChecked = false});
        _temp.Add(new TextClassInfo { Title = "����3", IsChecked = false});
        _temp.Add(new TextClassInfo { Title = "����4", IsChecked = false});
        textLbael_List = _temp;
    }
    public void PostInfo_List()
    {
        List<PostInfo> _temp = new List<PostInfo>();
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        for (int i = 0; i < 3; i++)
        {
            _temp.Add(new PostInfo() { Title = $"�������ӵı���{i.ToString()}", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "��ע", Content = "����һ����ͨ������", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "����С��", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
    }
#endregion

}