using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;
namespace Tuite.Views;
public partial class SearchPage : ContentPage
{
    private SearchPageModel searchPageModel;
    private PostInfoViewDome postInfoViewDome;
    private UserListViewDome userListViewDome;
    public SearchPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        Task.Run(() => {
            searchPageModel = new SearchPageModel();
            this.BindingContext = searchPageModel;
            //订阅事件
            textClassifyButton.textClassify_Event += TextClassifyClicked;
            //插入两块布局
            postInfoViewDome = new PostInfoViewDome();
            userListViewDome = new UserListViewDome();
            userListViewDome.IsVisible = false;
            VerticalStackLayout1.Add(postInfoViewDome);
            VerticalStackLayout1.Add(userListViewDome);
            //绑定模板事件
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            userListViewDome.Event_UserClicked += Event_UserClicked;
            userListViewDome.Event_UserButtonClicked += Event_UserButtonClicked;
            //初始化
            Info = new TextClassInfo() { IsChecked = true, Title = "帖子" };
        });
    }
    //搜索框按下确定键
    private async void Entry_Completed(object sender, EventArgs e)
    {
        entry.HideKeyboardAsync(CancellationToken.None);
        var a = new LoadView();
        this.ShowPopup(a);
        await Task.Run(async () => {
            //开始显示搜索内容
            searchPageModel.PostInfo_List();
            searchPageModel.UserListinfo();
            await Task.Delay(2000);
        });
        //更新高度
        await MainThread.InvokeOnMainThreadAsync(() => {
            ScrollView1.Content.HeightRequest = Info.Title == "用户" ? userListViewDome.Height : Info.Title == "帖子" ? postInfoViewDome.Height : 0;
        });
        a.Close();
    }
    //分类标签按下事件
    TextClassInfo Info;
    private void TextClassifyClicked(TextClassInfo info) 
    {
        Info = info;
        if (info.Title == "用户")
        {
            postInfoViewDome.IsVisible = false;
            userListViewDome.IsVisible = true;
        }
        else if(info.Title == "帖子")
        {
            postInfoViewDome.IsVisible = true;
            userListViewDome.IsVisible = false;
        }
        ScrollView1.Content.HeightRequest = Info.Title == "用户" ? userListViewDome.Height : Info.Title == "帖子" ? postInfoViewDome.Height : 0;
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
    //搜索记录被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Frame a = (Frame)sender;
        string b = (string)a.BindingContext;
        //b为搜索内容

    }
}