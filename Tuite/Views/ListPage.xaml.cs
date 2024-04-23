namespace Tuite.Views;
public partial class ListPage : ContentPage
{
	private ListPageModel model;
    public ListPage(string from,string msg,string title)
    {
        InitializeComponent();
        Task.Run(() =>
        {
            if (from == "帖子")
            {
                var a = new  PostInfoViewDome();
                VerView.Add(a);
                a.Event_HeadImageClicked += Event_PostHeadImageClicked;
                a.Event_Load += Event_PostLoad;
                a.Event_PostClicked += Event_PostClicked;
                model = new ListPageModel(msg);
                this.BindingContext = model;
            }
            else if (from == "用户") 
            {
                var a = new UserListViewDome();
                VerView.Add(a);
                a.Event_UserButtonClicked += Event_UserButtonClicked;
                a.Event_UserClicked += Event_UserClicked;
                model = new ListPageModel(msg);
                this.BindingContext = model;
            }
            else if (from == "评论")
            {
                var a = new CommentViewDome();
                VerView.Add(a);
                a.Event_CommentClicked += Event_CommentClicked;
                model = new ListPageModel(msg);
                this.BindingContext = model;
            }
        });
        MainThread.InvokeOnMainThreadAsync(() => {
            ScrollView1.Content.HeightRequest = VerView.Height;
        });
        this.Title = title;
    }

    //帖子头像被单击
    private void Event_PostHeadImageClicked(PostInfo info)
    {

    }
    //帖子加载更多
    private void Event_PostLoad()
    {

    }
    //帖子被单击
    private void Event_PostClicked(PostInfo info)
    {

    }

    //用户被单击
    private void Event_UserClicked(UserListInfo info)
    {

    }
    //用户按钮被单击
    private void Event_UserButtonClicked(UserListInfo info)
    {

    }

    //评论被单击
    private void Event_CommentClicked(CommentInfo info)
    {

    }
}