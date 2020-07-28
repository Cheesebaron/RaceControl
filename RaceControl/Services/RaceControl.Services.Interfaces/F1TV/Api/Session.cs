﻿using Newtonsoft.Json;
using RaceControl.Common;
using System;
using System.Collections.Generic;

namespace RaceControl.Services.Interfaces.F1TV.Api
{
    public class Session
    {
        [JsonProperty("uid")]
        public string UID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("session_name")]
        public string SessionName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content_urls")]
        public List<string> ContentUrls { get; set; }

        [JsonProperty("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }

        public static string UIDField => JsonUtils.GetJsonPropertyName<Session>((s) => s.UID);
        public static string NameField => JsonUtils.GetJsonPropertyName<Session>((s) => s.Name);
        public static string SessionNameField => JsonUtils.GetJsonPropertyName<Session>((s) => s.SessionName);
        public static string StatusField => JsonUtils.GetJsonPropertyName<Session>((s) => s.Status);
        public static string ContentUrlsField => JsonUtils.GetJsonPropertyName<Session>((s) => s.ContentUrls);
        public static string StartTimeField => JsonUtils.GetJsonPropertyName<Session>((s) => s.StartTime);
        public static string EndTimeField => JsonUtils.GetJsonPropertyName<Session>((s) => s.EndTime);
    }
}