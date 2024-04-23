namespace Tuite.WebApi;
//用户信息类Api
public interface UserApi 
{ 
}
//平台信息类Api
public interface TuiteApi 
{
    //获取首页广告轮播图广告信息
    public List<AdClassInfo> GetAdClassInfoData();
    //获取首页快捷模块信息
    public List<Classify> GetClassifyData();
    //获取首页分类标签
    public List<TextClassInfo> GetTextClassInfoData();
    //获取首页推荐帖子
    public List<PostInfo> GetPostInfoData(int TextClassIndex);
    //获取所有板块信息
    public List<ClassifyInfo> GetClassifyInfoData();
}
//板块信息类Api
public interface PostApi 
{

}