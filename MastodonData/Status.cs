using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastodonClient.MastodonData;

public class Status
{
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public string in_reply_to_id { get; set; }
    public string in_reply_to_account_id { get; set; }
    public bool sensitive { get; set; }
    public string spoiler_text { get; set; }
    public string visibility { get; set; }
    public string language { get; set; }
    public string uri { get; set; }
    public string url { get; set; }
    public int replies_count { get; set; }
    public int reblogs_count { get; set; }
    public int favourites_count { get; set; }
    public DateTime? edited_at { get; set; }
    public bool local_only { get; set; }
    public string content { get; set; }
    public Status? reblog { get; set; }
    public Application application { get; set; }
    public object[] media_attachments { get; set; }
    public object[] mentions { get; set; }
    public object[] tags { get; set; }
    public object[] emojis { get; set; }
    public object card { get; set; }
    public object poll { get; set; }
    public Account account { get; set; }
}

