namespace Tuite.Views;

public partial class AppInfoPage : ContentPage
{
	public AppInfoPage(string pageNames)
	{
		InitializeComponent();
        this.BindingContext = this;
        this.Title = pageNames;
        if (pageNames == "隐私政策")
        {
            html.Html = """
                        <!DOCTYPE html>
                        <html>
                        <body>

                        <h1>Hello world! </h1>
                        <p>这是一段文字，可以根据自己的需求进行替换。</p>

                        </body>
                        </html>
                        """;
        }
        else if (pageNames == "更新日志")
        {

        }
        else if (pageNames == "审核规则")
        {

        }
        else if (pageNames == "反馈中心")
        {

        }
        else if (pageNames == "关于")
        {

        }
    }
}