using System.Diagnostics;
using System.Text.Json;

namespace MastodonClient.Controls;

public partial class UserStatus : ContentView
{
	public static readonly BindableProperty PostIdProperty = BindableProperty.Create("PostId", typeof(string), typeof(UserStatus), "", propertyChanged: OnPostIdChanged);
	public string PostId
	{
		get { return (string)GetValue(PostIdProperty); }
		set {
			SetValue(PostIdProperty, value);
		}
	}
	
	const string InstanceAddress = "meow.social";
	HttpClient client;
	MastodonData.Status StatusData;

    public UserStatus()
	{
		client = new HttpClient();
		InitializeComponent();
    }

	private async void LoadData()
	{
		try
		{
			using HttpResponseMessage message = await client.GetAsync($"https://{InstanceAddress}/api/v1/statuses/{PostId}");
			message.EnsureSuccessStatusCode();
			string messageContent = await message.Content.ReadAsStringAsync();

			// shut up
			StatusData = JsonSerializer.Deserialize<MastodonData.Status>(messageContent);

			PostUserName.Text = StatusData.account.display_name;
			PostContent.Text = StatusData.content;
		}
		catch (HttpRequestException ex)
		{
			FailureBox.IsVisible = true;
			FailureReason.Text = FailureReason.Text.Replace("Unknown", $"Code: {ex.StatusCode}");
		}
		catch (NullReferenceException)
		{
			FailureBox.IsVisible = true;
            FailureReason.Text = FailureReason.Text.Replace("Unknown", "NullReferenceException in Json Response");
        }
	}

	// we do not need old why is this required.
	static void OnPostIdChanged(BindableObject bObject, object oldValue, object newValue)
	{
		var statusCtrl = (UserStatus)bObject;

		statusCtrl.LoadData();
	}
}