using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tuite.ViewModels;
public class HomePageModel : INotifyPropertyChanged
{
	//用户昵称
	private string _Name;
    public string Name
    {
        get => _Name;
        set
        {
            _Name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        }
    }
    //签名
    private string _Sign;
    public string Sign
    {
        get => _Sign;
        set
        {
            _Sign = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sign"));
        }
    }
    //头像
    private string _HeadShot;
    public string HeadShot 
	{
		get => _HeadShot;
		set 
		{
			_HeadShot = value;
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("HeadShot"));
        }
	}
    //用户等级
    private int _Grade;
    public int Grade
    {
        get => _Grade;
        set 
        {
            _Grade = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Grade"));
        }
    }
    //关注数量
    private int _GuanZhu;
    public int GuanZhu
    {
        get => _GuanZhu;
        set
        {
            _GuanZhu = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GuanZhu"));
        }
    }
    //粉丝数量
    private int _FenSi;
    public int FenSi
    {
        get => _FenSi;
        set
        {
            _FenSi = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FenSi"));
        }
    }
    //使用天数
    private int _Day;
    public int Day
    {
        get => _Day;
        set
        {
            _Day = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Day"));
        }
    }
    //推荐图
    private string[] _GG;
    public string[] GG
    {
        get => _GG;
        set 
        {
            _GG = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GG"));
        }
    }
    public HomePageModel()
	{
		Test_HeadShot();
    }
    public event PropertyChangedEventHandler? PropertyChanged;
	#region
	private void Test_HeadShot() 
	{
		HeadShot = "test2.jpg";
        Name = "酷酷的小贤佬";
        Sign = "这是一个非常个性的个性签名......";
        Grade = 10;
        GuanZhu = 10;
        FenSi = 22;
        Day = 22;
        GG = new string[2] { "test.jpg", "test.jpg" };
    }
    #endregion
}