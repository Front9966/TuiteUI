using CommunityToolkit.Maui.Views;
namespace Tuite.Views;
public partial class LoadView : Popup
{
	public LoadView()
	{
		InitializeComponent();
		Task.Run(async () => {
			while (true) {
				await image1.RelRotateTo(360, 2000);
            }
		});
	}
}