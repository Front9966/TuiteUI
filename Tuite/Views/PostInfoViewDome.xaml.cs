namespace Tuite.Views;
public partial class PostInfoViewDome : ContentView
{
	public delegate void HeadImageClickedType(PostInfo postInfo);
	public delegate void LoadType();
	public event HeadImageClickedType Event_HeadImageClicked;
	public event LoadType Event_Load;
	public event HeadImageClickedType Event_PostClicked;
    public PostInfoViewDome()
	{
		InitializeComponent();
	}
	//头像被单击
	public void Tapped(object sender,TappedEventArgs e) 
	{
        Grid a = (Grid)sender;
		PostInfo b = (PostInfo)a.BindingContext;
		Event_HeadImageClicked(b);
    }
	//显示加载更多
    private void CollectionView_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		Event_Load();
    }
	//帖子被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        View a = (View)sender;
        PostInfo b = (PostInfo)a.BindingContext;
        Event_PostClicked(b);
    }
    //帖子的图片内容被单击
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Image a = sender as Image;
        var b = a.BindingContext;
        Event_PostClicked(b as PostInfo);
    }
}