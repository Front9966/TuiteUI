namespace Tuite.Views;

public partial class PostContentPage : ContentPage
{
	public PostContentPageModel model;
    public PostContentPage()
	{
		InitializeComponent();
		Task.Run(() => {
			this.Title = "�������";
			model = new PostContentPageModel();
			this.BindingContext = model;
		});
	}
}