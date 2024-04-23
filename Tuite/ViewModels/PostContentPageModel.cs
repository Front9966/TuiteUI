using System.ComponentModel;
namespace Tuite.ViewModels;
public class PostContentPageModel : INotifyPropertyChanged
{
	public PostInfo _postinfo { get; set; }
    public List<CommentModel> _commentinfo { get; set; }
	//������Ϣ
    public PostInfo postinfo
	{
		get => _postinfo;
		set 
		{
			_postinfo = value;
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("postinfo"));
		}
    }
    //������Ϣ
    public List<CommentModel> commentinfo
    {
        get => _commentinfo;
        set
        {
            _commentinfo = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("commentinfo"));
        }
    }
    public PostContentPageModel()
    {
        test_postinfo();
        test_commentinfo();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    #region
    private void test_postinfo()
    {
        string[] a = { "test2.jpg", "test2.jpg" };
        List<string> image = a.ToList();
        var _temp = new PostInfo() { Title = $"�������ӵı���", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "��ע", Content = "����һ����ͨ������", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "����С��", PostID = 2, LastUpdated = new DateTime() };
        postinfo = _temp;
    }
    private void test_commentinfo() 
    {
        List<CommentModel> _temp = new List<CommentModel>();
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        _temp.Add(new CommentModel() { Content = "����һ������", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "����С����" });
        commentinfo = _temp;
    }
    #endregion
}