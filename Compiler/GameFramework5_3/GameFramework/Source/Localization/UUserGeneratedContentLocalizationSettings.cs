namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling UGC localization.</summary>
[CppInclude("UserGeneratedContentLocalization.h")]
public partial class UUserGeneratedContentLocalizationSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of cultures that should be disabled for UGC localization.</summary>
	public TArray<string> CulturesToDisable;
	///<summary>Should we compile UGC localization (if present) for DLC plugins during cook?</summary>
	public bool bCompileDLCLocalizationDuringCook;
	///<summary>Should we validate UGC localization (if present) for DLC plugins during cook?</summary>
	public bool bValidateDLCLocalizationDuringCook;
}
