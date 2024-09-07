namespace MyTrackerApiWrapper.Dictionaries;

/// <summary>
/// List of available <seealso href="https://docs.tracker.my.com/en/api/export-api/dictionary/events">events</seealso>
/// </summary>
public enum Event : ushort
{
    #region Devices
    /// <summary>
    /// Devices - Activities
    /// </summary>
    Activities,
    /// <summary>
    /// Devices - Ad monetization
    /// </summary>
    AdMonetization,
    /// <summary>
    /// Devices - App updates
    /// </summary>
    AppUpdates,
    /// <summary>
    /// Devices - SKAN postbacks from Apple
    /// </summary>
    AppleSKANpostbacks,
    /// <summary>
    /// Devices - Custom events
    /// </summary>
    CustomEvents,
    /// <summary>
    /// Devices - Deep links
    /// </summary>
    Deeplinks,
    /// <summary>
    /// Devices - Authorisations
    /// </summary>
    DeviceAuthorisations,
    /// <summary>
    /// Devices - Registrations
    /// </summary>
    DeviceRegistrations,
    /// <summary>
    /// Devices - Web pageviews
    /// </summary>
    Hits,
    /// <summary>
    /// Devices - Installs
    /// </summary>
    Installs,
    /// <summary>
    /// Devices - New devices
    /// </summary>
    NewDevices,
    /// <summary>
    /// Devices - SKAN postbacks from Partner
    /// </summary>
    PartnerSKANpostbacks,
    /// <summary>
    /// Devices - Payments
    /// </summary>
    Payments,
    /// <summary>
    /// Devices - Re-engagements
    /// </summary>
    Reengagements,
    /// <summary>
    /// Devices - Re-installs
    /// </summary>
    Reinstalls,
    /// <summary>
    /// Devices - Sessions
    /// </summary>
    Sessions,
    /// <summary>
    /// Devices - Test payments
    /// </summary>
    TestPayments,
    /// <summary>
    /// Devices - Trial payments
    /// </summary>
    TrialPayments,
    #endregion

    #region Users
    /// <summary>
    /// Users - New users
    /// </summary>
    NewUsers,
    /// <summary>
    /// Users - Activities
    /// </summary>
    UserActivities,
    /// <summary>
    /// Users - Ad monetization
    /// </summary>
    UserAdMonetization,
    /// <summary>
    /// Users - Authorisations
    /// </summary>
    UserAuthorisations,
    /// <summary>
    /// Users - Custom events
    /// </summary>
    UserCustomEvents,
    /// <summary>
    /// Users - Deep links
    /// </summary>
    UserDeeplinks,
    /// <summary>
    /// Users - Web pageviews
    /// </summary>
    UserHits,
    /// <summary>
    /// Users - Payments
    /// </summary>
    UserPayments,
    /// <summary>
    /// Users - Re-engagements
    /// </summary>
    UserReengagements,
    /// <summary>
    /// Users - Registrations
    /// </summary>
    UserRegistrations,
    /// <summary>
    /// Users - Sessions
    /// </summary>
    UserSessions,
    /// <summary>
    /// Users - Trial payments
    /// </summary>
    UserTrialPayments
    #endregion
}