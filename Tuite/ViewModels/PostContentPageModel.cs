using System.ComponentModel;
namespace Tuite.ViewModels;
public class PostContentPageModel : INotifyPropertyChanged
{
	public PostInfo _postinfo { get; set; }
    public List<CommentModel> _commentinfo { get; set; }
	//帖子信息
    public PostInfo postinfo
	{
		get => _postinfo;
		set 
		{
			_postinfo = value;
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("postinfo"));
		}
    }
    //评论信息
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
        var _temp = new PostInfo() { Title = $"这是帖子的标题", LookNum = 144, GoodNum = 10, ShouNum = 22, Status = "关注", Content = "这是一个普通的帖子", HeadImage = "test.jpg", Image = image, Byid = 1, Name = "酷酷的小贤", PostID = 2, LastUpdated = new DateTime() };
        postinfo = _temp;
    }
    private void test_commentinfo() 
    {
        List<CommentModel> _temp = new List<CommentModel>();
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        _temp.Add(new CommentModel() { Content = "我是一条咸鱼", Id = 10001, PostID = 1001, Time = new DateTime(), UserId = 1001, UserImage = "test2.jpg", UserName = "酷酷的小贤佬" });
        commentinfo = _temp;
    }
    #endregion
}