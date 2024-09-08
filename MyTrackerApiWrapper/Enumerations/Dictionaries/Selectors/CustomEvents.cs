using MyTrackerApiWrapper.Attributes;

namespace MyTrackerApiWrapper.Enumerations.Dictionaries.Selectors;

/// <summary>
/// The list of <see cref="Event.CustomEvents"/> selectors
/// </summary>
public enum CustomEvents : ushort
{
    /// <summary>
    /// App key, embedded in SDK (SDK_KEY), is issued after <seealso href="https://docs.tracker.my.com/en/environment/application/about">adding the application</seealso>
    /// </summary>
    [QueryValue("SDKKey")] SdkKey,

    /// <summary>
    /// State of tracking switch 
    /// </summary>
    [QueryValue("adTrackingEnabled")] AdTrackingEnabled,

    /// <summary>
    /// Android advertising identifier (GAID)
    /// </summary>
    [QueryValue("advertisingId")] AdvertisingId,

    /// <summary>
    /// Android identifier 
    /// </summary>
    [QueryValue("androidId")] AndroidId,

    /// <summary>
    /// App Tracking Transparency Status 
    /// </summary>
    [QueryValue("attStatus")] AttStatus,

    /// <summary>
    /// This dimension indicates whether Bluetooth was enabled on device when particular event (launch, update etc.) had occurred. 
    /// </summary>
    [QueryValue("bluetoothEnabled")] BluetoothEnabled,

    /// <summary>
    /// Number of custom events 
    /// </summary>
    [QueryValue("countCustomEvent")] CountCustomEvent,

    /// <summary>
    /// <see href="https://docs.tracker.my.com/en/tracking/user_tracking/user_identifying">User identifier</see>
    /// sent via SDK. It defines individual user. 
    /// </summary>
    [QueryValue("customUserId")] CustomUserId,

    /// <summary>
    /// Dots per inch 
    /// </summary>
    [QueryValue("dpi")] Dpi,

    /// <summary>
    /// Event date. Use the timezone parameter to change the default timezone. Default timezone <see cref="Timezone.EuropeMoscow"/>. 
    /// </summary>
    [QueryValue("dtEvent")] EventDate,

    /// <summary>
    /// Event name
    /// </summary>
    [QueryValue("eventName")] EventName,

    /// <summary>
    /// Event value 
    /// </summary>
    [QueryValue("eventValue")] EventValue,

    /// <summary>
    /// Account identifier in MyTracker 
    /// </summary>
    [QueryValue("idAccount")] AccountId,

    /// <summary>
    /// Tracing link identifier 
    /// </summary>
    [QueryValue("idAd")] AdId,

    /// <summary>
    /// Tracking link identifier for current attribution 
    /// </summary>
    [QueryValue("idAdAttr")] AdAttributeId,

    /// <summary>
    /// Tracking link for current attribution 
    /// </summary>
    [QueryValue("idAdAttrTitle")] AdAttributionTitleId,

    /// <summary>
    /// Type of advertising interaction that led to attribution. Available values in the <see cref="AttributionType"/> dictionary. 
    /// </summary>
    [QueryValue("idAdEventType")] AdEventTypeId,

    /// <summary>
    /// Explanation for the advertising interaction type that led to attribution. Available values in the <see cref="AttributionType"/> dictionary. 
    /// </summary>
    [QueryValue("idAdEventTypeTitle")] AdEventTitleId,

    /// <summary>
    /// Tracing link 
    /// </summary>
    [QueryValue("idAdTitle")] AdTitleId,

    /// <summary>
    /// Application identifier in MyTracker 
    /// </summary>
    [QueryValue("idApp")] AppId,

    /// <summary>
    /// Install service identifier 
    /// </summary>
    [QueryValue("idAppStore")] AppStoreId,

    /// <summary>
    /// Install service.
    /// <remarks>
    /// Increases the download time of raw data.
    /// </remarks> 
    /// </summary>
    [QueryValue("idAppStoreTitle")] AppStoreTitleId,

    /// <summary>
    /// Application title in MyTracker 
    /// </summary>
    [QueryValue("idAppTitle")] AppTitleId,

    /// <summary>
    /// Application version identifier 
    /// </summary>
    [QueryValue("idAppVersion")] AppVersionId,

    /// <summary>
    /// Application version 
    /// </summary>
    [QueryValue("idAppVersionTitle")] AppVersionTitle,

    /// <summary>
    /// Campaign identifier 
    /// </summary>
    [QueryValue("idCampaign")] CampaignId,


    /// <summary>
    /// Campaign identifier for current attribution 
    /// </summary>
    [QueryValue("idCampaignAttr")] CampaignAttributionId,

    /// <summary>
    /// Campaign name for current attribution 
    /// </summary>
    [QueryValue("idCampaignAttrTitle")] CampaignAttributionTitleId,

    /// <summary>
    /// Campaign creator identifier 
    /// </summary>
    [QueryValue("idCampaignCreator")] CampaignCreatorId,

    /// <summary>
    /// Campaign creator identifier for current attribution 
    /// </summary>
    [QueryValue("idCampaignCreatorAttr")] CampaignCreatorAttributionId,

    /// <summary>
    /// Campaign creator name for current attribution 
    /// </summary>
    [QueryValue("idCampaignCreatorAttrName")]
    CampaignCreatorAttributionName,

    /// <summary>
    /// Campaign creator name identifier
    /// </summary>
    [QueryValue("idCampaignCreatorName")] CampaignCreatorNameId,

    /// <summary>
    /// Campaign title 
    /// </summary>
    [QueryValue("idCampaignTitle")] CampaignTitle,

    /// <summary>
    /// Connection type identifier 
    /// </summary>
    [QueryValue("idConnectionType")] ConnectionTypeId,

    /// <summary>
    /// Connection type title 
    /// </summary>
    [QueryValue("idConnectionTypeTitle")] ConnectionTypeTitle,

    /// <summary>
    /// Country identifier
    /// </summary>
    [QueryValue("idCountry")] CountryId,

    /// <summary>
    /// Country code (ISO alpha-2) 
    /// </summary>
    [QueryValue("idCountryISOAlpha2")] CountryCodeIsoAlpha2,

    /// <summary>
    /// Country code (ISO numeric) 
    /// </summary>
    [QueryValue("idCountryISONumeric")] CountryCodeIsoNumeric,

    /// <summary>
    /// Country title 
    /// </summary>
    [QueryValue("idCountryTitle")] CountryTitle,

    /// <summary>
    /// Identifier of the individual device. It defines the physical device (browser for web applications) 
    /// </summary>
    [QueryValue("idDevice")] DeviceId,

    /// <summary>
    /// Device model identifier 
    /// </summary>
    [QueryValue("idDeviceModel")] DeviceModelId,

    /// <summary>
    /// Device model title.
    /// <remarks>
    /// Increases the download time of raw data.
    /// </remarks>
    /// </summary>
    [QueryValue("idDeviceModelTitle")] DeviceModelTitle,

    /// <summary>
    ///  Manufacturer identifier 
    /// </summary>
    [QueryValue("idManufacturer")] ManufacturerId,

    /// <summary>
    /// Manufacturer title.
    /// <remarks>
    /// Increases the download time of raw data. 
    /// </remarks>
    /// </summary>
    [QueryValue("idManufacturerTitle")] ManufacturerTitle,

    /// <summary>
    /// Manufacturer identifier in the MyTracker dictionary 
    /// </summary>
    [QueryValue("idMobileManufacturerBrand")]
    MyTrackerManufacturerId,

    /// <summary>
    /// Manufacturer title in the MyTracker dictionary 
    /// </summary>
    [QueryValue("idMobileManufacturerBrandTitle")]
    MyTrackerManufacturerTitle,

    /// <summary>
    /// Device model identifier in the MyTracker dictionary 
    /// </summary>
    [QueryValue("idMobileManufacturerDevice")]
    MyTrackerDeviceModelId,

    /// <summary>
    /// Device model title in the MyTracker dictionary 
    /// </summary>
    [QueryValue("idMobileManufacturerDeviceTitle")]
    MyTrackerDeviceModelTitle,

    /// <summary>
    /// Current mobile operator identifier 
    /// </summary>
    [QueryValue("idMobileOperatorCurrent")]
    CurrentMobileOperatorId,

    /// <summary>
    /// Title of current mobile operator 
    /// </summary>
    [QueryValue("idMobileOperatorCurrentTitle")]
    CurrentMobileOperatorTitle,

    /// <summary>
    /// Mobile operator identifier of SIM card 
    /// </summary>
    [QueryValue("idMobileOperatorSim")] MobileOperatorSimId,

    /// <summary>
    /// Name of mobile operator of SIM card 
    /// </summary>
    [QueryValue("idMobileOperatorSimTitle")]
    MobileOperatorSimTitle,

    /// <summary>
    /// Operating system identifier 
    /// </summary>
    [QueryValue("idOs")] OsId,

    /// <summary>
    /// OS language identifier 
    /// </summary>
    [QueryValue("idOsLang")] OsLanguageId,

    /// <summary>
    /// OS language.
    /// <remarks>
    /// Increases the download time of raw data. 
    /// </remarks>
    /// </summary>
    [QueryValue("idOsLangTitle")] OsLanguageTitle,

    /// <summary>
    /// OS timezone identifier
    /// </summary>
    [QueryValue("idOsTimezone")] OsTimeZoneId,

    /// <summary>
    /// OS timezone title.
    /// <remarks>
    /// Increases the download time of raw data.
    /// </remarks>
    /// </summary>
    [QueryValue("idOsTimezoneTitle")] OsTimeZoneTitle,

    /// <summary>
    /// Operating system title 
    /// </summary>
    [QueryValue("idOsTitle")] OsTitle,

    /// <summary>
    /// OS version identifier 
    /// </summary>
    [QueryValue("idOsVersion")] OsVersionId,

    /// <summary>
    /// OS version
    /// </summary>
    [QueryValue("idOsVersionTitle")] OsVersionTitle,

    /// <summary>
    /// Partner identifier 
    /// </summary>
    [QueryValue("idPartner")] PartnerId,

    /// <summary>
    /// Partner identifier for current attribution 
    /// </summary>
    [QueryValue("idPartnerAttr")] AttributionPartnerId,

    /// <summary>
    /// Partner title for current attribution 
    /// </summary>
    [QueryValue("idPartnerAttrTitle")] AttributionPartnerTitle,

    /// <summary>
    /// Partner identifier for previous attribution 
    /// </summary>
    [QueryValue("idPartnerPrevAttr")] PreviousAttributionPartnerId,

    /// <summary>
    /// Partner title for previous attribution 
    /// </summary>
    [QueryValue("idPartnerPrevAttrTitle")] PreviousAttributionPartnerTitle,

    /// <summary>
    /// Partner title
    /// </summary>
    [QueryValue("idPartnerTitle")] PartnerTitle,

    /// <summary>
    /// Platform identifier 
    /// </summary>
    [QueryValue("idPlatform")] PlatformId,

    /// <summary>
    /// Platform title 
    /// </summary>
    [QueryValue("idPlatformTitle")] PlatformTitleId,

    /// <summary>
    /// Device identifier in the app. It defines a pair of app+device (idApp+idDevice). 
    /// </summary>
    [QueryValue("idProfile")] ProfileId,

    /// <summary>
    /// Project identifier in MyTracker 
    /// </summary>
    [QueryValue("idProject")] ProjectId,

    /// <summary>
    /// Project title in MyTracker 
    /// </summary>
    [QueryValue("idProjectTitle")] ProjectTitle,

    /// <summary>
    /// Region identifier
    /// </summary>
    [QueryValue("idRegion")] RegionId,

    /// <summary>
    /// Low region identifier 
    /// </summary>
    [QueryValue("idRegionLow")] LowRegionId,

    /// <summary>
    /// Low region title
    /// </summary>
    [QueryValue("idRegionLowTitle")] LowRegionTitle,

    /// <summary>
    /// Region title 
    /// </summary>
    [QueryValue("idRegionTitle")] RegionTitle,

    /// <summary>
    /// Additional identifier 1 
    /// </summary>
    [QueryValue("idSub1")] AdditionalId1,

    /// <summary>
    /// Additional identifier 1 for current attribution 
    /// </summary>
    [QueryValue("idSub1Attr")] AttributionAdditionalId1,

    /// <summary>
    /// Explanation for additional identifier 1 for current attribution 
    /// </summary>
    [QueryValue("idSub1AttrTitle")] AttributionAdditionalId1Title,

    /// <summary>
    /// Explanation for additional identifier 1.
    /// <remarks>
    /// Increases the download time of raw data if <b>TimestampFrom</b> or <b>DateFrom</b> is set before 2021-06-03. 
    /// </remarks>
    /// </summary>
    [QueryValue("idSub1Title")] AdditionalId1Title,

    /// <summary>
    /// Additional identifier 2
    /// </summary>
    [QueryValue("idSub2")] AdditionalId2,

    /// <summary>
    /// Additional identifier 2 for current attribution 
    /// </summary>
    [QueryValue("idSub2Attr")] AttributionAdditionalId2,

    /// <summary>
    /// Explanation for additional identifier 2 for current attribution 
    /// </summary>
    [QueryValue("idSub2AttrTitle")] AttributionAdditionalId2Title,

    /// <summary>
    /// Explanation for additional identifier 2.
    /// <remarks>
    /// Increases the download time of raw data if <b>TimestampFrom</b> or <b>DateFrom</b> is set before 2021-06-03. 
    /// </remarks>
    /// </summary>
    [QueryValue("idSub2Title")] AdditionalId2Title,

    /// <summary>
    /// Additional identifier 3
    /// </summary>
    [QueryValue("idSub3")] AdditionalId3,

    /// <summary>
    /// Additional identifier 3 for current attribution 
    /// </summary>
    [QueryValue("idSub3Attr")] AttributionAdditionalId3,

    /// <summary>
    /// Explanation for additional identifier 3 for current attribution 
    /// </summary>
    [QueryValue("idSub3AttrTitle")] AttributionAdditionalId3Title,

    /// <summary>
    /// Explanation for additional identifier 3.
    /// <remarks>
    /// Increases the download time of raw data if <b>TimestampFrom</b> or <b>DateFrom</b> is set before 2021-06-03. 
    /// </remarks>
    /// </summary>
    [QueryValue("idSub3Title")] AdditionalId3Title,

    /// <summary>
    /// Additional identifier 4
    /// </summary>
    [QueryValue("idSub4")] AdditionalId4,

    /// <summary>
    /// Additional identifier 4 for current attribution 
    /// </summary>
    [QueryValue("idSub4Attr")] AttributionAdditionalId4,

    /// <summary>
    /// Explanation for additional identifier 4 for current attribution 
    /// </summary>
    [QueryValue("idSub4AttrTitle")] AttributionAdditionalId4Title,

    /// <summary>
    /// Explanation for additional identifier 4.
    /// <remarks>
    /// Increases the download time of raw data if <b>TimestampFrom</b> or <b>DateFrom</b> is set before 2021-06-03. 
    /// </remarks>
    /// </summary>
    [QueryValue("idSub4Title")] AdditionalId4Title,

    /// <summary>
    /// Additional identifier 5
    /// </summary>
    [QueryValue("idSub5")] AdditionalId5,

    /// <summary>
    /// Additional identifier 5 for current attribution 
    /// </summary>
    [QueryValue("idSub5Attr")] AttributionAdditionalId5,

    /// <summary>
    /// Explanation for additional identifier 5 for current attribution 
    /// </summary>
    [QueryValue("idSub5AttrTitle")] AttributionAdditionalId5Title,

    /// <summary>
    /// Explanation for additional identifier 5.
    /// <remarks>
    /// Increases the download time of raw data if <b>TimestampFrom</b> or <b>DateFrom</b> is set before 2021-06-03. 
    /// </remarks>
    /// </summary>
    [QueryValue("idSub5Title")] AdditionalId5Title,

    /// <summary>
    /// Additional ad set identifier 
    /// </summary>
    [QueryValue("idSubAdSet")] AdditionalAdSetId,

    /// <summary>
    /// Additional ad set identifier for current attribution 
    /// </summary>
    [QueryValue("idSubAdSetAttr")] AttributionAdditionalAdSetId,

    /// <summary>
    /// Explanation for additional ad set identifier for current attribution 
    /// </summary>
    [QueryValue("idSubAdSetAttrTitle")] AttributionAdditionalAdSetIdTitle,

    /// <summary>
    /// Explanation for additional ad set identifier  
    /// </summary>
    [QueryValue("idSubAdSetTitle")] AdditionalAdSetIdTitle,

    /// <summary>
    /// Additional campaign identifier
    /// </summary>
    [QueryValue("idSubCampaign")] AdditionalCampaignId,

    /// <summary>
    /// Additional campaign identifier for current attribution 
    /// </summary>
    [QueryValue("idSubCampaignAttr")] AttributionAdditionalCampaignId,

    /// <summary>
    /// Explanation for additional campaign identifier for current attribution
    /// </summary>
    [QueryValue("idSubCampaignAttrTitle")] AttributionAdditionalCampaignIdTitle,

    /// <summary>
    ///  Explanation for additional campaign identifier 
    /// </summary>
    [QueryValue("idSubCampaignTitle")] AdditionalCampaignIdTitle,

    /// <summary>
    /// Additional creative identifier 
    /// </summary>
    [QueryValue("idSubCreative")] AdditionalCreativeId,

    /// <summary>
    /// Additional creative identifier for current attribution 
    /// </summary>
    [QueryValue("idSubCreativeAttr")] AttributionAdditionalCreativeId,


    /// <summary>
    /// Explanation for additional creative identifier for current attribution 
    /// </summary>
    [QueryValue("idSubCreativeAttrTitle")] AttributionAdditionalCreativeIdTitle,

    /// <summary>
    /// Explanation for additional creative identifier
    /// </summary>
    [QueryValue("idSubCreativeTitle")] AdditionalCreativeIdTitle,

    /// <summary>
    /// Additional traffic type identifier
    /// </summary>
    [QueryValue("idSubMedium")] AdditionalTrafficTypeId,

    /// <summary>
    /// Additional traffic type identifier for current attribution 
    /// </summary>
    [QueryValue("idSubMediumAttr")] AttributionAdditionalTrafficTypeId,

    /// <summary>
    /// Explanation for additional traffic type identifier for current attribution 
    /// </summary>
    [QueryValue("idSubMediumAttrTitle")] AttributionAdditionalTrafficTypeIdTitle,

    /// <summary>
    /// Explanation for additional traffic type identifier 
    /// </summary>
    [QueryValue("idSubMediumTitle")] AdditionalTrafficTypeIdTitle,

    /// <summary>
    /// Additional network identifier 
    /// </summary>
    [QueryValue("idSubNetwork")] AdditionalNetworkId,

    /// <summary>
    /// Additional network identifier for current attribution 
    /// </summary>
    [QueryValue("idSubNetworkAttr")] AttributionAdditionalNetworkId,

    /// <summary>
    /// Explanation for additional network identifier for current attribution 
    /// </summary>
    [QueryValue("idSubNetworkAttrTitle")] AttributionAdditionalNetworkIdTitle,

    /// <summary>
    /// Explanation for additional network identifier 
    /// </summary>
    [QueryValue("idSubNetworkTitle")] AdditionalNetworkIdTitle,

    /// <summary>
    /// SDK version identifier 
    /// </summary>
    [QueryValue("idTrackerSdkVersion")] SdkVersionId,

    /// <summary>
    /// SDK version title 
    /// </summary>
    [QueryValue("idTrackerSdkVersionTitle")]
    SdkVersionTitle,

    /// <summary>
    /// Traffic type identifier 
    /// </summary>
    [QueryValue("idTrafficType")] TrafficTypeId,

    /// <summary>
    /// Traffic type title
    /// </summary>
    [QueryValue("idTrafficTypeTitle")] TrafficTypeTitle,

    /// <summary>
    /// iOS advertising identifier 
    /// </summary>
    [QueryValue("idfa")] Idfa,

    /// <summary>
    /// Identifier for S2S 
    /// </summary>
    [QueryValue("instanceId")] InstanceId,

    /// <summary>
    /// iOS vendor identifier 
    /// </summary>
    [QueryValue("iosVendorId")] IosVendorId,

    /// <summary>
    /// Huawei advertising identifier 
    /// </summary>
    [QueryValue("oaid")] OaId,

    /// <summary>
    /// List of parameter names
    /// <example>
    /// ['param1','param2\n with line break','param3 with special characters\'\\"",' ] 
    /// </example>
    /// </summary>
    [QueryValue("params.name")] ParamsName,

    /// <summary>
    /// List of parameter values
    /// <example>
    /// ['value1','value2\n with line break','value3 with special characters\'\\"",']
    /// </example>
    /// </summary>
    [QueryValue("params.value")] ParamsValue,

    /// <summary>
    /// Root/Jailbreak status. Available values in the <see cref="Rooted"/> dictionary. 
    /// </summary>
    [QueryValue("rooted")] IsRooted,

    /// <summary>
    /// Value explanation for Root/Jailbreak status. Available values in the <see cref="Rooted"/> dictionary. 
    /// </summary>
    [QueryValue("rootedTitle")] RootedExplanation,

    /// <summary>
    /// Screen diagonal 
    /// </summary>
    [QueryValue("screenDiagonal")] ScreenDiagonal,

    /// <summary>
    /// Screen height 
    /// </summary>
    [QueryValue("screenHeight")] ScreenHeight,

    /// <summary>
    /// Screen width
    /// </summary>
    [QueryValue("screenWidth")] ScreenWidth,

    /// <summary>
    /// Attribution time in timestamp format 
    /// </summary>
    [QueryValue("tsAttr")] AttributionTimestamp,

    /// <summary>
    /// Event time in timestamp format
    /// </summary>
    [QueryValue("tsEvent")] EventTimestamp,

    /// <summary>
    /// Time when the record appears in the storage
    /// </summary>
    [QueryValue("tsInsert")] TimestampInsert,

    /// <summary>
    /// Installation time in timestamp format 
    /// </summary>
    [QueryValue("tsInstall")] InstallationTimestamp,

    /// <summary>
    /// Windows advertising identifier 
    /// </summary>
    [QueryValue("waid")] WindowsAdId,

    /// <summary>
    /// X dots per inch 
    /// </summary>
    [QueryValue("xdpi")] XDpi,

    /// <summary>
    /// Y dots per inch
    /// </summary>
    [QueryValue("ydpi")] YDpi
}