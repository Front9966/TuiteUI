using CommunityToolkit.Maui.Views;
namespace Tuite.Views;
public partial class ClassifyPage : ContentPage
{
	//绑定模块
	public ClassifyPageModel classifyModels { get; set; }
	//板块展开状态
	public bool classify_Status { get; set; }
	//构造初始化函数
	public ClassifyPage()
	{
		InitializeComponent();
        Task.Run(() =>
        {
            classifyModels = new ClassifyPageModel();
            this.BindingContext = classifyModels;
            //模板View绑定事件
            textClassifyViewDome.textClassify_Event += Tapped;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
            FuncInit();
        });
    }
    //多线程初始化
    public void FuncInit() 
	{
        //初始化板块
        //int num = AppWebApi.tuiteApi.GetClassifyInfoData().Count;
        int num = 12;
        if (num > 10)
        {
            classify_Status = false;
            ClassifyInit(9, true, false);
        }
        else
        {
            classify_Status = true;
            ClassifyInit(num, false, false);
        }
    }
    //板块被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
    //板块通知帖子被单击
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

    }
    //管理按钮被单击
    private void Manage_Button_Tapped(object sender, TappedEventArgs e)
    {

    }
    //加入按钮被单击
    private void Add_Button_Tapped(object sender, TappedEventArgs e)
    {

    }
    //发布按钮被单击
    private void AddPost_Button_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AddPostPage());
    }
    //分类标签被点击
    private void Tapped(TextClassInfo info)
    {

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
    #region 数据测试模板

    private void ClassifyInit(int num,bool status,bool isUpdata = true) 
	{
		classifyModels.classifyInfos_List = null;
		List<ClassifyInfo> _temp = new List<ClassifyInfo>(); 
        for (int i = 0; i < num; i++)
		{
            _temp.Add(new ClassifyInfo { Image = "test2.jpg", ContentName = "//test", Name = $"老司机{i.ToString()}", ReplyNum = 10 });
		}
		if (status)
		{
            _temp.Add(new ClassifyInfo { Image = "more.png", ContentName = "//test", Name = "展开更多", ReplyNum = -1 });
		}
		else
		{
            _temp.Add(new ClassifyInfo { Image = "more.png", ContentName = "//test", Name = "收起", ReplyNum = -1 });
		}
		classifyModels.classifyInfos_List = _temp;
    }

    #endregion
}