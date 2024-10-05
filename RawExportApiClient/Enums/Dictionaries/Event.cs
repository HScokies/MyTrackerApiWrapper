using RawExportApiClient.Attributes;

namespace RawExportApiClient.Enums.Dictionaries;

/// <summary>
/// List of available <seealso href="https://docs.tracker.my.com/en/api/export-api/dictionary/events">events</seealso>
/// </summary>
public enum Event : ushort
{
    #region Devices

    /// <summary>
    /// Devices - Activities
    /// </summary>
    [QueryValue("activities")]
    Activities,

    /// <summary>
    /// Devices - Ad monetization
    /// </summary>
    [QueryValue("adMonetization")]
    AdMonetization,

    /// <summary>
    /// Devices - App updates
    /// </summary>
    [QueryValue("appUpdates")]
    AppUpdates,

    /// <summary>
    /// Devices - SKAN postbacks from Apple
    /// </summary>
    [QueryValue("appleSKANpostbacks")]
    AppleSkanPostbacks,

    /// <summary>
    /// Devices - Custom events
    /// </summary>
    [QueryValue("customEvents")]
    CustomEvents,

    /// <summary>
    /// Devices - Deep links
    /// </summary>
    [QueryValue("deeplinks")]
    Deeplinks,

    /// <summary>
    /// Devices - Authorisations
    /// </summary>
    [QueryValue("deviceAuthorisations")]
    DeviceAuthorisations,

    /// <summary>
    /// Devices - Registrations
    /// </summary>
    [QueryValue("deviceRegistrations")]
    DeviceRegistrations,

    /// <summary>
    /// Devices - Web pageviews
    /// </summary>
    [QueryValue("hits")]
    Hits,

    /// <summary>
    /// Devices - Installs
    /// </summary>
    [QueryValue("installs")]
    Installs,

    /// <summary>
    /// Devices - New devices
    /// </summary>
    [QueryValue("newDevices")]
    NewDevices,

    /// <summary>
    /// Devices - SKAN postbacks from Partner
    /// </summary>
    [QueryValue("partnerSKANpostbacks")]
    PartnerSkanPostbacks,

    /// <summary>
    /// Devices - Payments
    /// </summary>
    [QueryValue("payments")]
    Payments,

    /// <summary>
    /// Devices - Re-engagements
    /// </summary>
    [QueryValue("reengagements")]
    Reengagements,

    /// <summary>
    /// Devices - Re-installs
    /// </summary>
    [QueryValue("reinstalls")]
    Reinstalls,

    /// <summary>
    /// Devices - Sessions
    /// </summary>
    [QueryValue("sessions")]
    Sessions,

    /// <summary>
    /// Devices - Test payments
    /// </summary>
    [QueryValue("testPayments")]
    TestPayments,

    /// <summary>
    /// Devices - Trial payments
    /// </summary>
    [QueryValue("trialPayments")]
    TrialPayments,

    #endregion

    #region Users

    /// <summary>
    /// Users - New users
    /// </summary>
    [QueryValue("newUsers")]
    NewUsers,

    /// <summary>
    /// Users - Activities
    /// </summary>
    [QueryValue("userActivities")]
    UserActivities,

    /// <summary>
    /// Users - Ad monetization
    /// </summary>
    [QueryValue("userAdMonetization")]
    UserAdMonetization,

    /// <summary>
    /// Users - Authorisations
    /// </summary>
    [QueryValue("userAuthorisations")]
    UserAuthorisations,

    /// <summary>
    /// Users - Custom events
    /// </summary>
    [QueryValue("userCustomEvents")]
    UserCustomEvents,

    /// <summary>
    /// Users - Deep links
    /// </summary>
    [QueryValue("userDeeplinks")]
    UserDeeplinks,

    /// <summary>
    /// Users - Web pageviews
    /// </summary>
    [QueryValue("userHits")]
    UserHits,

    /// <summary>
    /// Users - Payments
    /// </summary>
    [QueryValue("userPayments")]
    UserPayments,

    /// <summary>
    /// Users - Re-engagements
    /// </summary>
    [QueryValue("userReengagements")]
    UserReengagements,

    /// <summary>
    /// Users - Registrations
    /// </summary>
    [QueryValue("userRegistrations")]
    UserRegistrations,

    /// <summary>
    /// Users - Sessions
    /// </summary>
    [QueryValue("userSessions")]
    UserSessions,

    /// <summary>
    /// Users - Trial payments
    /// </summary>
    [QueryValue("userTrialPayments")]
    UserTrialPayments

    #endregion
}