using CommunityToolkit.Maui.Views;
namespace Tuite.Views;
public partial class ClassifyPage : ContentPage
{
	//��ģ��
	public ClassifyPageModel classifyModels { get; set; }
	//���չ��״̬
	public bool classify_Status { get; set; }
	//�����ʼ������
	public ClassifyPage()
	{
		InitializeComponent();
        Task.Run(() =>
        {
            classifyModels = new ClassifyPageModel();
            this.BindingContext = classifyModels;
            //ģ��View���¼�
            textClassifyViewDome.textClassify_Event += Tapped;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
            FuncInit();
        });
    }
    //���̳߳�ʼ��
    public void FuncInit() 
	{
        //��ʼ�����
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
    //��鱻����
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
    //���֪ͨ���ӱ�����
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

    }
    //����ť������
    private void Manage_Button_Tapped(object sender, TappedEventArgs e)
    {

    }
    //���밴ť������
    private void Add_Button_Tapped(object sender, TappedEventArgs e)
    {

    }
    //������ť������
    private void AddPost_Button_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AddPostPage());
    }
    //�����ǩ�����
    private void Tapped(TextClassInfo info)
    {

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
    #region ���ݲ���ģ��

    private void ClassifyInit(int num,bool status,bool isUpdata = true) 
	{
		classifyModels.classifyInfos_List = null;
		List<ClassifyInfo> _temp = new List<ClassifyInfo>(); 
        for (int i = 0; i < num; i++)
		{
            _temp.Add(new ClassifyInfo { Image = "test2.jpg", ContentName = "//test", Name = $"��˾��{i.ToString()}", ReplyNum = 10 });
		}
		if (status)
		{
            _temp.Add(new ClassifyInfo { Image = "more.png", ContentName = "//test", Name = "չ������", ReplyNum = -1 });
		}
		else
		{
            _temp.Add(new ClassifyInfo { Image = "more.png", ContentName = "//test", Name = "����", ReplyNum = -1 });
		}
		classifyModels.classifyInfos_List = _temp;
    }

    #endregion
}