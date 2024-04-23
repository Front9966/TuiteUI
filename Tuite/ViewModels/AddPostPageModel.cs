using System.ComponentModel;
namespace Tuite.ViewModels;
public class AddPostPageModel : INotifyPropertyChanged
{
	public List<string> _Image {  get; set; }
	public List<string> Image
	{
		get => _Image;
		set 
		{
			_Image = value;
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Image"));
		}
	}
	public AddPostPageModel()
	{
		List<string> _temp = new List<string>();
		_temp.Add("addpost_icon.png");
		Image = _temp;

    }

    public event PropertyChangedEventHandler? PropertyChanged;
}