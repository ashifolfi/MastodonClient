using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastodonClient;

/// <summary>
/// Used to handle most of the Mastodon API calls we have to make.
/// 
/// Yes a lot of this is static, yes I do kinda suck at making apps.
/// </summary>
internal class APIHandler
{
    public static APIHandler Instance { get; private set; } = new APIHandler();

    string InstanceUrl;
    // it's probably a bad idea to store this clear as day?
    string accessToken;
}
