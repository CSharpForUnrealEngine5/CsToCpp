#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling UGC localization.</summary>
[CppInclude("UserGeneratedContentLocalization.h")]
public partial class UUserGeneratedContentLocalizationSettings : UObject {
	///<summary>List of cultures that should be disabled for UGC localization.</summary>
	public TArray<string> CulturesToDisable;
	///<summary>Should we compile UGC localization (if present) for DLC plugins during cook?</summary>
	public bool bCompileDLCLocalizationDuringCook;
	///<summary>Should we validate UGC localization (if present) for DLC plugins during cook?</summary>
	public bool bValidateDLCLocalizationDuringCook;
}
