namespace Tuite.Views;

public partial class AddPostPage : ContentPage
{
	public AddPostPageModel model;
	public AddPostPage()
	{
		InitializeComponent();
		Task.Run(() => {
			this.Title = "发布到【老司机】";
			model = new AddPostPageModel();
			this.BindingContext = model;
        });
    }
	//发布按钮被单击
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}