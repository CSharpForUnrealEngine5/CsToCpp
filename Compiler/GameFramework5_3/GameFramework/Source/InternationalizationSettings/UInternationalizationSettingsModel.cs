namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements loading and saving of internationalization settings.</summary>
[CppInclude("InternationalizationSettingsModel.h")]
public partial class UInternationalizationSettingsModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Timezone to use for display purposes in FDateTime</summary>
	public ETimezoneSetting DisplayTimezone;
}
