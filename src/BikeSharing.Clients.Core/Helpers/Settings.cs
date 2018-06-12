//using Plugin.Settings;
//using Plugin.Settings.Abstractions;

namespace BikeSharing.Clients.Core.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        //private static ISettings AppSettings
        //{
        //    get
        //    {
        //        return CrossSettings.Current;
        //    }
        //}

        #region Setting Constants

        private const string UserIdKey = "user_id_key";
        private static readonly int UserIdDefault = 0;

        private const string ProfileIdKey = "profile_id_key";
        private static readonly int ProfileIdDefault = 0;

        private const string AccessTokenKey = "access_token_key";
        private static readonly string AccessTokenDefault = string.Empty;

        private const string CurrentBookingIdKey = "current_booking_id";
        private static readonly int CurrentBookingIdDefault = 0;

        private const string UwpWindowSizeKey = "uwp_window_size";
        private static readonly string UwpWindowSizeDefault = string.Empty;

        #endregion

        public static int UserId { get; set; }

        public static int ProfileId { get; set; }

		public static string AccessToken { get; set; }

		public static int CurrentBookingId { get; set; }

		public static string UwpWindowSize { get; set; }

		public static void RemoveUserId()
        {

        }

        public static void RemoveProfileId()
        {

        }

        public static void RemoveAccessToken()
        {

        }

        public static void RemoveCurrentBookingId()
        {
        }
    }
}