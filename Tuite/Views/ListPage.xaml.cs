namespace Tuite.Views;
public partial class ListPage : ContentPage
{
	private ListPageModel model;
    public ListPage(string from,string msg,string title)
    {
        InitializeComponent();
        Task.Run(() =>
        {
            if (from == "����")
            {
                var a = new  PostInfoViewDome();
                VerView.Add(a);
                a.Event_HeadImageClicked += Event_PostHeadImageClicked;
                a.Event_Load += Event_PostLoad;
                a.Event_PostClicked += Event_PostClicked;
                model = new ListPageModel(msg);
                this.BindingContext = model;
            }
            else if (from == "�û�") 
            {
                var a = new UserListViewDome();
                VerView.Add(a);
                a.Event_UserButtonClicked += Event_UserButtonClicked;
                a.Event_UserClicked += Event_UserClicked;
                model = new ListPageModel(msg);
                this.BindingContext = model;
            }
            else if (from == "����")
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

    //����ͷ�񱻵���
    private void Event_PostHeadImageClicked(PostInfo info)
    {

    }
    //���Ӽ��ظ���
    private void Event_PostLoad()
    {

    }
    //���ӱ�����
    private void Event_PostClicked(PostInfo info)
    {

    }

    //�û�������
    private void Event_UserClicked(UserListInfo info)
    {

    }
    //�û���ť������
    private void Event_UserButtonClicked(UserListInfo info)
    {

    }

    //���۱�����
    private void Event_CommentClicked(CommentInfo info)
    {

    }
}