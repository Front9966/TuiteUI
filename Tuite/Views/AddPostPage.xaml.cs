namespace Tuite.Views;

public partial class AddPostPage : ContentPage
{
	public AddPostPageModel model;
	public AddPostPage()
	{
		InitializeComponent();
		Task.Run(() => {
			this.Title = "����������˾����";
			model = new AddPostPageModel();
			this.BindingContext = model;
        });
    }
	//������ť������
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}