namespace Tuite.Models;
public class ChatInfo
{
    public int MsgID { get; set; }
    public string Message { get; set; }
    //用户ID
    public int UserID { get; set; }
    public int ContentType { get; set; } // 0:自己 1:对方 2:时间
    public string HeadImage { get; set; }
    public DateTime Time { get; set; }
}