using MastodonClient.MastodonData;

namespace MastodonClient.Controls;

public partial class ProfileCard : ContentView
{
    public static readonly BindableProperty ProfileIdProperty = BindableProperty.Create("ProfileId", typeof(string), typeof(ProfileCard), "");
	public string ProfileId
    {
        get { return (string)GetValue(ProfileIdProperty); }
        set { SetValue(ProfileIdProperty, value); }
    }

    private Account m_AccountInfo;

	public ProfileCard()
    {
        InitializeComponent();
    }
}