namespace Tuite.Views;
public partial class UserPage : ContentPage
{
	private UserPagedgdModel model;
    private PostInfoViewDome postInfoViewDome;
    private CommentViewDome commentViewDome;
    public UserPage(int UserID)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        Task.Run(() => {
            model = new UserPagedgdModel(1001);
            this.BindingContext = model;
            postInfoViewDome = new PostInfoViewDome();
            commentViewDome = new CommentViewDome();
            postInfoViewDome.IsVisible = false;
            commentViewDome.IsVisible = false;
            ji = UserInfoViews.Height;
            VerView.Add(postInfoViewDome);
            VerView.Add(commentViewDome);

            //ģ��View�¼���
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            commentViewDome.Event_CommentClicked += Event_CommentClicked;

            textClassifyButton.textClassify_Event += TextClassifyClicked;
        });
    }


    //�����ʼ�����¼�
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
        ScrollView1.HeightRequest = this.Height - textClassifyButton.Height - 20;
    }
    //��ǩ������
    public double ji;
    private void TextClassifyClicked(TextClassInfo info)
    {
        if (info.Title == "��ϸ����")
        {
            postInfoViewDome.IsVisible = false;
            commentViewDome.IsVisible = false;
            UserInfoViews.IsVisible = true;
            ScrollView1.Content.HeightRequest = ji;
        }
        else if (info.Title == "��������")
        {
            UserInfoViews.IsVisible = false;
            commentViewDome.IsVisible = false;
            postInfoViewDome.IsVisible = true;
            ScrollView1.Content.HeightRequest = postInfoViewDome.Height;
        } 
        else if (info.Title == "�ظ�����") 
        {
            UserInfoViews.IsVisible = false;
            postInfoViewDome.IsVisible = false;
            commentViewDome.IsVisible = true;
            ScrollView1.Content.HeightRequest = commentViewDome.Height;
        }
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
    //���۱�����
    private void Event_CommentClicked(CommentInfo info)
    {

    }
}