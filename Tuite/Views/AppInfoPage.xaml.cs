namespace Tuite.Views;

public partial class AppInfoPage : ContentPage
{
	public AppInfoPage(string pageNames)
	{
		InitializeComponent();
        this.BindingContext = this;
        this.Title = pageNames;
        if (pageNames == "��˽����")
        {
            html.Html = """
                        <!DOCTYPE html>
                        <html>
                        <body>

                        <h1>Hello world! </h1>
                        <p>����һ�����֣����Ը����Լ�����������滻��</p>

                        </body>
                        </html>
                        """;
        }
        else if (pageNames == "������־")
        {

        }
        else if (pageNames == "��˹���")
        {

        }
        else if (pageNames == "��������")
        {

        }
        else if (pageNames == "����")
        {

        }
    }
}