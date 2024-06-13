using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastodonClient.MastodonData;

public class Account
{
    public string id { get; set; }
    public string username { get; set; }
    public string acct { get; set; }
    public string display_name { get; set; }
    public bool locked { get; set; }
    public bool bot { get; set; }
    public bool discoverable { get; set; }
    public bool indexable { get; set; }
    public bool group { get; set; }
    public DateTime created_at { get; set; }
    public string note { get; set; }
    public string url { get; set; }
    public string uri { get; set; }
    public string avatar { get; set; }
    public string avatar_static { get; set; }
    public string header { get; set; }
    public string header_static { get; set; }
    public int followers_count { get; set; }
    public int following_count { get; set; }
    public int statuses_count { get; set; }
    public string last_status_at { get; set; }
    public bool hide_collections { get; set; }
    public bool noindex { get; set; }
    public Emoji[] emojis { get; set; }
    public object[] roles { get; set; }
    public Field[] fields { get; set; }
}

public class Emoji
{
    public string shortcode { get; set; }
    public string url { get; set; }
    public string static_url { get; set; }
    public bool visible_in_picker { get; set; }
}

public class Field
{
    public string name { get; set; }
    public string value { get; set; }
    public object verified_at { get; set; }
}

