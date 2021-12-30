﻿namespace GameStarter
{
    public static class Arguments
    {
        public static string GameId { get; internal set; } = "0";
        public static string StartLocale { get; internal set; } = "KR";
        public static string LoginUrl { get; internal set; } = "https://nxlogin.nexon.com/common/login.aspx";

        public static string LoginRedirectUrl => $"{LoginUrl}?redirect=http://game.nexon.com/{GameId}";
    }
}
