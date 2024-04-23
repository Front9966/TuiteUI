using System.ComponentModel;
namespace Tuite.ViewModels;
public class UserPagedgdModel : INotifyPropertyChanged
{
    private List<TextClassInfo> _textLbael_List { get; set; }
    private UserInfo _userInfo { get; set; }
    private List<PostInfo> _postInfo_List { get; set; }
    private List<CommentInfo> _commentInfos { get; set; }
    //��������
    public List<CommentInfo> CommentInfo_List {
        get => _commentInfos;
        set 
        {
            _commentInfos = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("postInfo_List"));
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
    //�û���Ϣ
    public UserInfo UserInfos {
        get => _userInfo;
        set 
        {
            _userInfo = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserInfos"));
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

    //��ʼ��
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
    //�����ı������ǩ
    private void TextLbael_List()
    {
        List<TextClassInfo> _temp = new List<TextClassInfo>();
        _temp.Add(new TextClassInfo { Title = "��ϸ����", IsChecked = true });
        _temp.Add(new TextClassInfo { Title = "��������", IsChecked = false });
        _temp.Add(new TextClassInfo { Title = "�ظ�����", IsChecked = false });
        textLbael_List = _temp;
    }
    public void InfoInit(int userID) 
	{
        var _temp = new UserInfo()
        {
            UserName = "����С����",
            UserEmail = "7603871@qq.com",
            UserSign = "����һ���ǳ����Եĸ���ǩ��......",
            UserGender = "��",
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
            _temp.Add(new PostInfo() { Title = $"�������ӵı���{i.ToString()}", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "��ע", Content = "����һ����ͨ������", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "����С��", PostID = 2, LastUpdated = new DateTime() });
        }
        postInfo_List = _temp;
    }
    public void CommentInfo_Test()
    {
        List<CommentInfo> _temp = new List<CommentInfo>();
        for (int i = 0; i < 10; i++)
        {
            _temp.Add(new CommentInfo() { ID = 1001, userName = "����С����", Image = "test2.jpg", Title = "����һ�����ӵı���", Message = "���ǻظ�����", PostID = 1001, Time = new DateTime(), userID = 1001 });
        }
        CommentInfo_List = _temp;
    }
    #endregion
}