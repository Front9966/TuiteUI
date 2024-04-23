using System.ComponentModel;
using System.Windows.Input;
namespace Tuite.ViewModels;
public class MessagePageModel : INotifyPropertyChanged
{
	private List<MessageList> _message_List;
    //消息列表数据绑定
    public List<MessageList> message_List
    {
        get => _message_List;
        set 
        {
            _message_List = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("message_List"));
        }
    }
    //初始化
    public MessagePageModel()
	{
        Message_List();

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    #region 测试数据模板
    private void Message_List() 
    {
        List<MessageList> _temp = new List<MessageList>();
        for (int i = 0; i < 5; i++) 
        {
            _temp.Add(new MessageList() { Image = "test.jpg", Msg = "这是最后一条显示的信息", MsgNumber = 2, Name = "酷酷的好友", Time = new DateTime(), UserID = 10 });
        }
        message_List = _temp;
    }
    #endregion
}