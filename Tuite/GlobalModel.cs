global using Tuite.ViewModels;
global using Tuite.Models;
global using Tuite.WebApi;
global using Newtonsoft.Json;

namespace Tuite;
//网页接口
public class AppWebApi 
{
    public static readonly TuiteApi tuiteApi;

}
//导航栏信息
public class ShellPageInFo 
{
    public string Title { get; set; }
    public string Image { get; set; }
}
