﻿using DontPanic.TumblrSharp.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace DashFoss.Models
{
    public class TumblrPost
    {
        public string Author { get; set; }

        public long Id { get; set; }

        public long Notes { get; set; }

        public List<PostBit> Bits { get; set; }

        public string RebloggedFrom { get; set; }

        public bool WasReblogged => RebloggedFrom != null && RebloggedFrom != string.Empty;

        public string AvatarUrl => $"https://api.tumblr.com/v2/blog/{Author}/avatar/48";

        public BasePost BasePost { get; set; }

        public bool Liked
        { 
            get
            {
                return BasePost.Liked == "true"; // ???
            }
            set
            {
                BasePost.Liked = value ? "true" : "false";
            }
        }
    }
}
