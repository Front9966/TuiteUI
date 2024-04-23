namespace Tuite.Views;
public partial class TextClassifyViewDome : ContentView
{
    public delegate void TextClassify_Type(TextClassInfo info);
    public event TextClassify_Type textClassify_Event;
    public TextClassifyViewDome()
	{
		InitializeComponent();
    }
    //�ı���ǩ����
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        RadioButton radioButton = sender as RadioButton;
        TextClassInfo textClassInfo = (TextClassInfo)radioButton.BindingContext;
        textClassify_Event(textClassInfo);
    } 
}