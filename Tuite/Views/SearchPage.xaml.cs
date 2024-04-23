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
            //�����¼�
            textClassifyButton.textClassify_Event += TextClassifyClicked;
            //�������鲼��
            postInfoViewDome = new PostInfoViewDome();
            userListViewDome = new UserListViewDome();
            userListViewDome.IsVisible = false;
            VerticalStackLayout1.Add(postInfoViewDome);
            VerticalStackLayout1.Add(userListViewDome);
            //��ģ���¼�
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            userListViewDome.Event_UserClicked += Event_UserClicked;
            userListViewDome.Event_UserButtonClicked += Event_UserButtonClicked;
            //��ʼ��
            Info = new TextClassInfo() { IsChecked = true, Title = "����" };
        });
    }
    //��������ȷ����
    private async void Entry_Completed(object sender, EventArgs e)
    {
        entry.HideKeyboardAsync(CancellationToken.None);
        var a = new LoadView();
        this.ShowPopup(a);
        await Task.Run(async () => {
            //��ʼ��ʾ��������
            searchPageModel.PostInfo_List();
            searchPageModel.UserListinfo();
            await Task.Delay(2000);
        });
        //���¸߶�
        await MainThread.InvokeOnMainThreadAsync(() => {
            ScrollView1.Content.HeightRequest = Info.Title == "�û�" ? userListViewDome.Height : Info.Title == "����" ? postInfoViewDome.Height : 0;
        });
        a.Close();
    }
    //�����ǩ�����¼�
    TextClassInfo Info;
    private void TextClassifyClicked(TextClassInfo info) 
    {
        Info = info;
        if (info.Title == "�û�")
        {
            postInfoViewDome.IsVisible = false;
            userListViewDome.IsVisible = true;
        }
        else if(info.Title == "����")
        {
            postInfoViewDome.IsVisible = true;
            userListViewDome.IsVisible = false;
        }
        ScrollView1.Content.HeightRequest = Info.Title == "�û�" ? userListViewDome.Height : Info.Title == "����" ? postInfoViewDome.Height : 0;
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
    //������¼������
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Frame a = (Frame)sender;
        string b = (string)a.BindingContext;
        //bΪ��������

    }
}