namespace Tuite.Models;
//用户列表
public class UserListInfo
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string UserSign { get; set; }
    public string UserImge { get; set; }
    //是否已关注
    public string Status { get; set; }
}