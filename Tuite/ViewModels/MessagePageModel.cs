using System.ComponentModel;
using System.Windows.Input;
namespace Tuite.ViewModels;
public class MessagePageModel : INotifyPropertyChanged
{
	private List<MessageList> _message_List;
    //��Ϣ�б����ݰ�
    public List<MessageList> message_List
    {
        get => _message_List;
        set 
        {
            _message_List = value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("message_List"));
        }
    }
    //��ʼ��
    public MessagePageModel()
	{
        Message_List();

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    #region ��������ģ��
    private void Message_List() 
    {
        List<MessageList> _temp = new List<MessageList>();
        for (int i = 0; i < 5; i++) 
        {
            _temp.Add(new MessageList() { Image = "test.jpg", Msg = "�������һ����ʾ����Ϣ", MsgNumber = 2, Name = "���ĺ���", Time = new DateTime(), UserID = 10 });
        }
        message_List = _temp;
    }
    #endregion
}