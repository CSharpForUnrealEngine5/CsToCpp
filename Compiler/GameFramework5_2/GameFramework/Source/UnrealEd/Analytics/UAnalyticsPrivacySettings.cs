#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Analytics/AnalyticsPrivacySettings.h")]
public partial class UAnalyticsPrivacySettings : UObject {
	///<summary>Determines whether the editor sends usage information to Epic Games in order to improve Unreal Engine. Your information will never be shared with 3rd parties.</summary>
	public bool bSendUsageData;
	///<summary>Determines whether the editor asks for your industry and sends that information to Epic Games in order to improve Unreal Engine. Your information will never be shared with 3rd parties.</summary>
	public bool bSuppressIndustryPopup;
}
