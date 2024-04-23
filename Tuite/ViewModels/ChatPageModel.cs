using System.ComponentModel;

namespace Tuite.ViewModels;
public class ChatPageModel : INotifyPropertyChanged
{
    public List<ChatInfo> _Chat { get; set; }
    public List<ChatInfo> Chat 
    {
        get => _Chat;
        set 
        {
            _Chat = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Chat"));
        }
    }
    public ChatPageModel()
    {
        Chat_List();
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    #region
    private void Chat_List()
    {
        List<ChatInfo> _temp = new List<ChatInfo>();
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息1", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息2", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息3", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息3", ContentType = 2, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息4", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息5我是一条普通的消息5我是一条普通的消息5我是一条普通的消息5我是一条普通的消息5", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息6", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息6", ContentType = 2, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息7", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息8", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息1", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息2", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息3", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息3", ContentType = 2, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息4", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息5", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息6", ContentType = 0, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息6", ContentType = 2, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息7", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        _temp.Add(new ChatInfo() { HeadImage = "test2.jpg", Message = "我是一条普通的消息8", ContentType = 1, MsgID = 1, Time = new DateTime(), UserID = 1001 });
        Chat = _temp;
    }
    #endregion
}
//分类显示数据
public class ChatPageModels : DataTemplateSelector
{
    public DataTemplate MyChat{ get; set; }
    public DataTemplate YouChat { get; set; }
    public DataTemplate TimeData { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var a = (ChatInfo)item;
        return a.ContentType == 0 ? MyChat : a.ContentType == 1 ? YouChat : TimeData;
    }
}