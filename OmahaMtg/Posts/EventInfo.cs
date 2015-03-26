﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMtg.Posts
{
    public class EventInfo : PostInfo
    {
        public DateTime? EventStartTime { get; set; }
        public DateTime? EventEndTime { get; set; }

        public bool IsUserRsvpd { get; set; }
        public int TotalRsvpCount { get; set; }
        public long? VimeoId { get; set; }

    }
}