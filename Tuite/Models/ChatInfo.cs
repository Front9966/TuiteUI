namespace Tuite.Models;
public class ChatInfo
{
    public int MsgID { get; set; }
    public string Message { get; set; }
    //�û�ID
    public int UserID { get; set; }
    public int ContentType { get; set; } // 0:�Լ� 1:�Է� 2:ʱ��
    public string HeadImage { get; set; }
    public DateTime Time { get; set; }
}